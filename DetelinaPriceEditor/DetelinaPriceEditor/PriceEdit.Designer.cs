namespace DetelinaPriceEditor
{
    partial class PriceEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priceOK = new System.Windows.Forms.Button();
            this.priceCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceOK
            // 
            this.priceOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceOK.Location = new System.Drawing.Point(12, 57);
            this.priceOK.Name = "priceOK";
            this.priceOK.Size = new System.Drawing.Size(100, 23);
            this.priceOK.TabIndex = 1;
            this.priceOK.Text = "ПРОДЪЛЖИ";
            this.priceOK.UseVisualStyleBackColor = true;
            this.priceOK.Click += new System.EventHandler(this.priceOK_Click);
            // 
            // priceCancel
            // 
            this.priceCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceCancel.Location = new System.Drawing.Point(214, 57);
            this.priceCancel.Name = "priceCancel";
            this.priceCancel.Size = new System.Drawing.Size(89, 23);
            this.priceCancel.TabIndex = 2;
            this.priceCancel.Text = "ОТКАЖИ";
            this.priceCancel.UseVisualStyleBackColor = true;
            this.priceCancel.Click += new System.EventHandler(this.priceCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "НОВА ЦЕНА";
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(12, 31);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(291, 20);
            this.priceBox.TabIndex = 0;
            // 
            // PriceEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 92);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceCancel);
            this.Controls.Add(this.priceOK);
            this.Name = "PriceEdit";
            this.Text = "PriceEdit";
            this.Load += new System.EventHandler(this.PriceEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button priceOK;
        private System.Windows.Forms.Button priceCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceBox;
    }
}