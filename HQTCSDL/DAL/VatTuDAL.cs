using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace HQTCSDL.DAL
{
    class VatTuDAL
    {
        DataConnection dc;
        public VatTuDAL()
        {
            dc = new DataConnection();
        }
        //string queryAll, queryInsert, queryDelete, queryUpdate;
        public DataTable getAllVatTu()
        {
            //queryAll = "SELECT * FROM VATTU";
        
            return dc.getData("VATTU");
        }

        public bool Insert_VatTu(List<object> tenTable)
        {
            return dc.Insert_Data_KS("VATTU", tenTable);
        }

        public bool Update_VatTu()
        {
            return dc.Update_Fast();
        }
    }
}
