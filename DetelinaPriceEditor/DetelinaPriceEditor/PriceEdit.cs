using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DetelinaPriceEditor
{
    public partial class PriceEdit : Form
    {
        public PriceEdit()
        {
            InitializeComponent();
            
        }

        public string Price
        {
            get { return this.priceBox.Text; }
            set { this.priceBox.Text = value; }
        }

        private void priceOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void priceCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PriceEdit_Load(object sender, EventArgs e)
        {
            this.priceBox.KeyUp += new KeyEventHandler(priceBox_KeyUp);
        }

        void priceBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                this.DialogResult = DialogResult.OK;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
