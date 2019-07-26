namespace Accounting.Bilgi
{
    partial class frmEmployee
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
            this.txtUname = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KulName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBaslangic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpUhiredate = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtUtitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(157, 70);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(197, 20);
            this.txtUname.TabIndex = 1;
            this.txtUname.TextChanged += new System.EventHandler(this.txtUname_TextChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.btnSil);
            this.splitContainer1.Size = new System.Drawing.Size(598, 546);
            this.splitContainer1.SplitterDistance = 452;
            this.splitContainer1.TabIndex = 2;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.KulName,
            this.IsBaslangic,
            this.Phone});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 158);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(594, 290);
            this.Liste.TabIndex = 1;
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Title.HeaderText = "Ünvan";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 64;
            // 
            // KulName
            // 
            this.KulName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KulName.HeaderText = "Kullanıcı Adı";
            this.KulName.Name = "KulName";
            this.KulName.ReadOnly = true;
            // 
            // IsBaslangic
            // 
            this.IsBaslangic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsBaslangic.HeaderText = "İşe Başlama";
            this.IsBaslangic.Name = "IsBaslangic";
            this.IsBaslangic.ReadOnly = true;
            this.IsBaslangic.Width = 89;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Phone.HeaderText = "Telefon";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dtpUhiredate);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtUtitle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUphone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 158);
            this.panel1.TabIndex = 0;
            // 
            // dtpUhiredate
            // 
            this.dtpUhiredate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUhiredate.Location = new System.Drawing.Point(157, 96);
            this.dtpUhiredate.Name = "dtpUhiredate";
            this.dtpUhiredate.Size = new System.Drawing.Size(197, 20);
            this.dtpUhiredate.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(594, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtUtitle
            // 
            this.txtUtitle.Location = new System.Drawing.Point(157, 44);
            this.txtUtitle.Name = "txtUtitle";
            this.txtUtitle.Size = new System.Drawing.Size(197, 20);
            this.txtUtitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ünvan :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kullanıcı Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUphone
            // 
            this.txtUphone.Location = new System.Drawing.Point(157, 122);
            this.txtUphone.Name = "txtUphone";
            this.txtUphone.Size = new System.Drawing.Size(197, 20);
            this.txtUphone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(44, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 55);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(594, 31);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(594, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 546);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DateTimePicker dtpUhiredate;
        private System.Windows.Forms.TextBox txtUtitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn KulName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBaslangic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}