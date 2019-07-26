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
    public partial class frmSatis : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();
        Numaralar _n = new Numaralar();


        int _aid = -1;
        int _firmaId = -1;
        int _perId = -1;
        bool kont = false;
        bool combclr = false;
        private DataGridViewComboBoxCell comboCell;

        public frmSatis()
        {
            InitializeComponent();
        }
        private void frmSatis_Load(object sender, EventArgs e)
        {
            Liste.AllowUserToAddRows = false;
            Combo();
            Temizle();
        }

        void Temizle()
        {
            txtSatisNo.Text = _n.SatisNo();
            Liste.Rows.Clear();
            Liste.Rows.Add();
            txtFirma.Text = "";
            txtPersonel.Text = "";
            dtpTarih.Text = DateTime.Now.ToShortDateString();
            cbKargo.SelectedIndex = -1;
            cbSehir.SelectedIndex = 33;
            kont = false;
        }

        void Combo()
        {
            var lst = _db.tblCities.Select(s => s.City).ToList();
            cbSehir.DataSource = _db.tblCities;
            cbSehir.ValueMember = "ID";
            cbSehir.DisplayMember = "City";
            cbSehir.SelectedIndex = 33;

            var lst2 = _db.tblShippers.Select(s => s.Name).ToList();
            foreach (var k in lst2)
            {
                cbKargo.Items.Add(k);
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
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


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();

        }
        private void YeniKaydet()
        {
            Liste.AllowUserToAddRows = false;
            bool kon = true;

            try
            {

                tblSalesDown[] saled = new tblSalesDown[Liste.RowCount];
                tblSalesUp saleu = new tblSalesUp();
                tblStock[] stk = new tblStock[Liste.RowCount];
                AccountingDBDataContext _gb = new AccountingDBDataContext();
                AccountingDBDataContext _eb = new AccountingDBDataContext();
                for (int i = 0; i < Liste.RowCount - 1; i++)
                {
                    for (int a = 0; a < Liste.ColumnCount - 1; a++)
                    {
                        var d = Liste.Rows[i].Cells[a].Value;
                        if (d == null)
                        {
                            MessageBox.Show("Alan boş bırakılamaz" + (i + 1) + ".satır " + a + ". sütunu kontrol edin");
                            kon = false;
                            break;
                        }
                    }
                }  //HÜCRE BOŞ BIRAKILAMAZ

                if (kon && txtFirma.Text != "" && txtPersonel.Text != "" && cbKargo.Text != "") //BOŞ ALAN BIRAKILMIŞSA KAYIT YAPILMASINI ÖNLEMEK İÇİN KULLANILAN İF
                {
                    #region SALESUP TABLOSUNA YAPILACAK KAYIT 
                    saleu.SalesID = int.Parse(txtSatisNo.Text);
                    saleu.EmployeeID = _eb.tblEmployees.First(x => x.Name == txtPersonel.Text).ID;
                    saleu.CompanyID = _eb.tblCompanies.First(x => x.Name == txtFirma.Text).ID;
                    saleu.Date = DateTime.Parse(dtpTarih.Text);
                    saleu.CityID = cbSehir.SelectedIndex + 1;
                    saleu.ShipperID = _eb.tblShippers.First(x => x.Name == cbKargo.Text).ID;


                    _eb.tblSalesUps.InsertOnSubmit(saleu);
                    #endregion

                    for (int i = 0; i < Liste.RowCount; i++)//SALES DOWNA YAPILACAK OLAN KAYIT VE STOCK TABLOSUNDAKİ DEĞİŞTİRİLECEK QUANTİTY
                    {
                        if (Liste.Rows[i].Cells[1].Value != null)
                        {
                            int pid = int.Parse(Liste.Rows[i].Cells[0].Value.ToString());

                            string[] lotseri = Liste.Rows[i].Cells[2].Value.ToString().Split('-');

                            Array.Resize(ref lotseri, lotseri.Length - 1);
                            string lot = string.Join("-", lotseri);

                            saled[i] = new tblSalesDown();
                            saled[i].SalesID = int.Parse(txtSatisNo.Text);
                            saled[i].ProductID = pid;
                            saled[i].LotSerial = lot;
                            saled[i].SalesPrice = decimal.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                            saled[i].Quantity = int.Parse(Liste.Rows[i].Cells[3].Value.ToString());


                            #region SATIŞ YAPILAN ÜRÜNÜN STOCK TABLSOUNDAKİ ADET SAYISININ AZALTILMASI
                            stk[i] = new tblStock();
                            var srg = (from s in _gb.tblStocks
                                       where s.ProductID == pid && s.LotSerial == lot
                                       select s
                                     ).ToList();
                            if (srg.Count > 0 && _db.tblStocks.First(x => x.ProductID == pid && x.LotSerial == lot).Quantity >= int.Parse(Liste.Rows[i].Cells[3].Value.ToString()))
                            {
                                tblStock st = _gb.tblStocks.First(x => x.ProductID == pid && x.LotSerial == lot);
                                st.Quantity -= int.Parse(Liste.Rows[i].Cells[3].Value.ToString());


                                _db.tblSalesDowns.InsertOnSubmit(saled[i]);
                                //_gb.tblStocks.InsertOnSubmit(stk[i]); //bu çalışırsa tblstock içine yeni bi null dolu kayıt ekliyor.

                                kont = true;
                            }
                            else
                            {
                                MessageBox.Show(Liste.Rows[i].Cells[5].Value.ToString() + "ürün stokta yeteri kadar yoktur.", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                            #endregion

                        }
                    }


                    if (kont) //SATIŞ YAPIALCAK ÜRÜNÜN SAYISI ELİMİZDEKİ ÜRÜNDEN FAZLAYSA DEĞİŞİKLERİ GERÇEKLEŞTİR
                    {
                        _gb.SubmitChanges();
                        _eb.SubmitChanges();
                        _db.SubmitChanges();
                        _m.YeniKayit("Satış başarılı.");
                        Temizle();
                        _f.Satis();
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Eksik bilgi girdiniz. Lütfen tüm bilgileri giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            catch (Exception e)
            {
                _m.Hata(e);
            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();
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
                    st.Quantity += int.Parse(Liste.Rows[i].Cells[3].Value.ToString());
                }

                var dup = (from s in _db.tblSalesDowns
                           where s.SalesID == int.Parse(txtSatisNo.Text)
                           select s).ToList();
                _db.tblSalesDowns.DeleteAllOnSubmit(dup);

                var up = _db.tblSalesUps.First(x => x.SalesID == int.Parse(txtSatisNo.Text));
                _db.tblSalesUps.DeleteOnSubmit(up);

                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla silindi.");
                Temizle();


            }
            catch (Exception e)
            {
                _m.Hata(e);
            }

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            Yaz();
        }
        void Yaz()
        {
            PrintIslemleri.frmPrint pri = new PrintIslemleri.frmPrint();
            pri.HangiListe = "Satis";
            pri.WindowState = FormWindowState.Maximized;
            pri.Show();

        }


        protected override void OnLoad(EventArgs e)
        {
            var btnano = new Button();
            btnano.Size = new Size(25, txtSatisNo.ClientSize.Height + 2);
            btnano.Location = new Point(txtSatisNo.ClientSize.Width - btnano.Width, -1);
            btnano.Cursor = Cursors.Default;
            btnano.Image = Resources.arrow1;
            txtSatisNo.Controls.Add(btnano);
            SendMessage(txtSatisNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnano.Width << 16));
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

            int id = _f.SatisList2(true);
            if (id > 0)
            {
                Ac(id);
            }
            frmAnaSayfa.Aktarma = -1;

            if (frmAnaSayfa.Aktarma != -1)
            {
                Liste.ReadOnly = true;
            }

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
                tblSalesUp sup = _db.tblSalesUps.First(x => x.SalesID == _aid);
                txtSatisNo.Text = sup.SalesID.ToString().PadLeft(7, '0');
                txtFirma.Text = sup.tblCompany.Name;
                txtPersonel.Text = sup.tblEmployee.Name;
                cbSehir.Text = sup.tblCity.City;
                cbKargo.Text = sup.tblShipper.Name;
                dtpTarih.Text = sup.Date.ToString();

                int i = 0;

                var srg = from s in _db.tblSalesDowns
                          where s.SalesID == _aid
                          select s;

                foreach (var k in srg)
                {
                    Liste.Rows.Add();
                    DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)Liste.Rows[i].Cells[2];
                    Liste.Rows[i].Cells[0].Value = k.ProductID;
                    Liste.Rows[i].Cells[1].Value = k.tblProduct.Name;
                    LotSeri.Items.Add(k.LotSerial);
                    comboCell.Value = k.LotSerial;
                    Liste.Rows[i].Cells[3].Value = k.Quantity;
                    Liste.Rows[i].Cells[4].Value = k.SalesPrice;
                    i++;
                }

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

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)Liste.CurrentRow.Cells[2];

                if (e.ColumnIndex == 1)
                {
                    Liste.CurrentRow.Cells[0].Value = _db.tblProducts.First(x => x.Name == Liste.CurrentRow.Cells[1].Value.ToString()).ID;

                    var lts = (from s in _db.tblStocks where s.ProductID == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString()) && s.Quantity > 0 select s).ToList();

                    //Liste.CurrentRow.Cells[1].ReadOnly = true;
                    int a = lts.Count;
                    comboCell.Items.Clear();
                    if (lts.Count > 0)
                    {

                        int d = 0;
                        foreach (var k in lts)
                        {
                            bool lt = true;
                            #region AYNI ÜRÜN İÇİN KULLANILAN LOT/SERİNOYU İKİNCİ DEFA GETİRMEMESİ İÇİN KONTROL
                            int c = lts.Count;
                            if (d != 0) c = d;
                            for (int i = 0; i < Liste.RowCount; i++)
                            {

                                if (Liste.Rows[i].Cells[2].Value != null && k.LotSerial + "-" + k.Quantity == Liste.Rows[i].Cells[2].Value.ToString())
                                {
                                    lt = false;
                                    c -= 1;
                                    d = c;
                                }
                            }
                            #endregion
                            if (lt)
                                comboCell.Items.Add(k.LotSerial + "-" + k.Quantity);
                            else if (c == 0)
                            {
                                comboCell.Items.Add("geçerli lot yok");
                                comboCell.Value = "geçerli lot yok";


                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ürün yok");
                        Liste.CurrentRow.Cells[1].ReadOnly = false;
                        comboCell.Items.Clear();

                    }


                }
                if (e.ColumnIndex == 2)
                {
                    Liste.CurrentRow.Cells[5].Value = (Liste.CurrentRow.Cells[1].Value + "/" + Liste.CurrentRow.Cells[2].Value).ToUpper();
                    string a = Liste.CurrentRow.Cells[5].Value.ToString();

                    for (int i = 0; i < Liste.RowCount - 1; i++)
                    {

                        int b = Liste.CurrentCell.RowIndex;
                        if (Liste.Rows[i].Cells[5].Value.ToString() == a && i != b)
                        {
                            MessageBox.Show("Bu kayıt var, kontrol edin.");
                            comboCell.Value = "";
                            Liste.Rows[b].Cells[5].Value = "";
                            break;
                        }
                    }
                }
                if (e.ColumnIndex == 3)
                {
                    try
                    {
                        tblStock lt = _db.tblStocks.First(x => x.ProductID == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString()) && (x.LotSerial + "-" + x.Quantity) == comboCell.Value.ToString());
                        if (Liste.CurrentRow.Cells[3].Value.ToString() != "" && lt.Quantity < int.Parse(Liste.CurrentRow.Cells[3].Value.ToString()))
                        {
                            Liste.CurrentRow.Cells[3].Value = "";
                            MessageBox.Show(Liste.CurrentRow.Cells[1].Value.ToString() + " " + lt.LotSerial + " lot numaralı ürün stokta yeteri kadar yoktur.", "Stok Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Adet alanına geçerli değer giriniz");
                        Liste.CurrentRow.Cells[3].Value = "";
                    }
                }

                if (e.ColumnIndex == 4)
                {
                    bool kon = true;
                    if (Liste.RowCount < Liste.CurrentCell.RowIndex + 2)
                    {
                        Liste.Rows.Add();
                        Liste.Rows[Liste.CurrentCell.RowIndex + 1].ReadOnly = false;
                    }
                    Liste.Rows[Liste.CurrentCell.RowIndex + 1].ReadOnly = false;
                    Liste.CurrentRow.ReadOnly = true;
                    for (int i = 0; i < Liste.ColumnCount; i++)
                    {
                        if (Liste.CurrentRow.Cells[i].Value != null)
                        {
                            if (Liste.CurrentRow.Cells[i].Value.ToString() == "")
                            {
                                kon = false;
                                MessageBox.Show(Liste.Columns[i].HeaderText + "Alanı Boş bırakılamaz");
                                Liste.CurrentCell.Value = "";
                                Liste.Rows[Liste.CurrentCell.RowIndex + 1].ReadOnly = true;
                                Liste.CurrentRow.ReadOnly = false;
                            }
                        }
                        if (kon && Liste.CurrentRow.Cells[i].Value == null/* && Liste.Rows[i].Cells[1].Value !=null*/)
                        {

                            MessageBox.Show(Liste.Columns[i].HeaderText + "Alanı Boş bırakılamaz");
                            Liste.CurrentCell.Value = "";
                            Liste.Rows[Liste.CurrentCell.RowIndex + 1].ReadOnly = true;
                            Liste.CurrentRow.ReadOnly = false;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _m.Hata(ex);
            }

        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            TextBox txt = e.Control as TextBox;

            AutoCompleteStringCollection veri = new AutoCompleteStringCollection();
            var lst = _db.tblProducts.Select(s => s.Name).Distinct().ToList();

            foreach (string urn in lst)
            {
                bool yaz = false;
                var sorgu = (from s in _db.tblStocks where s.ProductID == (_db.tblProducts.First(x => x.Name == urn).ID) select s).ToList();

                foreach (var s in sorgu)
                {
                    if (s.Quantity > 0)
                    {
                        yaz = true;
                    }
                }
                if (yaz)
                {
                    veri.Add(urn);
                }
            }

            if (Liste.CurrentCell.ColumnIndex == 1 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txt.AutoCompleteCustomSource = veri;
                if (Liste.RowCount < Liste.CurrentCell.RowIndex + 2)
                {
                    Liste.Rows.Add();
                    Liste.Rows[Liste.CurrentCell.RowIndex + 1].ReadOnly = true;
                }


            }
            else if (Liste.CurrentCell.ColumnIndex != 1 && txt != null)
            {
                txt.AutoCompleteMode = AutoCompleteMode.None;
            }

        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && Liste.CurrentRow.Cells[2].Value != null && Liste.Rows[e.RowIndex].ReadOnly == false)
            {

                comboCell.Items.Add("");
                comboCell.Value = "";
            }
        }
    }
}

