using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Model
{
    class Formlar
    {
        #region InformationEntry

        public void Category()
        {
            Bilgi.frmCategoryEntry frm = new Bilgi.frmCategoryEntry();
            frm.ShowDialog();
        }

        public void Shipper()
        {
            Bilgi.frmShipper frm = new Bilgi.frmShipper();
            frm.ShowDialog();
        }

        public void Employee()
        {
            Bilgi.frmEmployee frm = new Bilgi.frmEmployee();
            frm.ShowDialog();
        }

        #endregion

        #region SalesProcess

        #endregion

        #region StockProcess

        #endregion
    }
}
