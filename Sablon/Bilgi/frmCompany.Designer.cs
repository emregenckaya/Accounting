namespace Accounting.Bilgi
{
    partial class frmCompany
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cbFirmaTur = new System.Windows.Forms.ComboBox();
            this.cbSehir = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolge = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtFaks = new System.Windows.Forms.TextBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.txtYetkili = new System.Windows.Forms.TextBox();
            this.txtVn = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtVd = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtFirmaNo = new System.Windows.Forms.TextBox();
            this.txtFadi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.cbFirmaTur);
            this.splitContainer1.Panel1.Controls.Add(this.cbSehir);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBolge);
            this.splitContainer1.Panel1.Controls.Add(this.txtemail);
            this.splitContainer1.Panel1.Controls.Add(this.txtFaks);
            this.splitContainer1.Panel1.Controls.Add(this.txtGsm);
            this.splitContainer1.Panel1.Controls.Add(this.txtYetkili);
            this.splitContainer1.Panel1.Controls.Add(this.txtVn);
            this.splitContainer1.Panel1.Controls.Add(this.txtTel);
            this.splitContainer1.Panel1.Controls.Add(this.txtVd);
            this.splitContainer1.Panel1.Controls.Add(this.txtAdres);
            this.splitContainer1.Panel1.Controls.Add(this.txtFirmaNo);
            this.splitContainer1.Panel1.Controls.Add(this.txtFadi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 444);
            this.splitContainer1.SplitterDistance = 617;
            this.splitContainer1.TabIndex = 0;
            // 
            // cbFirmaTur
            // 
            this.cbFirmaTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFirmaTur.FormattingEnabled = true;
            this.cbFirmaTur.Items.AddRange(new object[] {
            "M",
            "T",
            "MT"});
            this.cbFirmaTur.Location = new System.Drawing.Point(121, 63);
            this.cbFirmaTur.Name = "cbFirmaTur";
            this.cbFirmaTur.Size = new System.Drawing.Size(201, 21);
            this.cbFirmaTur.TabIndex = 3;
            // 
            // cbSehir
            // 
            this.cbSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSehir.FormattingEnabled = true;
            this.cbSehir.Location = new System.Drawing.Point(121, 334);
            this.cbSehir.Name = "cbSehir";
            this.cbSehir.Size = new System.Drawing.Size(201, 21);
            this.cbSehir.TabIndex = 2;
            this.cbSehir.SelectedIndexChanged += new System.EventHandler(this.cbSehir_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(15, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Şehir :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(15, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "E-Mail :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(15, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Faks :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gsm :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(15, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vergi No :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yetkili :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Vergi Dairesi :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(15, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Firma No :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(15, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Firma Türü :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBolge
            // 
            this.txtBolge.Location = new System.Drawing.Point(328, 334);
            this.txtBolge.Name = "txtBolge";
            this.txtBolge.ReadOnly = true;
            this.txtBolge.Size = new System.Drawing.Size(201, 20);
            this.txtBolge.TabIndex = 0;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(121, 308);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(201, 20);
            this.txtemail.TabIndex = 0;
            // 
            // txtFaks
            // 
            this.txtFaks.Location = new System.Drawing.Point(121, 282);
            this.txtFaks.Name = "txtFaks";
            this.txtFaks.Size = new System.Drawing.Size(201, 20);
            this.txtFaks.TabIndex = 0;
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(121, 178);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(201, 20);
            this.txtGsm.TabIndex = 0;
            // 
            // txtYetkili
            // 
            this.txtYetkili.Location = new System.Drawing.Point(121, 256);
            this.txtYetkili.Name = "txtYetkili";
            this.txtYetkili.Size = new System.Drawing.Size(201, 20);
            this.txtYetkili.TabIndex = 0;
            // 
            // txtVn
            // 
            this.txtVn.Location = new System.Drawing.Point(121, 230);
            this.txtVn.Name = "txtVn";
            this.txtVn.Size = new System.Drawing.Size(201, 20);
            this.txtVn.TabIndex = 0;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(121, 152);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(201, 20);
            this.txtTel.TabIndex = 0;
            // 
            // txtVd
            // 
            this.txtVd.Location = new System.Drawing.Point(121, 204);
            this.txtVd.Name = "txtVd";
            this.txtVd.Size = new System.Drawing.Size(201, 20);
            this.txtVd.TabIndex = 0;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(121, 90);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(302, 56);
            this.txtAdres.TabIndex = 0;
            // 
            // txtFirmaNo
            // 
            this.txtFirmaNo.Location = new System.Drawing.Point(121, 11);
            this.txtFirmaNo.Name = "txtFirmaNo";
            this.txtFirmaNo.ReadOnly = true;
            this.txtFirmaNo.Size = new System.Drawing.Size(201, 20);
            this.txtFirmaNo.TabIndex = 0;
            // 
            // txtFadi
            // 
            this.txtFadi.Location = new System.Drawing.Point(121, 37);
            this.txtFadi.Name = "txtFadi";
            this.txtFadi.Size = new System.Drawing.Size(201, 20);
            this.txtFadi.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKaydet.Location = new System.Drawing.Point(0, 392);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(175, 48);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 50);
            this.panel1.TabIndex = 4;
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
            // frmCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 444);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCompany";
            this.Text = "frmCompany";
            this.Load += new System.EventHandler(this.frmCompany_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtFaks;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.TextBox txtYetkili;
        private System.Windows.Forms.TextBox txtVn;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtVd;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtFadi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.ComboBox cbSehir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFirmaNo;
        private System.Windows.Forms.ComboBox cbFirmaTur;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPrint;
    }
}