namespace DetelinaPriceEditor
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
            this.DGFromDatabase = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPriceOrig = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGToFile = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bLoadFromDB = new System.Windows.Forms.Button();
            this.bSaveToFile = new System.Windows.Forms.Button();
            this.BWLoad = new System.ComponentModel.BackgroundWorker();
            this.pbLoad = new System.Windows.Forms.ProgressBar();
            this.pbSave = new System.Windows.Forms.ProgressBar();
            this.BWSave = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.DGFromDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGToFile)).BeginInit();
            this.SuspendLayout();
            // 
            // DGFromDatabase
            // 
            this.DGFromDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGFromDatabase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productName,
            this.productPrice,
            this.secondPriceOrig});
            this.DGFromDatabase.Location = new System.Drawing.Point(12, 12);
            this.DGFromDatabase.MultiSelect = false;
            this.DGFromDatabase.Name = "DGFromDatabase";
            this.DGFromDatabase.ReadOnly = true;
            this.DGFromDatabase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGFromDatabase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGFromDatabase.Size = new System.Drawing.Size(475, 182);
            this.DGFromDatabase.TabIndex = 0;
            // 
            // productId
            // 
            this.productId.HeaderText = "#";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Width = 30;
            // 
            // productName
            // 
            this.productName.HeaderText = "Наименование";
            this.productName.MinimumWidth = 200;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 200;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Смяна 1";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // secondPriceOrig
            // 
            this.secondPriceOrig.HeaderText = "Смяна 2";
            this.secondPriceOrig.Name = "secondPriceOrig";
            this.secondPriceOrig.ReadOnly = true;
            // 
            // DGToFile
            // 
            this.DGToFile.AllowDrop = true;
            this.DGToFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGToFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.firstPrice,
            this.secondPrice});
            this.DGToFile.Location = new System.Drawing.Point(12, 229);
            this.DGToFile.Name = "DGToFile";
            this.DGToFile.Size = new System.Drawing.Size(475, 269);
            this.DGToFile.TabIndex = 1;
            this.DGToFile.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGToFile_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "#";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // name
            // 
            this.name.HeaderText = "Наименование";
            this.name.MinimumWidth = 200;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // firstPrice
            // 
            this.firstPrice.HeaderText = "Смяна 1";
            this.firstPrice.Name = "firstPrice";
            this.firstPrice.ReadOnly = true;
            // 
            // secondPrice
            // 
            this.secondPrice.HeaderText = "Смяна 2";
            this.secondPrice.Name = "secondPrice";
            this.secondPrice.ReadOnly = true;
            // 
            // bLoadFromDB
            // 
            this.bLoadFromDB.Location = new System.Drawing.Point(411, 200);
            this.bLoadFromDB.Name = "bLoadFromDB";
            this.bLoadFromDB.Size = new System.Drawing.Size(75, 23);
            this.bLoadFromDB.TabIndex = 2;
            this.bLoadFromDB.Text = "ЗАРЕДИ";
            this.bLoadFromDB.UseVisualStyleBackColor = true;
            this.bLoadFromDB.Click += new System.EventHandler(this.bLoadFromDB_Click);
            // 
            // bSaveToFile
            // 
            this.bSaveToFile.Location = new System.Drawing.Point(411, 507);
            this.bSaveToFile.Name = "bSaveToFile";
            this.bSaveToFile.Size = new System.Drawing.Size(75, 23);
            this.bSaveToFile.TabIndex = 3;
            this.bSaveToFile.Text = "ЗАПАЗИ";
            this.bSaveToFile.UseVisualStyleBackColor = true;
            this.bSaveToFile.Click += new System.EventHandler(this.bSaveToFile_Click);
            // 
            // BWLoad
            // 
            this.BWLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWLoad_DoWork);
            this.BWLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWLoad_RunWorkerCompleted);
            // 
            // pbLoad
            // 
            this.pbLoad.Location = new System.Drawing.Point(13, 201);
            this.pbLoad.Name = "pbLoad";
            this.pbLoad.Size = new System.Drawing.Size(392, 23);
            this.pbLoad.TabIndex = 4;
            // 
            // pbSave
            // 
            this.pbSave.Location = new System.Drawing.Point(12, 507);
            this.pbSave.Name = "pbSave";
            this.pbSave.Size = new System.Drawing.Size(392, 23);
            this.pbSave.TabIndex = 5;
            // 
            // BWSave
            // 
            this.BWSave.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BWSave_DoWork);
            this.BWSave.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BWSave_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 542);
            this.Controls.Add(this.pbSave);
            this.Controls.Add(this.pbLoad);
            this.Controls.Add(this.bSaveToFile);
            this.Controls.Add(this.bLoadFromDB);
            this.Controls.Add(this.DGToFile);
            this.Controls.Add(this.DGFromDatabase);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGFromDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGToFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGFromDatabase;
        private System.Windows.Forms.DataGridView DGToFile;
        private System.Windows.Forms.Button bLoadFromDB;
        private System.Windows.Forms.Button bSaveToFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondPriceOrig;
        private System.ComponentModel.BackgroundWorker BWLoad;
        private System.Windows.Forms.ProgressBar pbLoad;
        private System.Windows.Forms.ProgressBar pbSave;
        private System.ComponentModel.BackgroundWorker BWSave;

    }
}

