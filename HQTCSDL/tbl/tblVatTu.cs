using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQTCSDL.tbl
{
    class tblVatTu:Table
    {
        public List<object> ls = new List<object>();
        private string tenVatTu;
        
        public string TenVatTu
        {
            get { return tenVatTu; }
            set { tenVatTu = value; }            
        }
        private string maVatTu;
        public string MaVatTu
        {
            get { return maVatTu; }
            set { maVatTu = value; }
        }

        public override List<object> List_Table()
        {
            ls.Add(maVatTu);
            ls.Add(tenVatTu);
            
            return ls;
        }
    }
}
