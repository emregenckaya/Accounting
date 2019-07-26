using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Modal;

namespace Accounting.AlSat
{
    public partial class frmSatisListeGecici : Form
    {

        AccountingDBDataContext _db = new AccountingDBDataContext();
        public bool Secim = false;
        public int alId = -1;

        public frmSatisListeGecici()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSatisListeGecici_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste2.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblSalesUps select s);

            foreach (var k in lst)
            {
                tblSalesUp slu = _db.tblSalesUps.First(x => x.SalesID == k.SalesID);

                if (_db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblCompany.Name.Contains(txtFirmaBul.Text))
                {
                    Liste2.Rows.Add();
                    Liste2.Rows[i].Cells[0].Value = k.SalesID;
                    Liste2.Rows[i].Cells[1].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblCompany.Name;
                    Liste2.Rows[i].Cells[2].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).Date;
                    Liste2.Rows[i].Cells[3].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblEmployee.Name;
                    Liste2.Rows[i].Cells[4].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblShipper.Name;
                    
                    i++;
                }
            }
            Liste2.AllowUserToAddRows = false;
            Liste2.ReadOnly = true;
        }

        void Sec()
        {
            try
            {
                alId = int.Parse(Liste2.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                alId = -1;
            }
        }

        private void Liste2_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            bool a = Secim;
            if (Secim && alId > 0)
            {
                frmAnaSayfa.Aktarma = alId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblSalesUps select s);

            foreach (var k in lst)
            {
                tblSalesUp slu = _db.tblSalesUps.First(x => x.SalesID == k.SalesID);

                if ((slu.tblCompany.Name.ToUpper()).Contains(txtFirmaBul.Text.ToUpper()))
                {
                    Liste2.Rows.Add();
                    Liste2.Rows[i].Cells[0].Value = k.SalesID;
                    Liste2.Rows[i].Cells[1].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblCompany.Name;
                    Liste2.Rows[i].Cells[2].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).Date;
                    Liste2.Rows[i].Cells[3].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblEmployee.Name;
                    Liste2.Rows[i].Cells[4].Value = _db.tblSalesUps.First(x => x.SalesID == k.SalesID).tblShipper.Name;
                    i++;
                }
            }
            Liste2.AllowUserToAddRows = false;
            Liste2.ReadOnly = true;
        }
    }
}
