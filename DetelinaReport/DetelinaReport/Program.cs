using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Globalization;
using FirebirdSql.Data.FirebirdClient;

namespace ConsoleApplication1
{
    static class Program
    {
        static void Main(string[] args)
        {
            setupConnection();
        }

        static void setupConnection()
        {
            try
            {
                // init connection
                FbConnection conn = new FbConnection( getConnectionString() );
                conn.Open();
                // read command
                FbCommand readCmd = new FbCommand( getSelectString(), conn);
                FbDataReader dataReader = readCmd.ExecuteReader();
                // open file reader
                TextWriter fh = new StreamWriter(getReportPath());
                // reset
                double bonFinalPrice = 0;
                double finalPrice = 0;
                double currentBon = 0;
                double finalFiscal = 0;
                double finalUnfiscal = 0;
                double kitchenFinal = 0;
                double otherFinal = 0;

                while (dataReader.Read())
                {
                    double bonPrice = dataReader.GetDouble(6);
                    double bonId = dataReader.GetDouble(0);

                    if (currentBon == 0)
                    {
                        currentBon = bonId;
                    }

                    String forWrite = String.Format("{0}\t{1}\t{2}\t{3:F} x {4:C}\t{5:C}\t{6}",
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4),
                        dataReader.GetValue(5),
                        dataReader.GetValue(6),
                        dataReader.GetValue(7));

                    if (bonId != currentBon)
                    {
                        fh.WriteLine("-------------------------------------------------------------------------------------------");
                        fh.WriteLine("\tObshta suma ot bon: {0:C}", bonFinalPrice);
                        fh.WriteLine("-------------------------------------------------------------------------------------------");
                        bonFinalPrice = 0;
                        currentBon = bonId;
                    }

                    if (dataReader.GetValue(1).ToString() == "1")
                    {
                        finalFiscal += bonPrice;
                    }
                    else
                    {
                        finalUnfiscal += bonPrice;
                    }

                    if (dataReader.GetValue(8).ToString() == getKitchenGroup())
                    {
                        kitchenFinal += bonPrice;
                    }
                    else
                    {
                        otherFinal += bonPrice;
                    }

                    bonFinalPrice += bonPrice;
                    finalPrice += bonPrice;
                    fh.WriteLine(forWrite + "\r");
                }

                // Write Final Price
                fh.WriteLine("-------------------------------------------------------------------------------------------");
                fh.WriteLine("\tOBSHTA SUMA OT SMIANA:  {0:C}", finalPrice);
                fh.WriteLine("\tOBSHTA SUMA OT FISCAL:  {0:C}", finalFiscal);
                fh.WriteLine("\tOBSHTA SUMA OT NEFISCAL:{0:C}", finalUnfiscal);
                fh.WriteLine("\tOBSHTA SUMA OT KUHNIA:  {0:C}", kitchenFinal);
                fh.WriteLine("\tOBSHTA SUMA OT BAR:     {0:C}", otherFinal);
                fh.WriteLine("-------------------------------------------------------------------------------------------");

                // Close TextWriter and Firebird connection
                fh.Close(); conn.Close();
            }
            catch (FbException e)
            {
                Console.WriteLine("[Error: {0}]", e.ToString());
            }
        }

        static String getConnectionString()
        {
            String connectionString = ConfigurationManager.ConnectionStrings["FirebirdConnectionString"].ToString();
            return connectionString;
        }

        static String getSelectString()
        {
            String selectionString = ConfigurationManager.AppSettings["SelectCommand"].ToString();
            return String.Format(selectionString, getStartDate(), getEndDate());
        }

        static String getEndDate()
        {
            return DateTime.Now.ToString("dd.MM.yyyy, HH:mm:ss");
        }

        static String getStartDate()
        {
            String timeOffset = ConfigurationManager.AppSettings["timeOffset"].ToString();
            DateTime value = DateTime.Now.AddHours(Convert.ToDouble(timeOffset));
            return value.ToString("dd.MM.yyyy, HH:mm:ss");
        }

        static String getReportFileName()
        {
            return String.Format("{0}_{1}", DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss"), ".txt");
        }

        static String getReportPath()
        {
            String path = ConfigurationManager.AppSettings["PathToReport"].ToString();
            return Path.Combine(path, getReportFileName());
        }

        static String getKitchenGroup()
        {
            return ConfigurationManager.AppSettings["KitchenGroup"].ToString();
        }
    }
}
