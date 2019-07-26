namespace Accounting.Bilgi
{
    partial class frmShipper
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCargoName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CargoName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtCargoName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 112);
            this.panel1.TabIndex = 0;
            // 
            // txtCargoName
            // 
            this.txtCargoName.Location = new System.Drawing.Point(142, 33);
            this.txtCargoName.Multiline = true;
            this.txtCargoName.Name = "txtCargoName";
            this.txtCargoName.Size = new System.Drawing.Size(219, 23);
            this.txtCargoName.TabIndex = 4;
            this.txtCargoName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargoName_KeyPress);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kargo Adı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Green;
            this.btnKaydet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(0, 0);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(506, 30);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kayıt";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(142, 71);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(219, 23);
            this.txtPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefon :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Panel2.Controls.Add(this.btnSil);
            this.splitContainer1.Size = new System.Drawing.Size(510, 490);
            this.splitContainer1.SplitterDistance = 384;
            this.splitContainer1.TabIndex = 1;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CargoName,
            this.Phone});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 112);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(506, 268);
            this.Liste.TabIndex = 1;
            this.Liste.Click += new System.EventHandler(this.Liste_Click_1);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // CargoName
            // 
            this.CargoName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CargoName.HeaderText = "Kargo Adı";
            this.CargoName.Name = "CargoName";
            this.CargoName.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Phone.HeaderText = "Telefon";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 68;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Blue;
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(0, 68);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(506, 30);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Formu Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(0, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(506, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 490);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmShippers";
            this.Text = "frmShippers";
            this.Load += new System.EventHandler(this.frmShippers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtCargoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CargoName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}