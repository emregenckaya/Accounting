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
using Accounting.Properties;

namespace Accounting.AlSat
{
    public partial class frmAlis : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();
        Numaralar _n = new Numaralar();

        bool edit = false;
        int _aid = -1;
        int _firmaId = -1;
        int _perId = -1;
        public string[] MyArray { get; set; }
        public frmAlis()
        {
            InitializeComponent();
        }

        private void frmAlis_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();
        }
        void Combo()
        {
            urncmb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = _db.tblProducts.Select(s => s.Name).Distinct();
            foreach (string urn in lst)
            {
                veri.Add(urn);
                urncmb.Items.Add(urn);
            }
            urncmb.AutoCompleteCustomSource = veri;

            int dgv;
            dgv = urncmb.Items.Count;
            MyArray = new string[dgv];
            for (int p = 0; p < dgv; p++)
            {
                MyArray[p] = urncmb.Items[p].ToString();
            }
        }
        void Temizle()
        {
            txtAlisNo.Text = _n.AlisNo();
            Liste.Rows.Clear();
            txtFirma.Text = "";
            txtPersonel.Text = "";
            dtpTarih.Text = DateTime.Now.ToShortDateString();
        }
        void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            try
            {
                tblPurchasing[] pur = new tblPurchasing[Liste.RowCount];
                tblStock[] stk = new tblStock[Liste.RowCount];
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    int pid = int.Parse(Liste.Rows[i].Cells[0].Value.ToString());
                    string lot = Liste.Rows[i].Cells[2].Value.ToString();

                    pur[i] = new tblPurchasing();
                    pur[i].PurNo = int.Parse(txtAlisNo.Text);
                    pur[i].CompanyID = _db.tblCompanies.First(x => x.Name == txtFirma.Text).ID;
                    pur[i].ProductID = pid;
                    pur[i].LotSerial = lot;
                    pur[i].Date = DateTime.Parse(dtpTarih.Text);
                    pur[i].PurchasingPrice = decimal.Parse(Liste.Rows[i].Cells[3].Value.ToString());
                    pur[i].Quantity = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    pur[i].EmployeeID = _db.tblEmployees.First(x => x.Name == txtPersonel.Text).ID;

                    _db.tblPurchasings.InsertOnSubmit(pur[i]);

                    AccountingDBDataContext _gb = new AccountingDBDataContext();
                    stk[i] = new tblStock();
                    var srg = (from s in _gb.tblStocks
                               where s.ProductID == pid && s.LotSerial == lot
                               select s
                             ).ToList();
                    if (srg.Count == 0)
                    {
                        stk[i].ProductID = pid;
                        stk[i].LotSerial = lot;
                        stk[i].Quantity = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());

                        _gb.tblStocks.InsertOnSubmit(stk[i]);
                    }
                    else
                    {
                        tblStock st = _gb.tblStocks.First(x => x.ProductID == pid && x.LotSerial == lot);
                        st.Quantity += int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                    }
                    _gb.SubmitChanges();
                }
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarılı.");
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }  
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnano = new Button();
            btnano.Size = new Size(25, txtAlisNo.ClientSize.Height + 2);
            btnano.Location = new Point(txtAlisNo.ClientSize.Width - btnano.Width, -1);
            btnano.Cursor = Cursors.Default;
            btnano.Image = Resources.arrow1;
            txtAlisNo.Controls.Add(btnano);
            SendMessage(txtAlisNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnano.Width << 16));
            btnano.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnfir = new Button();
            btnfir.Size = new Size(25, txtFirma.ClientSize.Height + 2);
            btnfir.Location = new Point(txtFirma.ClientSize.Width - btnfir.Width, -1);
            btnfir.Cursor = Cursors.Default;
            btnfir.Image = Resources.arrow1;
            txtFirma.Controls.Add(btnfir);
            SendMessage(txtFirma.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnfir.Width << 16));
            btnfir.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnper = new Button();
            btnper.Size = new Size(25, txtPersonel.ClientSize.Height + 2);
            btnper.Location = new Point(txtPersonel.ClientSize.Width - btnper.Width, -1);
            btnper.Cursor = Cursors.Default;
            btnper.Image = Resources.arrow1;
            txtPersonel.Controls.Add(btnper);
            SendMessage(txtPersonel.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnper.Width << 16));
            btnper.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnano.Click += btnano_Click;
            btnfir.Click += btnfir_Click;
            btnper.Click += btnper_Click;
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnano_Click(object sender, EventArgs e)
        {
            int id = _f.AlisList(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }

        private void btnfir_Click(object sender, EventArgs e)
        {
            int id = _f.FirmaList(true);
            if (id > 0)
            {
                FirmaAc(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            int id = _f.KulGiris(true);
            if (id > 0)
            {
                PerAc(id);
            }
            frmAnaSayfa.Aktarma = -1;
        }
        public void Ac(int id)
        {
            try
            {
                Liste.Rows.Clear();
                _aid = id;
                tblPurchasing pur = _db.tblPurchasings.First(x => x.PurNo == _aid);
                txtAlisNo.Text = pur.PurNo.ToString().PadLeft(7, '0');
                txtFirma.Text = pur.tblCompany.Name;
                txtPersonel.Text = pur.tblEmployee.Name;
                int i = 0;
                var srg = from s in _db.tblPurchasings
                          where s.PurNo == _aid
                          select s;
                foreach (tblPurchasing k in srg)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = k.ProductID;
                    Liste.Rows[i].Cells[1].Value = k.tblProduct.Name;
                    Liste.Rows[i].Cells[2].Value = k.LotSerial;
                    Liste.Rows[i].Cells[3].Value = k.PurchasingPrice;
                    Liste.Rows[i].Cells[4].Value = k.Quantity;
                    i++;
                }
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
            
        }

        void Sil()
        {
            Liste.AllowUserToAddRows = false;
            try
            {
                for (int i = 0; i < Liste.RowCount; i++)
                {
                    int pid = int.Parse(Liste.Rows[i].Cells[0].Value.ToString());
                    string lot = Liste.Rows[i].Cells[2].Value.ToString();
                    
                    tblStock st = _db.tblStocks.First(x => x.ProductID == pid && x.LotSerial == lot);
                    st.Quantity -= int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                }
                ////_db.tblPurchasings.First(x => x.PurNo == int.Parse(txtAlisNo.Text))
                ////tblPurchasing purc = new tblPurchasing();
                ////_db.tblPurchasings.DeleteAllOnSubmit(purc.PurNo == int.Parse(txtAlisNo.Text));
                //_db.tblPurchasings.DeleteOnSubmit(_db.tblPurchasings.First(x => x.PurNo == int.Parse(txtAlisNo.Text)));
                //_db.SubmitChanges();
                var srg = (from s in _db.tblPurchasings
                           where s.PurNo == int.Parse(txtAlisNo.Text)
                           select s).ToList();
                _db.tblPurchasings.DeleteAllOnSubmit(srg);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla silindi.");
                Temizle();

            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
            
        }

        public void FirmaAc(int id)
        {
            _firmaId = id;
            txtFirma.Text = _db.tblCompanies.First(x => x.ID == _firmaId).Name;
        }
        public void PerAc(int id)
        {
            _perId = id;
            txtPersonel.Text = _db.tblEmployees.First(x => x.ID == _perId).Name;
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Yaz();
        }

        void Yaz()
        {
            PrintIslemleri.frmPrint pri = new PrintIslemleri.frmPrint();
            pri.HangiListe = "Alis";
            pri.Show();

        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed == true)
            {
                splitContainer1.Panel2Collapsed = false;
                btnCollapse.Text = "GİZLE";
            }
            else if (splitContainer1.Panel2Collapsed == false)
            {
                splitContainer1.Panel2Collapsed = true;
                btnCollapse.Text = "GÖSTER";
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox txt = e.Control as TextBox;
            if (Liste.CurrentCell.ColumnIndex == 1 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource.AddRange(MyArray);
            }
            else if (Liste.CurrentCell.ColumnIndex != 1 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }
        }

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Liste.CurrentRow.Cells[0].Value = _db.tblProducts.First(x => x.Name == Liste.CurrentRow.Cells[1].Value.ToString()).ID;
            }
            if (e.ColumnIndex == 2)
            {
                Liste.CurrentRow.Cells[5].Value = Liste.CurrentRow.Cells[1].Value + "/" + Liste.CurrentRow.Cells[2].Value;
                string a = Liste.CurrentRow.Cells[5].Value.ToString();
                //int i = 0;
                //foreach (var k in Liste.RowCount.ToString())
                //{
                //    if (Liste.Rows[i].Cells[5].Value.ToString() == a && i > 0)
                //    {
                //        MessageBox.Show("Bu kayıt var, kontrol edin.");
                //    }
                //    i++;
                //}
                for(int i = 0; i < Liste.RowCount - 1; i++)
                {
                    int b = Liste.RowCount-2;
                    if (Liste.Rows[i].Cells[5].Value.ToString() == a && i!=b)
                    {
                        MessageBox.Show("Bu kayıt var, kontrol edin.");
                        Liste.Rows[b].Cells[2].Value = "";
                        break;
                    }
                }
            }
        }
    }
}
