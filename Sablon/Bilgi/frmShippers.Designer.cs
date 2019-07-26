namespace Accounting.Bilgi
{
    partial class frmShippers
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
            this.txtKphone = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKname = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKphone
            // 
            this.txtKphone.Location = new System.Drawing.Point(157, 65);
            this.txtKphone.Name = "txtKphone";
            this.txtKphone.Size = new System.Drawing.Size(197, 20);
            this.txtKphone.TabIndex = 1;
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
            this.splitContainer1.Size = new System.Drawing.Size(390, 450);
            this.splitContainer1.SplitterDistance = 356;
            this.splitContainer1.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.KName,
            this.Phone});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 100);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(386, 252);
            this.Liste.TabIndex = 1;
            this.Liste.Click += new System.EventHandler(this.Liste_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtKname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKphone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(386, 31);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 65);
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
            this.btnKapat.Size = new System.Drawing.Size(386, 31);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Tomato;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(386, 31);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(44, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kargo Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKname
            // 
            this.txtKname.Location = new System.Drawing.Point(157, 37);
            this.txtKname.Name = "txtKname";
            this.txtKname.Size = new System.Drawing.Size(197, 20);
            this.txtKname.TabIndex = 1;
            this.txtKname.TextChanged += new System.EventHandler(this.txtKname_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // KName
            // 
            this.KName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KName.HeaderText = "Kargo Adı";
            this.KName.Name = "KName";
            this.KName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Phone.HeaderText = "Telefon";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 68;
            // 
            // frmShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmShippers";
            this.Text = "frmShippers";
            this.Load += new System.EventHandler(this.frmShippers_Load);
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

        private System.Windows.Forms.TextBox txtKphone;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtKname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}