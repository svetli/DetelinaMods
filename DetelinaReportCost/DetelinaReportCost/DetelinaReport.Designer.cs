namespace DetelinaReportCost
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.workTimeBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowReportBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reportView = new System.Windows.Forms.ListView();
            this.textFinalCost = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "dd.MM.yyyy";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(12, 36);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(268, 20);
            this.startDatePicker.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата:";
            // 
            // workTimeBox
            // 
            this.workTimeBox.FormattingEnabled = true;
            this.workTimeBox.Location = new System.Drawing.Point(12, 81);
            this.workTimeBox.Name = "workTimeBox";
            this.workTimeBox.Size = new System.Drawing.Size(268, 21);
            this.workTimeBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Смяна:";
            // 
            // ShowReportBtn
            // 
            this.ShowReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowReportBtn.Location = new System.Drawing.Point(12, 114);
            this.ShowReportBtn.Name = "ShowReportBtn";
            this.ShowReportBtn.Size = new System.Drawing.Size(268, 23);
            this.ShowReportBtn.TabIndex = 4;
            this.ShowReportBtn.Text = "ИЗВАДИ ОТЧЕТ";
            this.ShowReportBtn.UseVisualStyleBackColor = true;
            this.ShowReportBtn.Click += new System.EventHandler(this.ShowReportBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "ОТЧЕТ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportView
            // 
            this.reportView.Location = new System.Drawing.Point(12, 174);
            this.reportView.Name = "reportView";
            this.reportView.Size = new System.Drawing.Size(268, 250);
            this.reportView.TabIndex = 7;
            this.reportView.UseCompatibleStateImageBehavior = false;
            this.reportView.View = System.Windows.Forms.View.Details;
            // 
            // textFinalCost
            // 
            this.textFinalCost.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textFinalCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFinalCost.Location = new System.Drawing.Point(180, 434);
            this.textFinalCost.Name = "textFinalCost";
            this.textFinalCost.Size = new System.Drawing.Size(100, 23);
            this.textFinalCost.TabIndex = 8;
            this.textFinalCost.Text = "00.00 лв.";
            this.textFinalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(85, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Общ оборот:";
            // 
            // DetelinaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 466);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFinalCost);
            this.Controls.Add(this.reportView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowReportBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workTimeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDatePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DetelinaReport";
            this.Text = "Детелина Отчети";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workTimeBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowReportBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView reportView;
        private System.Windows.Forms.Label textFinalCost;
        private System.Windows.Forms.Label label4;
    }
}

