using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace DetelinaReport
{
    public partial class DetelinaReport : Form
    {
        public DetelinaReport()
        {
            InitializeComponent();
            textFinalPrice.Text = String.Format("{0:C}", 0.00);
            setupUsers();
        }

        private void setupUsers()
        {
            using (FbConnection connection = daoFirebird.getInstance().getConnection())
            {
                connection.Open();
                FbCommand command = new FbCommand(getSelectUsers(), connection);
                using (FbDataReader dataReader = command.ExecuteReader())
                {
                    List<User> usersList = new List<User>();
                    while (dataReader.Read())
                    {
                        usersList.Add(new User(dataReader.GetInt16(0), dataReader["OPERATOR_FULLNAME"].ToString()));
                    }
                    users.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
                    users.DataSource = usersList;
                    users.DisplayMember = "Name";
                    users.ValueMember = "ID";
                    users.SelectedIndexChanged += listBox1_SelectedIndexChanged;
                }
                connection.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setupSales();
        }

        private void salesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            saleView.Clear();
            string selectedSale = salesList.SelectedValue.ToString();
            using (FbConnection connection = daoFirebird.getInstance().getConnection())
            {
                connection.Open();
                FbCommand command = new FbCommand(getSelectSale(selectedSale), connection);
                using (FbDataReader dataReader = command.ExecuteReader())
                {
                    initializeListView();
                    double finalPrice = 0;
                    while (dataReader.Read())
                    {
                        ListViewItem listItem = new ListViewItem(dataReader[1].ToString());
                        listItem.SubItems.Add(dataReader[2].ToString());
                        listItem.SubItems.Add(String.Format("{0:C}", dataReader.GetValue(3)));
                        listItem.SubItems.Add(String.Format("{0:C}", dataReader.GetValue(4)));
                        saleView.Items.Add(listItem);
                        finalPrice += dataReader.GetDouble(4);
                    }
                    saleView.Focus();
                    saleView.Items[0].Selected = true;
                    textFinalPrice.Text = String.Format("{0:C}", finalPrice);
                }
            }
        }

        private void setupSales()
        {
            string selectedUser = users.SelectedValue.ToString();
            using (FbConnection connection = daoFirebird.getInstance().getConnection())
            {
                connection.Open();
                FbCommand command = new FbCommand(getSelectLastSales(selectedUser), connection);
                using (FbDataReader dataReader = command.ExecuteReader())
                {
                    String name;
                    List<Bon> bonList = new List<Bon>();
                    while (dataReader.Read())
                    {
                        name = String.Format("Дата: {0}, Маса: {1}, Сума: {2}",
                            dataReader["SELL_DATETIME"].ToString(),
                            dataReader["SELL_TBLNUMB"].ToString(),
                            dataReader["SELL_SUM"].ToString());
                        bonList.Add(new Bon(dataReader.GetInt16(0), name));
                    }
                    salesList.SelectedIndexChanged -= salesList_SelectedIndexChanged;
                    salesList.DataSource = bonList;
                    salesList.DisplayMember = "Date";
                    salesList.ValueMember = "ID";
                    salesList.SelectedIndexChanged += salesList_SelectedIndexChanged;
                }
                connection.Close();
            }
        }

        private string getSelectUsers()
        {
            return ConfigurationManager.AppSettings["SelectUsersCommand"].ToString();
        }

        private string getSelectLastSales(string userId)
        {
            string maxSales = ConfigurationManager.AppSettings["MaxSalesCount"].ToString();
            return String.Format(ConfigurationManager.AppSettings["SelectSalesCommand"].ToString(), maxSales, userId);
        }

        private string getSelectSale(string saleId)
        {
            return String.Format(ConfigurationManager.AppSettings["SelectSaleCommand"].ToString(), saleId);
        }

        private void initializeListView()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            columnHeader1.Text = "Продукт";
            columnHeader1.TextAlign = HorizontalAlignment.Left;
            columnHeader1.Width = 250;

            ColumnHeader columnHeader2 = new ColumnHeader();
            columnHeader2.Text = "Количество";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;

            ColumnHeader columnHeader3 = new ColumnHeader();
            columnHeader3.Text = "Цена";
            columnHeader3.TextAlign = HorizontalAlignment.Right;
            columnHeader3.Width = 100;

            ColumnHeader columnHeader4 = new ColumnHeader();
            columnHeader4.Text = "Обща сума";
            columnHeader4.TextAlign = HorizontalAlignment.Right;
            columnHeader4.Width = 100;

            saleView.View = View.Details;
            saleView.FullRowSelect = true;
            saleView.Columns.Add(columnHeader1);
            saleView.Columns.Add(columnHeader2);
            saleView.Columns.Add(columnHeader3);
            saleView.Columns.Add(columnHeader4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saleView.Clear();
            setupSales();
        }
    }
}
