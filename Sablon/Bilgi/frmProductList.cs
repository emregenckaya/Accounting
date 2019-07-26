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
    public partial class frmProductList : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        public bool Secim = false;
        int _secimId = -1;
        public frmProductList()
        {
            InitializeComponent();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblProducts
                       where s.Name.Contains(txtUrunBul.Text)
                       select s).OrderBy(x => x.Name).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.Name;
                Liste.Rows[i].Cells[2].Value = k.tblCategory.CategoryName;
                
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                frmAnaSayfa.Aktarma = _secimId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
