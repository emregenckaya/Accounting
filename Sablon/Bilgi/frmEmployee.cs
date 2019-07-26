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
    public partial class frmEmployee : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Mesajlar _m = new Mesajlar();

        public bool Secim = false;
        bool _edit = false;
        int _secimId = -1;
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            txtUname.Text = "";
            txtUphone.Text = "";
            dtpUhiredate.Text = DateTime.Now.ToShortDateString();
            txtUtitle.Text = "";
            _edit = false;
            _secimId = -1;
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = _db.tblEmployees.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.Title;
                Liste.Rows[i].Cells[2].Value = k.Name;
                Liste.Rows[i].Cells[3].Value = k.HireDate;
                Liste.Rows[i].Cells[4].Value = k.Phone;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        void YeniKaydet()
        {
            try
            {
                tblEmployee emp = new tblEmployee();
                emp.Name = txtUname.Text;
                emp.Phone = txtUphone.Text;
                emp.HireDate = DateTime.Parse(dtpUhiredate.Text);
                emp.Title = txtUtitle.Text;

                _db.tblEmployees.InsertOnSubmit(emp);
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
                txtUtitle.Text= Liste.CurrentRow.Cells[1].Value.ToString();
                txtUname.Text = Liste.CurrentRow.Cells[2].Value.ToString();
                dtpUhiredate.Text = Liste.CurrentRow.Cells[3].Value.ToString();
                txtUphone.Text = Liste.CurrentRow.Cells[4].Value.ToString();                
            }
            catch (Exception)
            {
                _edit = false;
                _secimId = -1;
            }
        }
        void Guncelle()
        {
            tblEmployee emp = _db.tblEmployees.First(x => x.ID == _secimId);
            emp.Name = txtUname.Text;
            emp.Phone = txtUphone.Text;
            emp.Title = txtUtitle.Text;
            emp.HireDate = DateTime.Parse(dtpUhiredate.Text);
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }
        void Sil()
        {
            try
            {
                _db.tblEmployees.DeleteOnSubmit(_db.tblEmployees.First(s => s.ID == _secimId));
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

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            if (txtUname.Text == "")
            {
                Temizle();
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && _secimId>0)
            {
                frmAnaSayfa.Aktarma = _secimId;
                Close();
            }
        }
    }
}
