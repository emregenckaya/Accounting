using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Model;

namespace Accounting.Bilgi
{
    public partial class frmShipper : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Mesajlar _m = new Mesajlar();
        //Model.Formlar _f = new Model.Formlar();

        bool _edit = false;
        int _secimID = -1;

        public frmShipper()
        {
            InitializeComponent();
        }
        
        void Temizle()
        {
            txtCargoName.Text = "";
            txtPhone.Text = "";
            _edit = false;
            _secimID = -1;
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = _db.tblShippers.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.Name;
                Liste.Rows[i].Cells[2].Value = k.Phone;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                tblShipper ship = new tblShipper();
                ship.Name = txtCargoName.Text;
                ship.Phone = txtPhone.Text;
                _db.tblShippers.InsertOnSubmit(ship);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt tamamlandı.");
                Temizle();
                //this.Close();
                //_f.Shippers();        //bunun amacı form sayfasını kapatıp tekrar çalıştırılması fakat form yeniden açmak için kendini kapatamıyor. Keypress.back devam
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                _edit = true;
                _secimID = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtCargoName.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                txtPhone.Text = Liste.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _secimID = -1;
            }
        }
        

        void Guncelle()
        {
            tblShipper ship = _db.tblShippers.First(x => x.ID == _secimID);
            ship.Name = txtCargoName.Text;
            ship.Phone = txtPhone.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }

        

        void Sil()
        {
            try
            {
                _db.tblShippers.DeleteOnSubmit(_db.tblShippers.First(s => s.ID == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString())));
                _db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _secimID > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (_secimID < 0) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_edit && _secimID > 0 && _m.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Liste_Click_1(object sender, EventArgs e)
        {
            Sec();
        }

        private void txtCargoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                Temizle();
            }
        }

        private void frmShippers_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
