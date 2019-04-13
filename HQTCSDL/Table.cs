using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQTCSDL
{
    abstract class Table
    {
        public List<object> ls = new List<object>();
        public abstract List<object> List_Table();
    }
}
