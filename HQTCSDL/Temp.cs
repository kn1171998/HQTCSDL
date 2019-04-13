using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace HQTCSDL
{
    class Temp
    {

        //Lấy dữ liệu trên panel
        //List<object> Lay_DuLieu_Panel(Panel tenPanel)
        //{
        //    List<object> control = new List<object>();
        //    foreach (Control i in tenPanel.Controls)
        //    {
        //        Type type = i.GetType();
        //        if (type == typeof(ComboBox))
        //        {
        //            control.Add(i.CanSelect);
        //        }
        //        else
        //        {
        //            control.Add(i.Text);
        //        }
        //    }
        //    return control;
        //}
        //Hàm lấy dữ liệu trên controls
        public List<object> Add_DuLieu_Table(Table tenTable, Panel tenPanel)
        {
            List<object> l = tenTable.List_Table();
            int length_Table = l.Count, i = 0;
                // temp = table;
                //object temp;
            while(i < length_Table)
            {
                foreach (Control c in tenPanel.Controls)
                {

                    Type type = c.GetType();
                    if (type == typeof(Label) || type == typeof(SimpleButton))
                    {
                        continue;
                    }
                    else if (type == typeof(System.Windows.Forms.ComboBox))
                    {
                        l[i] = c.CanSelect.ToString().Trim();
                        i++;
                    }
                    else if (type == typeof(TextBox))
                    {
                        l[i] = c.Text.Trim();
                        i++;
                    }                
                }
            }
            
           // tenTable.ls = l;
            return l;
        }
    }
}
