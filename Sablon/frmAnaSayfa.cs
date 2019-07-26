using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting
{
    public partial class frmAnaSayfa : Form
    {
        Modal.AccountingDBDataContext _db = new Modal.AccountingDBDataContext();
        Modal.Formlar _f = new Modal.Formlar();

        public static int Aktarma;

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;
            grpLeft.Text = "Bölüm-1 Giriş İşlemleri";
            pnlLeft1.Visible = true;
        }

        private void btnBolum1_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = true;
            pnlLeft2.Visible = false;
            pnlLeft3.Visible = false;
            grpLeft.Text = "Bölüm-1 Giriş İşlemleri";
            grpLeft.BackColor = Color.Teal;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnBolum2_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = true;
            pnlLeft3.Visible = false;
            grpLeft.Text = "Bilgi Giriş İşlemleri";
            grpLeft.BackColor = Color.Olive;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnBolum3_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = false;
            pnlLeft3.Visible = true;
            grpLeft.Text = "Bölüm-3 Giriş İşlemleri";
            grpLeft.BackColor = Color.Maroon;
            grpLeft.ForeColor = Color.White;
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            _f.Category();
        }

        private void btnKargo_Click(object sender, EventArgs e)
        {
            _f.Shippers();
        }

        private void btnKulGiris_Click(object sender, EventArgs e)
        {
            _f.KulGiris();
        }

        private void btnFirmaGiris_Click(object sender, EventArgs e)
        {
            _f.FirmaGiris();
        }

        private void btnFirmaListe_Click(object sender, EventArgs e)
        {
            _f.FirmaList();
        }

        private void btnUrunGiris_Click(object sender, EventArgs e)
        {
            _f.UrunGiris();
        }

        private void btnUrunListe_Click(object sender, EventArgs e)
        {
            _f.UrunList();
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            _f.Alis();
        }

        private void btnAlisListe_Click(object sender, EventArgs e)
        {
            _f.AlisList();
        }
        
        private void btnSatisListe_Click(object sender, EventArgs e)
        {
            _f.SatisList();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            _f.Satis();
        }
    }
}
