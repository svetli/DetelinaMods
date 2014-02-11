using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;
using FirebirdSql.Data.FirebirdClient;

namespace DetelinaReportCost
{
    public partial class DetelinaReport : Form
    {
        public DetelinaReport()
        {
            InitializeComponent();
            InitializeApp();
        }

        protected void InitializeApp()
        {
            List<WTime> wtimeList = new List<WTime>();
            String[] wt = getWorkTimes();
            for (int i = 0; i < wt.Count(); i++)
            {
                String[] t = wt[i].Split(',');
                wtimeList.Add(new WTime(int.Parse(t[0]), t[1]));
            }

            workTimeBox.DataSource = wtimeList;
            workTimeBox.DisplayMember = "Title";
            workTimeBox.ValueMember = "ID";
        }

        private String[] getWorkTimes()
        {
            return ConfigurationManager.AppSettings["WorkTimes"].ToString().Split(';');
        }

        private DateTime getStartDate()
        {
            String[] workTime = getWorkTimeById(getWorkTimeBoxValue());
            DateTime date = DateTime.Parse(startDatePicker.Value.ToString("dd.MM.yyyy") + ", " + workTime[2].ToString());
            return date;
        }

        private DateTime getEndDate()
        {
            String[] workTime = getWorkTimeById(getWorkTimeBoxValue());
            DateTime endDate = DateTime.Parse(startDatePicker.Value.ToString("dd.MM.yyyy") + ", " + workTime[3].ToString());

            int result = DateTime.Compare(endDate, getStartDate());
            if (result < 0)
            {
                return endDate.AddDays(1);
            }

            return endDate;
        }

        private String[] getWorkTimeById(int id)
        {
            String[] wt = getWorkTimes();
            for (int i = 0; i < wt.Count(); i++)
            {
                String[] t = wt[i].Split(',');
                if (id == int.Parse(t[0]))
                {
                    return t;
                }
            }

            throw new Exception("INVALID WORK TIME");
        }

        private int getWorkTimeBoxValue()
        {
            return int.Parse(workTimeBox.SelectedValue.ToString());
        }

        private String getSelectString()
        {
            DateTime startDate = getStartDate();
            DateTime endDate = getEndDate();
            String selectionString = ConfigurationManager.AppSettings["SelectCommand"].ToString();
            selectionString.Replace("&lt;", "<");
            selectionString.Replace("&gt;", ">");
            return String.Format(selectionString, startDate.ToString("dd.MM.yyyy, HH:mm:ss"), endDate.ToString("dd.MM.yyyy, HH:mm:ss"));
        }

        private void ShowReportBtn_Click(object sender, EventArgs e)
        {
            reportView.Clear();
            using (FbConnection connection = daoFirebird.getInstance().getConnection())
            {
                connection.Open();
                FbCommand command = new FbCommand(getSelectString(), connection);
                using (FbDataReader dataReader = command.ExecuteReader())
                {
                    initializeListView();
                    double finalCost = 0;
                    Dictionary<int, string> names = new Dictionary<int, string>();
                    Dictionary<int, double> costs = new Dictionary<int, double>();

                    while (dataReader.Read())
                    {
                        double bonPrice = dataReader.GetDouble(4);
                        int oID = dataReader.GetInt16(2);

                        if (!names.ContainsKey(oID))
                        {
                            names.Add(oID, dataReader[3].ToString());
                        }

                        if (!costs.ContainsKey(oID))
                        {
                            costs.Add(oID, 0);
                        }

                        costs[oID] += bonPrice;
                        finalCost += bonPrice;
                    }

                    textFinalCost.Text = String.Format("{0:C}", finalCost);

                    foreach (KeyValuePair<int, string> pair in names)
                    {
                        ListViewItem listItem = new ListViewItem(pair.Value);
                        listItem.SubItems.Add(String.Format("{0:C}", costs[pair.Key]));
                        reportView.Items.Add(listItem);
                    }
                }
                connection.Close();
            }
        }

        private void initializeListView()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Оператор";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 132;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Оборот";
            columnHeader2.TextAlign = HorizontalAlignment.Left;
            columnHeader2.Width = 132;

            reportView.View = View.Details;
            reportView.FullRowSelect = true;
            reportView.Columns.Add(columnHeader1);
            reportView.Columns.Add(columnHeader2);
        }
    }

    class WTime
    {
        public WTime(int id, string title)
        {
            ID = id;
            Title = title;
        }

        public int ID
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }
    }
}
