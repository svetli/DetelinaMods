namespace DetelinaChangePrice
{
    partial class MainForm
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
            this.bFirst = new System.Windows.Forms.Button();
            this.bSecond = new System.Windows.Forms.Button();
            this.BWUpdate = new System.ComponentModel.BackgroundWorker();
            this.pbUpdate = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // bFirst
            // 
            this.bFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bFirst.Location = new System.Drawing.Point(12, 12);
            this.bFirst.Name = "bFirst";
            this.bFirst.Size = new System.Drawing.Size(120, 50);
            this.bFirst.TabIndex = 0;
            this.bFirst.Text = "СМЯНА 1";
            this.bFirst.UseVisualStyleBackColor = true;
            this.bFirst.Click += new System.EventHandler(this.bFirst_Click);
            // 
            // bSecond
            // 
            this.bSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSecond.Location = new System.Drawing.Point(160, 12);
            this.bSecond.Name = "bSecond";
            this.bSecond.Size = new System.Drawing.Size(120, 50);
            this.bSecond.TabIndex = 1;
            this.bSecond.Text = "СМЯНА 2";
            this.bSecond.UseVisualStyleBackColor = true;
            this.bSecond.Click += new System.EventHandler(this.bSecond_Click);
            // 
            // BWUpdate
            // 
            this.BWUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWUpdate_DoWork);
            this.BWUpdate.RunWorkerCompleted +=new System.ComponentModel.RunWorkerCompletedEventHandler(BWUpdate_RunWorkerCompleted);
            // 
            // pbUpdate
            // 
            this.pbUpdate.Location = new System.Drawing.Point(12, 68);
            this.pbUpdate.Name = "pbUpdate";
            this.pbUpdate.Size = new System.Drawing.Size(268, 10);
            this.pbUpdate.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 89);
            this.Controls.Add(this.pbUpdate);
            this.Controls.Add(this.bSecond);
            this.Controls.Add(this.bFirst);
            this.Name = "MainForm";
            this.Text = "СМЕНИ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bFirst;
        private System.Windows.Forms.Button bSecond;
        private System.ComponentModel.BackgroundWorker BWUpdate;
        private System.Windows.Forms.ProgressBar pbUpdate;
    }
}

