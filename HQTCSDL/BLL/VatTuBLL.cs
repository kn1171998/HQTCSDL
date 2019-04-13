using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HQTCSDL.BLL
{
    class VatTuBLL
    {
        DAL.VatTuDAL dalVatTu;
        public VatTuBLL()
        {
            dalVatTu = new DAL.VatTuDAL();
        }
        public DataTable getAllVatTu()
        {
            return dalVatTu.getAllVatTu();
        }

        public bool Insert_VatTu(List<object> tenTable)
        {
            return dalVatTu.Insert_VatTu(tenTable);
        }
        public bool UpData_VaTu()
        {
            return dalVatTu.Update_VatTu();
        }
    }
}
