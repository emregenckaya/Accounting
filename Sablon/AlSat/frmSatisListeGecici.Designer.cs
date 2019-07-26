namespace Accounting.AlSat
{
    partial class frmSatisListeGecici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PurNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirmaBul = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salesprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lotserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employeeıd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liste = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PurNo,
            this.Company,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(585, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // PurNo
            // 
            this.PurNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PurNo.HeaderText = "Alış No";
            this.PurNo.Name = "PurNo";
            this.PurNo.ReadOnly = true;
            this.PurNo.Width = 65;
            // 
            // Company
            // 
            this.Company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Company.HeaderText = "Firma Adı";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn9.HeaderText = "Alış Tarihi";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 77;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(203, 50);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firma Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirmaBul
            // 
            this.txtFirmaBul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaBul.Location = new System.Drawing.Point(3, 140);
            this.txtFirmaBul.Name = "txtFirmaBul";
            this.txtFirmaBul.Size = new System.Drawing.Size(190, 20);
            this.txtFirmaBul.TabIndex = 3;
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.ForeColor = System.Drawing.Color.Black;
            this.btnBul.Location = new System.Drawing.Point(0, 398);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(203, 48);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste2);
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtFirmaBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 5;
            // 
            // Liste2
            // 
            this.Liste2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn4});
            this.Liste2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste2.Location = new System.Drawing.Point(0, 0);
            this.Liste2.Name = "Liste2";
            this.Liste2.Size = new System.Drawing.Size(585, 446);
            this.Liste2.TabIndex = 1;
            this.Liste2.DoubleClick += new System.EventHandler(this.Liste2_DoubleClick);
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.HeaderText = "SatisNo";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 69;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Firma";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "Tarih";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 56;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Satis Yapan";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 89;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "Kargo Adı";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 78;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantity.HeaderText = "Adet";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 54;
            // 
            // Salesprice
            // 
            this.Salesprice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Salesprice.HeaderText = "Satış fiyatı ";
            this.Salesprice.Name = "Salesprice";
            this.Salesprice.Width = 82;
            // 
            // Lotserial
            // 
            this.Lotserial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Lotserial.HeaderText = "Lot/Seri";
            this.Lotserial.Name = "Lotserial";
            this.Lotserial.Width = 70;
            // 
            // productId
            // 
            this.productId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productId.HeaderText = "ÜrünAdı";
            this.productId.Name = "productId";
            // 
            // shipper
            // 
            this.shipper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.shipper.HeaderText = "Kargo Adı";
            this.shipper.Name = "shipper";
            this.shipper.Width = 78;
            // 
            // Employeeıd
            // 
            this.Employeeıd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Employeeıd.HeaderText = "Satis Yapan";
            this.Employeeıd.Name = "Employeeıd";
            this.Employeeıd.Width = 89;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.HeaderText = "Tarih";
            this.date.Name = "date";
            this.date.Width = 56;
            // 
            // companyId
            // 
            this.companyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyId.HeaderText = "Firma";
            this.companyId.Name = "companyId";
            // 
            // SalesId
            // 
            this.SalesId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SalesId.HeaderText = "SatisNo";
            this.SalesId.Name = "SalesId";
            this.SalesId.Width = 69;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesId,
            this.companyId,
            this.date,
            this.Employeeıd,
            this.shipper,
            this.productId,
            this.Lotserial,
            this.Salesprice,
            this.Quantity});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(800, 450);
            this.Liste.TabIndex = 4;
            // 
            // frmSatisListeGecici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.Liste);
            this.Name = "frmSatisListeGecici";
            this.Text = "frmSatisListeGecici";
            this.Load += new System.EventHandler(this.frmSatisListeGecici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmaBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salesprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipper;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employeeıd;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesId;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}