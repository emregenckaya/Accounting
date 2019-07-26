namespace Accounting.Bilgi
{
    partial class frmProductList
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
            this.Liste = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunBul = new System.Windows.Forms.TextBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Uadi,
            this.Kat});
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
            // Uadi
            // 
            this.Uadi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Uadi.HeaderText = "Ürün Adı";
            this.Uadi.Name = "Uadi";
            this.Uadi.ReadOnly = true;
            // 
            // Kat
            // 
            this.Kat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Kat.HeaderText = "Kategori Adı";
            this.Kat.Name = "Kat";
            this.Kat.ReadOnly = true;
            this.Kat.Width = 89;
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
            this.splitContainer1.Panel2.Controls.Add(this.txtUrunBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnBul);
            this.splitContainer1.Panel2.Controls.Add(this.btnKapat);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUrunBul
            // 
            this.txtUrunBul.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrunBul.Location = new System.Drawing.Point(3, 140);
            this.txtUrunBul.Name = "txtUrunBul";
            this.txtUrunBul.Size = new System.Drawing.Size(190, 20);
            this.txtUrunBul.TabIndex = 3;
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
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProductList";
            this.Text = "frmProductList";
            this.Load += new System.EventHandler(this.frmProductList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunBul;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kat;
    }
}