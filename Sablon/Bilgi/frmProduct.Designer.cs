namespace Accounting.Bilgi
{
    partial class frmProduct
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
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.txtUadi = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtUsiraNo = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(0, 210);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 48);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 50);
            this.panel1.TabIndex = 4;
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 50);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPrint.Location = new System.Drawing.Point(538, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 50);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Not :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birim Fiyatı :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Ürün Sıra No :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Kategori Adı :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKapat.Location = new System.Drawing.Point(0, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(175, 50);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(121, 152);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(201, 20);
            this.txtBirimFiyat.TabIndex = 0;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(121, 90);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(302, 56);
            this.txtNot.TabIndex = 0;
            // 
            // txtUadi
            // 
            this.txtUadi.Location = new System.Drawing.Point(121, 37);
            this.txtUadi.Name = "txtUadi";
            this.txtUadi.Size = new System.Drawing.Size(201, 20);
            this.txtUadi.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBirimFiyat);
            this.splitContainer1.Panel1.Controls.Add(this.txtNot);
            this.splitContainer1.Panel1.Controls.Add(this.txtUsiraNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtKategori);
            this.splitContainer1.Panel1.Controls.Add(this.txtUadi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 262);
            this.splitContainer1.SplitterDistance = 617;
            this.splitContainer1.TabIndex = 1;
            // 
            // txtUsiraNo
            // 
            this.txtUsiraNo.Location = new System.Drawing.Point(121, 11);
            this.txtUsiraNo.Name = "txtUsiraNo";
            this.txtUsiraNo.ReadOnly = true;
            this.txtUsiraNo.Size = new System.Drawing.Size(201, 20);
            this.txtUsiraNo.TabIndex = 0;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(121, 65);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(201, 20);
            this.txtKategori.TabIndex = 0;
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 262);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProduct";
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.TextBox txtUadi;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtUsiraNo;
        private System.Windows.Forms.TextBox txtKategori;
    }
}