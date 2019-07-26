namespace Accounting.AlSat
{
    partial class frmAlis
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urncmb = new System.Windows.Forms.ComboBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPersonel = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAlisNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(0, 398);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(286, 48);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.urncmb);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 398);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 48);
            this.panel1.TabIndex = 4;
            // 
            // urncmb
            // 
            this.urncmb.FormattingEnabled = true;
            this.urncmb.Location = new System.Drawing.Point(182, 15);
            this.urncmb.Name = "urncmb";
            this.urncmb.Size = new System.Drawing.Size(121, 21);
            this.urncmb.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 48);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(482, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 48);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Firma Adı :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(286, 50);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPersonel
            // 
            this.txtPersonel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPersonel.Location = new System.Drawing.Point(78, 148);
            this.txtPersonel.Name = "txtPersonel";
            this.txtPersonel.Size = new System.Drawing.Size(205, 20);
            this.txtPersonel.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCollapse);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.dtpTarih);
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.txtAlisNo);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtFirma);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtPersonel);
            this.splitContainer1.Size = new System.Drawing.Size(878, 450);
            this.splitContainer1.SplitterDistance = 584;
            this.splitContainer1.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunId,
            this.UrunAdi,
            this.LotSeri,
            this.AFiyat,
            this.Adet,
            this.barcode});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(557, 398);
            this.Liste.TabIndex = 6;
            this.Liste.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEndEdit);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunId.HeaderText = "Ürün No";
            this.UrunId.Name = "UrunId";
            this.UrunId.Width = 72;
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LotSeri.HeaderText = "Lot/Seri No";
            this.LotSeri.Name = "LotSeri";
            // 
            // AFiyat
            // 
            this.AFiyat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AFiyat.HeaderText = "Alış Fiyatı";
            this.AFiyat.Name = "AFiyat";
            this.AFiyat.Width = 69;
            // 
            // Adet
            // 
            this.Adet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            this.Adet.Width = 54;
            // 
            // barcode
            // 
            this.barcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.barcode.HeaderText = "barkod";
            this.barcode.Name = "barcode";
            this.barcode.ReadOnly = true;
            this.barcode.Width = 65;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Red;
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapse.Font = new System.Drawing.Font("Franklin Gothic Heavy", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCollapse.ForeColor = System.Drawing.Color.White;
            this.btnCollapse.Location = new System.Drawing.Point(557, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(23, 446);
            this.btnCollapse.TabIndex = 5;
            this.btnCollapse.Text = "GİZLE";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(78, 122);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(205, 20);
            this.dtpTarih.TabIndex = 2;
            // 
            // txtAlisNo
            // 
            this.txtAlisNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlisNo.Location = new System.Drawing.Point(78, 70);
            this.txtAlisNo.Name = "txtAlisNo";
            this.txtAlisNo.ReadOnly = true;
            this.txtAlisNo.Size = new System.Drawing.Size(205, 20);
            this.txtAlisNo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alış No :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirma
            // 
            this.txtFirma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirma.Location = new System.Drawing.Point(78, 96);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.ReadOnly = true;
            this.txtFirma.Size = new System.Drawing.Size(205, 20);
            this.txtFirma.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Personel :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAlis";
            this.Text = "frmAlis";
            this.Load += new System.EventHandler(this.frmAlis_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPersonel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.ComboBox urncmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        public System.Windows.Forms.TextBox txtAlisNo;
    }
}