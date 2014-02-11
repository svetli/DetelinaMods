using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.Xml;

namespace DetelinaChangePrice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bFirst_Click(object sender, EventArgs e)
        {
            this.LoadPricesToDatabase("firstPrice");
        }

        private void bSecond_Click(object sender, EventArgs e)
        {
            this.LoadPricesToDatabase("secondPrice");
        }

        private void LoadPricesToDatabase(string field)
        {
            bFirst.Enabled = false;
            bSecond.Enabled = false;

            pbUpdate.Style = ProgressBarStyle.Marquee;
            BWUpdate.RunWorkerAsync(field);
        }

        private void BWUpdate_DoWork(object sender, DoWorkEventArgs e)
        {
            var fieldIndex = (e.Argument.ToString() == "firstPrice") ? 2 : 3;

            using (FbConnection connection = DAOFirebird.getInstance().getConnection())
            {
                connection.Open();

                using (FbTransaction transaction = connection.BeginTransaction())
                {
                    XmlDocument xml = new XmlDocument();
                    xml.Load("DetelinaPriceMaping.xml");

                    try
                    {
                        foreach (XmlNode node in xml.DocumentElement.ChildNodes)
                        {
                            if (node.HasChildNodes)
                            {
                                string price = node.ChildNodes[fieldIndex].InnerText;
                                string cmdText = String.Format("UPDATE PLUES SET PLU_SELL_PRICE = '{0:0.00}' WHERE PLU_NUMB = {1}", price, node.ChildNodes[0].InnerText);
                                FbCommand cmd = new FbCommand(cmdText, connection, transaction);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(e.ToString(), "Грешка", MessageBoxButtons.OK);
                    }
                    finally
                    {
                        transaction.Commit();
                        transaction.Dispose();
                    }
                }

                connection.Close();
            }
        }

        private void BWUpdate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bFirst.Enabled = true;
            bSecond.Enabled = true;
            pbUpdate.Style = ProgressBarStyle.Blocks;
            MessageBox.Show("Операцията завършена. Можете да маркирате.", "Внимание", MessageBoxButtons.OK);
        }
    }
}
