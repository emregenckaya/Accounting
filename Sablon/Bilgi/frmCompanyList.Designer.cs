namespace Accounting.Bilgi
{
    partial class frmCompanyList
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.txtFirmaBul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYetkiliBul = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtYetkiliBul);
            this.splitContainer1.Panel2.Controls.Add(this.txtFirmaBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Fadi,
            this.Yet,
            this.Tel});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MultiSelect = false;
            this.Liste.Name = "Liste";
            this.Liste.ReadOnly = true;
            this.Liste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Liste.Size = new System.Drawing.Size(585, 446);
            this.Liste.TabIndex = 0;
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
            // Fadi
            // 
            this.Fadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fadi.HeaderText = "Firma Adı";
            this.Fadi.Name = "Fadi";
            this.Fadi.ReadOnly = true;
            // 
            // Yet
            // 
            this.Yet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Yet.HeaderText = "Yetkili";
            this.Yet.Name = "Yet";
            this.Yet.ReadOnly = true;
            this.Yet.Width = 60;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Telefon";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // btnBul
            // 
            this.btnBul.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBul.Location = new System.Drawing.Point(0, 398);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(203, 48);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
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
            // txtFirmaBul
            // 
            this.txtFirmaBul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirmaBul.Location = new System.Drawing.Point(3, 140);
            this.txtFirmaBul.Name = "txtFirmaBul";
            this.txtFirmaBul.Size = new System.Drawing.Size(190, 20);
            this.txtFirmaBul.TabIndex = 3;
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
            // txtYetkiliBul
            // 
            this.txtYetkiliBul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYetkiliBul.Location = new System.Drawing.Point(3, 166);
            this.txtYetkiliBul.Name = "txtYetkiliBul";
            this.txtYetkiliBul.Size = new System.Drawing.Size(190, 20);
            this.txtYetkiliBul.TabIndex = 3;
            // 
            // frmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCompanyList";
            this.Text = "frmCompanyList";
            this.Load += new System.EventHandler(this.frmCompanyList_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirmaBul;
        private System.Windows.Forms.TextBox txtYetkiliBul;
    }
}