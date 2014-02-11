namespace DetelinaReport
{
    partial class DetelinaReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetelinaReport));
            this.users = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.salesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saleView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textFinalPrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // users
            // 
            this.users.FormattingEnabled = true;
            this.users.Location = new System.Drawing.Point(12, 58);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(300, 108);
            this.users.TabIndex = 0;
            this.users.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сервитьор";
            // 
            // salesList
            // 
            this.salesList.FormattingEnabled = true;
            this.salesList.Location = new System.Drawing.Point(328, 58);
            this.salesList.Name = "salesList";
            this.salesList.Size = new System.Drawing.Size(434, 108);
            this.salesList.TabIndex = 2;
            this.salesList.SelectedIndexChanged += new System.EventHandler(this.salesList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(325, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Последни Сметки";
            // 
            // saleView
            // 
            this.saleView.Location = new System.Drawing.Point(12, 201);
            this.saleView.Name = "saleView";
            this.saleView.Size = new System.Drawing.Size(750, 255);
            this.saleView.TabIndex = 5;
            this.saleView.UseCompatibleStateImageBehavior = false;
            this.saleView.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(516, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Обща сума:";
            // 
            // textFinalPrice
            // 
            this.textFinalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFinalPrice.Location = new System.Drawing.Point(635, 473);
            this.textFinalPrice.Name = "textFinalPrice";
            this.textFinalPrice.Size = new System.Drawing.Size(127, 19);
            this.textFinalPrice.TabIndex = 7;
            this.textFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обнови";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DetelinaReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(772, 516);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textFinalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saleView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.users);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetelinaReport";
            this.Text = "DetelinaReport by Svetli Nikolov";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox salesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView saleView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textFinalPrice;
        private System.Windows.Forms.Button button1;
    }
}

