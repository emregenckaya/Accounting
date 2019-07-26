using Accounting.Modal;
using Accounting.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Accounting.Bilgi
{
    public partial class frmProduct : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Mesajlar _m = new Mesajlar();
        Formlar _f = new Formlar();
        Numaralar _n = new Numaralar();

        bool edit = false;
        int _urunId = -1;
        int _katId = -1;
        public frmProduct()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox) ct.Text = "";
            }
            txtUsiraNo.Text = _n.UrunSiraNo();
            edit = false;
            
        }
        //void Combo()
        //{
        //    cbSehir.DataSource = _db.tblCities;
        //    cbSehir.ValueMember = "ID";
        //    cbSehir.DisplayMember = "City";
        //    cbSehir.SelectedIndex = 33;
        //}
        void YeniKaydet()
        {
            
            try
            {
                tblProduct pro = new tblProduct();

                pro.CategoryID = _db.tblCategories.First(x => x.CategoryName == txtKategori.Text).ID;
                pro.ProNo = int.Parse(txtUsiraNo.Text);
                pro.Name = txtUadi.Text;
                pro.Note = txtNot.Text;
                pro.UnitPrice = decimal.Parse(txtBirimFiyat.Text);
                _db.tblProducts.InsertOnSubmit(pro);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla gerçekleşti.");
                Temizle();

            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        void Guncelle()
        {
            AccountingDBDataContext _gb = new AccountingDBDataContext();
            try
            {
                tblProduct pro = _gb.tblProducts.First(x => x.ID == _urunId);
                pro.CategoryID = _gb.tblCategories.First(x => x.CategoryName == txtKategori.Text).ID;;
                pro.Name = txtUadi.Text;
                pro.Note = txtNot.Text;
                pro.UnitPrice = decimal.Parse(txtBirimFiyat.Text);
                _gb.SubmitChanges();
                _m.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        void Sil()
        {
            _db.tblProducts.DeleteOnSubmit(_db.tblProducts.First(x => x.ID == _urunId));
            _db.SubmitChanges();
            Temizle();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnpro = new Button();
            btnpro.Size = new Size(25, txtUsiraNo.ClientSize.Height + 2);
            btnpro.Location = new Point(txtUsiraNo.ClientSize.Width - btnpro.Width, -1);
            btnpro.Cursor = Cursors.Default;
            btnpro.Image= Resources.arrow1;
            txtUsiraNo.Controls.Add(btnpro);
            SendMessage(txtUsiraNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnpro.Width << 16));
            btnpro.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btncat = new Button();
            btncat.Size = new Size(25, txtKategori.ClientSize.Height + 2);
            btncat.Location = new Point(txtKategori.ClientSize.Width - btncat.Width, -1);
            btncat.Cursor = Cursors.Default;
            btncat.Image=Resources.arrow1;
            txtKategori.Controls.Add(btncat);
            SendMessage(txtKategori.Handle, 0xd3, (IntPtr)2, (IntPtr)(btncat.Width << 16));
            btncat.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnpro.Click += btnpro_Click;
            btncat.Click += btncat_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnpro_Click(object sender, EventArgs e)
        {
            int id = _f.UrunList(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }
        private void btncat_Click(object sender, EventArgs e)
        {
            int id = _f.Category(true);
            if (id > 0)
            {
                KatAc(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }
        void KatAc(int id)
        {
            try
            {
                _katId = id;
                txtKategori.Text = _db.tblCategories.First(s => s.ID == _katId).CategoryName;
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        void Ac(int id)
        {
            try
            {
                edit = true;
                _urunId = id;
                tblProduct pro = _db.tblProducts.First(s => s.ID == _urunId);
                
                txtUsiraNo.Text = pro.ProNo.ToString().PadLeft(7, '0');
                txtUadi.Text = pro.Name;
                txtKategori.Text = pro.tblCategory.CategoryName;
                txtNot.Text = pro.Note;
                txtBirimFiyat.Text = pro.UnitPrice.ToString();                
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && _urunId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && _urunId > 0 && _m.Sil() == DialogResult.Yes) Sil();
        }
    }
}
