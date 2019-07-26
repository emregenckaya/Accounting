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
using Accounting.Modal;

namespace Accounting.Bilgi
{
    public partial class frmCompany : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Mesajlar _m = new Mesajlar();
        Formlar _f = new Formlar();
        Numaralar _n = new Numaralar();

        bool edit = false;
        int _firmaId = -1;

        public frmCompany()
        {
            InitializeComponent();
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();
            //txtFirmaNo.Text = _n.FirmaNo();
        }

        void Temizle()
        {
            foreach (Control ct in splitContainer1.Panel1.Controls)
            {
                if (ct is TextBox || ct is ComboBox) ct.Text = "";
            }
            txtFirmaNo.Text = _n.FirmaNo();
            edit = false;
            cbFirmaTur.SelectedIndex = -1;
        }
        void Combo()
        {
            cbSehir.DataSource = _db.tblCities;
            cbSehir.ValueMember = "ID";
            cbSehir.DisplayMember = "City";
            cbSehir.SelectedIndex = 33;            
        }
        void YeniKaydet()
        {
            try
            {
                tblCompany com = new tblCompany();
                com.Address = txtAdres.Text;
                com.Authorized = txtYetkili.Text;
                com.CityID = _db.tblCities.First(x => x.City == cbSehir.Text).ID;
                com.CompNo = int.Parse(txtFirmaNo.Text);
                com.CusSup = cbFirmaTur.Text;
                com.Email = txtemail.Text;
                com.Fax = txtFaks.Text;
                com.Mobile = txtGsm.Text;
                com.Name = txtFadi.Text;
                com.Phone = txtTel.Text;
                com.TaxNo = txtVn.Text;
                com.TaxOffice = txtVd.Text;

                _db.tblCompanies.InsertOnSubmit(com);
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
            try
            {
                tblCompany com = _db.tblCompanies.First(x => x.ID == _firmaId);
                com.Address = txtAdres.Text;
                com.Authorized = txtYetkili.Text;
                com.CityID = _db.tblCities.First(x => x.City == cbSehir.Text).ID;                
                com.CusSup = cbFirmaTur.Text;
                com.Email = txtemail.Text;
                com.Fax = txtFaks.Text;
                com.Mobile = txtGsm.Text;
                com.Name = txtFadi.Text;
                com.Phone = txtTel.Text;
                com.TaxNo = txtVn.Text;
                com.TaxOffice = txtVd.Text;
                _db.SubmitChanges();
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
            _db.tblCompanies.DeleteOnSubmit(_db.tblCompanies.First(x => x.ID == _firmaId));
            _db.SubmitChanges();
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && _firmaId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnfno = new Button();
            btnfno.Size = new Size(25, txtFirmaNo.ClientSize.Height + 2);
            btnfno.Location = new Point(txtFirmaNo.ClientSize.Width - btnfno.Width, -1);
            btnfno.Cursor = Cursors.Default;
            //btnfno.Image=Resources.arrow_1176;
            txtFirmaNo.Controls.Add(btnfno);
            SendMessage(txtFirmaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnfno.Width << 16));
            btnfno.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);

            btnfno.Click += btnfno_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        
        private void btnfno_Click(object sender,EventArgs e)
        {
            int id = _f.FirmaList(true);
            if(id>0)
            {
                Ac(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }
        void Ac(int id)
        {
            try
            {
                edit = true;
                _firmaId = id;
                tblCompany com = _db.tblCompanies.First(s => s.ID == _firmaId);
                txtAdres.Text = com.Address;
                txtBolge.Text = com.tblCity.Territory;
                txtemail.Text = com.Email;
                txtFadi.Text = com.Name;
                txtFaks.Text = com.Fax;
                txtFirmaNo.Text = com.CompNo.ToString().PadLeft(7,'0');
                txtGsm.Text = com.Mobile;
                txtTel.Text = com.Phone;
                txtVd.Text = com.TaxOffice;
                txtVn.Text = com.TaxNo;
                txtYetkili.Text = com.Authorized;
                cbFirmaTur.Text = com.CusSup;
                cbSehir.Text = com.tblCity.City;
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

        private void cbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSehir.ValueMember != "")
            {                
                txtBolge.Text = _db.tblCities.First(x => x.City == cbSehir.Text).Territory;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && _firmaId > 0 && _m.Sil() == DialogResult.Yes) Sil();
        }
    }
}
