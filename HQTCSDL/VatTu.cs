using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;

namespace HQTCSDL
{
    public partial class VatTu : XtraForm
    {
        BLL.VatTuBLL bllVatTu;
        DataTable dt;
        Temp Data_Control;
        public VatTu()
        {
            InitializeComponent();
            bllVatTu = new BLL.VatTuBLL();
            dt = new DataTable();
            Data_Control = new Temp();
        }


        //Hàm tạo mã vật tư
        public string TaoMaVatTu(string ten)
        {
            ten = ten.Trim();
            string ma_vattu;
            if (String.IsNullOrEmpty(ten))
            {
                XtraMessageBox.Show("Vui lòng điền tên vật tư trước khi thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ten = " ";
            }                                    
            ma_vattu = ten[0].ToString();
            int count_Ten = ten.Length;
            for (int i = 1; i < count_Ten; i++)
            {
                if (ten[i] == ' ')
                {
                    ma_vattu += ten[i + 1];
                }
            }
            return ma_vattu;
        }

        //tbl.tblVatTu LayDuLieuControls(tbl.tblVatTu vt)
        //{
        //    vt.MaVatTu = txt_MaVatTu.Text.ToString();
        //    vt.TenVatTu = txt_TenVatTu.Text.ToString();
        //    return vt;
        //}

        //Hàm loại bỏ dấu tiếng việt khỏi chuỗi
        private static readonly string[] VietNamChar = new string[]
        {
            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };

        public static string LocDau(string str)
        {
            //Thay thế lọc dấu từng kí tự
            int length_str = VietNamChar.Length;
            
            for(int i = 1; i < length_str; i++)
            {
                int length_char = VietNamChar[i].Length;
                for (int j = 0; j < length_char; j++)
                {
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
            }
            return str;
        }

        private void txt_TenVatTu_TextChanged(object sender, EventArgs e)
        {
            string temp = TaoMaVatTu(txt_TenVatTu.Text);
            txt_MaVatTu.Text = LocDau(temp);
        }


        //Lấy dữ liệu trên control
        //public 
        private void btn_Them_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(txt_TenVatTu.Text);
            tbl.tblVatTu vt = new tbl.tblVatTu();
            vt.ls = Data_Control.Add_DuLieu_Table(vt, pn_VatTu);
            if(bllVatTu.Insert_VatTu(vt.ls))
            {
                // Load_Data();
                Load_DL();
                XtraMessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    

        private void btn_Sua_Click(object sender, EventArgs e)
        {            
            if (bllVatTu.UpData_VaTu())
            {
                Load_DL();
                XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
            else
                XtraMessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Load_DL()
        {
            dtg_VatTu.DataSource = bllVatTu.getAllVatTu();
        }
        private void VatTu_Load(object sender, EventArgs e)
        {
            Load_DL();
        }
       
        private void dtg_VatTu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int select_cell = e.RowIndex;
            txt_MaVatTu.Text = dtg_VatTu.Rows[select_cell].Cells[0].Value.ToString();
            txt_TenVatTu.Text = dtg_VatTu.Rows[select_cell].Cells[1].Value.ToString();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int row_current = dtg_VatTu.CurrentCell.RowIndex;
            if (row_current > 0)
            {
                dtg_VatTu.Rows.RemoveAt(dtg_VatTu.CurrentCell.RowIndex);
                if (bllVatTu.UpData_VaTu())
                    XtraMessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    XtraMessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }
    }
}
