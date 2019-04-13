using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;

namespace HQTCSDL
{
    partial class VatTu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VatTu));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tbNP_BoTri = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.pn_BoTri = new System.Windows.Forms.Panel();
            this.txt_LoaiPhong = new System.Windows.Forms.TextBox();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_VatTu_BoTri = new System.Windows.Forms.TextBox();
            this.num_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.tbNP_VatTu = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.dtg_VatTu = new System.Windows.Forms.DataGridView();
            this.pn_VatTu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.txt_MaVatTu = new System.Windows.Forms.TextBox();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenVatTu = new System.Windows.Forms.TextBox();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.mavattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvattu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tbNP_BoTri.SuspendLayout();
            this.pn_BoTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).BeginInit();
            this.tbNP_VatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VatTu)).BeginInit();
            this.pn_VatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tbNP_BoTri);
            this.tabPane1.Controls.Add(this.tbNP_VatTu);
            resources.ApplyResources(this.tabPane1, "tabPane1");
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tbNP_BoTri,
            this.tbNP_VatTu});
            this.tabPane1.RegularSize = new System.Drawing.Size(792, 566);
            this.tabPane1.SelectedPage = this.tbNP_VatTu;
            // 
            // tbNP_BoTri
            // 
            resources.ApplyResources(this.tbNP_BoTri, "tbNP_BoTri");
            this.tbNP_BoTri.Controls.Add(this.dataGridView1);
            this.tbNP_BoTri.Controls.Add(this.pn_BoTri);
            this.tbNP_BoTri.Name = "tbNP_BoTri";
            // 
            // pn_BoTri
            // 
            this.pn_BoTri.Controls.Add(this.txt_LoaiPhong);
            this.pn_BoTri.Controls.Add(this.simpleButton1);
            this.pn_BoTri.Controls.Add(this.label4);
            this.pn_BoTri.Controls.Add(this.simpleButton2);
            this.pn_BoTri.Controls.Add(this.label3);
            this.pn_BoTri.Controls.Add(this.simpleButton3);
            this.pn_BoTri.Controls.Add(this.label5);
            this.pn_BoTri.Controls.Add(this.txt_VatTu_BoTri);
            this.pn_BoTri.Controls.Add(this.num_SoLuong);
            resources.ApplyResources(this.pn_BoTri, "pn_BoTri");
            this.pn_BoTri.Name = "pn_BoTri";
            // 
            // txt_LoaiPhong
            // 
            resources.ApplyResources(this.txt_LoaiPhong, "txt_LoaiPhong");
            this.txt_LoaiPhong.Name = "txt_LoaiPhong";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Name = "simpleButton3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txt_VatTu_BoTri
            // 
            resources.ApplyResources(this.txt_VatTu_BoTri, "txt_VatTu_BoTri");
            this.txt_VatTu_BoTri.Name = "txt_VatTu_BoTri";
            // 
            // num_SoLuong
            // 
            resources.ApplyResources(this.num_SoLuong, "num_SoLuong");
            this.num_SoLuong.Name = "num_SoLuong";
            // 
            // tbNP_VatTu
            // 
            resources.ApplyResources(this.tbNP_VatTu, "tbNP_VatTu");
            this.tbNP_VatTu.Controls.Add(this.dtg_VatTu);
            this.tbNP_VatTu.Controls.Add(this.pn_VatTu);
            this.tbNP_VatTu.Name = "tbNP_VatTu";
            // 
            // dtg_VatTu
            // 
            this.dtg_VatTu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_VatTu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavattu,
            this.tenvattu});
            resources.ApplyResources(this.dtg_VatTu, "dtg_VatTu");
            this.dtg_VatTu.Name = "dtg_VatTu";
            this.dtg_VatTu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_VatTu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_VatTu_CellClick);
            // 
            // pn_VatTu
            // 
            this.pn_VatTu.Controls.Add(this.label1);
            this.pn_VatTu.Controls.Add(this.label2);
            this.pn_VatTu.Controls.Add(this.btn_Sua);
            this.pn_VatTu.Controls.Add(this.txt_MaVatTu);
            this.pn_VatTu.Controls.Add(this.btn_Xoa);
            this.pn_VatTu.Controls.Add(this.txt_TenVatTu);
            this.pn_VatTu.Controls.Add(this.btn_Them);
            resources.ApplyResources(this.pn_VatTu, "pn_VatTu");
            this.pn_VatTu.Name = "pn_VatTu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Sua.Appearance.Font")));
            this.btn_Sua.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn_Sua, "btn_Sua");
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // txt_MaVatTu
            // 
            resources.ApplyResources(this.txt_MaVatTu, "txt_MaVatTu");
            this.txt_MaVatTu.Name = "txt_MaVatTu";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Xoa.Appearance.Font")));
            this.btn_Xoa.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn_Xoa, "btn_Xoa");
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // txt_TenVatTu
            // 
            resources.ApplyResources(this.txt_TenVatTu, "txt_TenVatTu");
            this.txt_TenVatTu.Name = "txt_TenVatTu";
            this.txt_TenVatTu.TextChanged += new System.EventHandler(this.txt_TenVatTu_TextChanged);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_Them.Appearance.Font")));
            this.btn_Them.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btn_Them, "btn_Them");
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // mavattu
            // 
            this.mavattu.DataPropertyName = "mavattu";
            resources.ApplyResources(this.mavattu, "mavattu");
            this.mavattu.Name = "mavattu";
            this.mavattu.ReadOnly = true;
            // 
            // tenvattu
            // 
            this.tenvattu.DataPropertyName = "tenvattu";
            resources.ApplyResources(this.tenvattu, "tenvattu");
            this.tenvattu.Name = "tenvattu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // VatTu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.IsMdiContainer = true;
            this.Name = "VatTu";
            this.Load += new System.EventHandler(this.VatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tbNP_BoTri.ResumeLayout(false);
            this.pn_BoTri.ResumeLayout(false);
            this.pn_BoTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoLuong)).EndInit();
            this.tbNP_VatTu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_VatTu)).EndInit();
            this.pn_VatTu.ResumeLayout(false);
            this.pn_VatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    
        private TabPane tabPane1;
        private TabNavigationPage tbNP_BoTri;
        private TabNavigationPage tbNP_VatTu;
        private System.Windows.Forms.NumericUpDown num_SoLuong;
        private System.Windows.Forms.TextBox txt_VatTu_BoTri;
        private System.Windows.Forms.TextBox txt_LoaiPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private SimpleButton simpleButton1;
        private SimpleButton simpleButton2;
        private SimpleButton simpleButton3;
        private System.Windows.Forms.Panel pn_BoTri;
        private System.Windows.Forms.Panel pn_VatTu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private SimpleButton btn_Sua;
        private System.Windows.Forms.TextBox txt_MaVatTu;
        private SimpleButton btn_Xoa;
        private System.Windows.Forms.TextBox txt_TenVatTu;
        private SimpleButton btn_Them;
        private System.Windows.Forms.DataGridView dtg_VatTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvattu;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
