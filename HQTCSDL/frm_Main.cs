using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace HQTCSDL
{
    public partial class frm_Main : XtraForm
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private Form KiemTraForm(Type type)
        {
            foreach(Form f in this.MdiChildren)
            {
                if(f.GetType() == type)
                {
                    return f;
                }
            }
            return null;
        }


        private void BBT_VatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

                VatTu frms = new VatTu();
                frms.ShowDialog();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
