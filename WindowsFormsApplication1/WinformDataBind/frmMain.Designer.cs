namespace WinformDataBind
{
    partial class frmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMaster = new System.Windows.Forms.DataGridView();
            this.btnInitData = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaster
            // 
            this.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaster.Location = new System.Drawing.Point(12, 160);
            this.dgvMaster.Name = "dgvMaster";
            this.dgvMaster.RowTemplate.Height = 24;
            this.dgvMaster.Size = new System.Drawing.Size(474, 378);
            this.dgvMaster.TabIndex = 0;
            this.dgvMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaster_CellContentClick);
            this.dgvMaster.SelectionChanged += new System.EventHandler(this.dgvMaster_SelectionChanged);
            // 
            // btnInitData
            // 
            this.btnInitData.Location = new System.Drawing.Point(12, 12);
            this.btnInitData.Name = "btnInitData";
            this.btnInitData.Size = new System.Drawing.Size(75, 23);
            this.btnInitData.TabIndex = 1;
            this.btnInitData.Text = "綁資料";
            this.btnInitData.UseVisualStyleBackColor = true;
            this.btnInitData.Click += new System.EventHandler(this.btnInitData_Click);
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(134, 12);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(75, 23);
            this.btnAddOne.TabIndex = 2;
            this.btnAddOne.Text = "新增一筆";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 550);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnInitData);
            this.Controls.Add(this.dgvMaster);
            this.Name = "frmMain";
            this.Text = "WinformDatabind";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaster;
        private System.Windows.Forms.Button btnInitData;
        private System.Windows.Forms.Button btnAddOne;
    }
}

