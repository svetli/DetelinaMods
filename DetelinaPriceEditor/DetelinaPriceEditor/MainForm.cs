using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using System.IO;

namespace DetelinaPriceEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DGToFile.AllowDrop = true;
            DGToFile.DragEnter += new DragEventHandler(DGToFile_DragEnter);
            DGToFile.DragDrop += new DragEventHandler(DGToFile_DragDrop);
            DGFromDatabase.MouseMove += new MouseEventHandler(DGFromDatabase_MouseMove);
            DGFromDatabase.KeyUp += new KeyEventHandler(DGFromDatabase_KeyUp);
        }

        void DGFromDatabase_KeyUp(object sender, KeyEventArgs e)
        {
            if (DGFromDatabase.SelectedRows.Count == 0)
            {
                return;
            }

            if (e.KeyCode == Keys.Add)
            {
                PriceEdit priceEdit = new PriceEdit();
                DataGridViewRow row = DGFromDatabase.SelectedRows[0] as DataGridViewRow;
                priceEdit.Price = row.Cells["productPrice"].Value.ToString();
                if (priceEdit.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow newRow = row.Clone() as DataGridViewRow;
                    newRow.Cells[0].Value = row.Cells[0].Value;
                    newRow.Cells[1].Value = row.Cells[1].Value;
                    newRow.Cells[2].Value = row.Cells[2].Value;
                    newRow.Cells[3].Value = priceEdit.Price;
                    this.DGToFile.Rows.Add(newRow);
                }

                DGFromDatabase.Select();
                DGFromDatabase.Rows[row.Index + 1].Selected = true;
            }
        }

        void DGToFile_DragDrop(object sender, DragEventArgs e)
        {
            PriceEdit priceEdit = new PriceEdit();
            DataGridViewRow row = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
            priceEdit.Price = row.Cells["productPrice"].Value.ToString();

            if (priceEdit.ShowDialog() == DialogResult.OK)
            {
                if (row != null)
                {
                    DataGridViewRow newRow = row.Clone() as DataGridViewRow;
                    newRow.Cells[0].Value = row.Cells[0].Value;
                    newRow.Cells[1].Value = row.Cells[1].Value;
                    newRow.Cells[2].Value = row.Cells[2].Value;
                    newRow.Cells[3].Value = priceEdit.Price;
                    this.DGToFile.Rows.Add(newRow);
                }
            }
        }

        void DGToFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        void DGFromDatabase_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DGFromDatabase.DoDragDrop(this.DGFromDatabase.CurrentRow, DragDropEffects.All);
            }
        }

        private void bLoadFromDB_Click(object sender, EventArgs e)
        {
            if (this.BWLoad.IsBusy)
                return;
            this.bLoadFromDB.Enabled = false;
            this.pbLoad.Style = ProgressBarStyle.Marquee;
            this.BWLoad.RunWorkerAsync();
        }

        private List<DataGridViewRow> rowsLoaded = new List<DataGridViewRow>();
        private void BWLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            using (FbConnection connection = DAOFirebird.getInstance().getConnection())
            {
                connection.Open();
                FbCommand command = new FbCommand("SELECT PLU_NUMB, PLU_NAME, PLU_SELL_PRICE FROM PLUES", connection);
                using (FbDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        DataGridViewRow row = new DataGridViewRow();

                        DataGridViewCell cellId = new DataGridViewTextBoxCell();
                        cellId.Value = dataReader.GetString(0);
                        row.Cells.Add(cellId);
                        
                        DataGridViewCell cellName = new DataGridViewTextBoxCell();
                        cellName.Value = dataReader.GetString(1);
                        row.Cells.Add(cellName);

                        DataGridViewCell cellPrice = new DataGridViewTextBoxCell();
                        cellPrice.Value = String.Format("{0:0.00}", dataReader.GetDouble(2)).Replace(",",".");
                        row.Cells.Add(cellPrice);

                        DataGridViewCell cellNull = new DataGridViewTextBoxCell();
                        cellNull.Value = null;
                        row.Cells.Add(cellNull);

                        rowsLoaded.Add(row);
                    }
                }
                connection.Close();
            }
        }

        void BWLoad_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bLoadFromDB.Enabled = true;
            this.pbLoad.Style = ProgressBarStyle.Blocks;
            DGFromDatabase.Rows.Clear();
            DGFromDatabase.Rows.AddRange(rowsLoaded.ToArray());
        }



        private void bSaveToFile_Click(object sender, EventArgs e)
        {
            if (BWSave.IsBusy)
                return;

            bSaveToFile.Enabled = false;
            pbSave.Style = ProgressBarStyle.Marquee;
            BWSave.RunWorkerAsync();
        }

        private void BWSave_DoWork(object sender, DoWorkEventArgs e)
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "products";
            DataTable dt = new DataTable();
            dt.TableName = "product";

            foreach (DataGridViewColumn dc in DGToFile.Columns)
            {
                dt.Columns.Add(dc.Name);
            }

            object[] cellValues = new object[DGToFile.Columns.Count];
            foreach (DataGridViewRow row in DGToFile.Rows)
            {
                if (row == null)
                    continue;

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            ds.Tables.Add(dt);
            ds.WriteXml(File.OpenWrite("DetelinaPriceMaping.xml"));
        }


        void BWSave_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bSaveToFile.Enabled = true;
            this.pbSave.Style = ProgressBarStyle.Blocks;
            DGToFile.Rows.Clear();
        }

        private void DGToFile_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
