using Accounting.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Bilgi
{
    public partial class frmShippers : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Mesajlar _m = new Mesajlar();

        bool _edit = false;
        int _secimId = -1;
        public frmShippers()
        {
            InitializeComponent();
        }

        private void frmShippers_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            txtKname.Text = "";
            txtKphone.Text = "";
            _edit = false;
            _secimId = -1;
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
                ship.Name = txtKname.Text;
                ship.Phone = txtKphone.Text;

                _db.tblShippers.InsertOnSubmit(ship);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt tamamlandı.");
                Temizle();
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
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtKname.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                txtKphone.Text = Liste.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _secimId = -1;
            }
        }
        void Guncelle()
        {
            tblShipper ship = _db.tblShippers.First(x => x.ID == _secimId);
            ship.Name = txtKname.Text;
            ship.Phone = txtKphone.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }
        void Sil()
        {
            try
            {
                _db.tblShippers.DeleteOnSubmit(_db.tblShippers.First(s => s.ID == _secimId));
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
            if (_edit && _secimId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (_secimId < 0) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_edit && _secimId > 0 && _m.Sil() == DialogResult.Yes) Sil();
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void txtKname_TextChanged(object sender, EventArgs e)
        {
            if (txtKname.Text == "")
            {
                Temizle();
            }
        }
    }
}
