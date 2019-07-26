using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Modal
{
    class Numaralar
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        public string FirmaNo()
        {
            try
            {
                int numara = (from s in _db.tblCompanies
                              orderby s.ID descending
                              select s).First().CompNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string UrunSiraNo()
        {
            try
            {
                int numara = ((from s in _db.tblProducts
                               orderby s.ID descending
                               select s).First()).ProNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string AlisNo()
        {
            try
            {
                int numara = ((from s in _db.tblPurchasings
                               orderby s.ID descending
                               select s).First()).PurNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
        public string SatisNo()
        {
            try
            {
                int numara = ((from s in _db.tblSalesUps
                               orderby s.ID descending
                               select s).First()).SalesID.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
