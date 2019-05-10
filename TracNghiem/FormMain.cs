using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TracNghiem
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
           phanquyen();
        }
        public void phanquyen()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                rbpGiaoVien.Visible = false;
                rbpTaoLogin.Visible = false;
                rbpBaoCao.Visible = false;
                rbpThi.Visible = true;
                
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                rbpGiaoVien.Visible = true;
                btnMonHoc.Enabled = false;
                btnSinhVien.Enabled = false;
                btnGiaoVien.Enabled = false;
                btnKhoa.Enabled = false;
                rbpTaoLogin.Visible = false;
                rbpThi.Visible = true;
                rbpBaoCao.Visible = false;
                btnInBangDiem.Enabled = false;

            }
            else if (Program.mGroup == "COSO")
            {
                rbpGiaoVien.Visible = true;
                btnMonHoc.Enabled = true;
                btnSinhVien.Enabled = true;
                btnGiaoVien.Enabled = true;
                btnKhoa.Enabled = true;
                rbpThi.Visible = false;
                rbpTaoLogin.Visible = true;
                rbpBaoCao.Visible = true;
                btnDeThi.Enabled = false;
            }
            else
            {
                rbpGiaoVien.Visible = true;
                btnMonHoc.Enabled = true;
                btnSinhVien.Enabled = true;
                btnGiaoVien.Enabled = true;
                btnKhoa.Enabled = true;
                rbpThi.Visible = false;
                rbpTaoLogin.Visible = true;
                rbpBaoCao.Visible = true;
            }
            return;
            
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
      
        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              Form frm = this.CheckExists(typeof(FormNhapMH));
              if (frm != null) frm.Activate();
              else
              {
                   FormNhapMH f = new FormNhapMH();
                  f.MdiParent = this;
                  f.Show();
              }
        }
        private void btnGiaoVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormGiaoVien));
            if (frm != null) frm.Activate();
            else
            {
                FormGiaoVien f = new FormGiaoVien();
                f.MdiParent = this;
                f.Show();
            }
            
        }
        private void btnChuanBiThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Form frm = this.CheckExists(typeof(FormChuanBiThi));
            if (frm != null) frm.Activate();
            else
            {
                FormChuanBiThi f = new FormChuanBiThi();
                f.MdiParent = this;
                f.Show();
            }
           
        }
        private void btnInBangDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Form frm = this.CheckExists(typeof(FormBangDiem));
            if (frm != null) frm.Activate();
            else
            {
                FormBangDiem f = new FormBangDiem();
                f.MdiParent = this;
                f.Show();
            }
            
        }
      
        private void btnSinhVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSinhVien));
            if (frm != null) frm.Activate();
            else
            {
               FormSinhVien f = new FormSinhVien();
                f.MdiParent = this;
                f.Show();
            }
           
        }
        private void btnDeThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                Form frm = this.CheckExists(typeof(FormBoDe));
                if (frm != null) frm.Activate();
                else
                {
                    FormBoDe f = new FormBoDe();
                    f.MdiParent = this;
                    f.Show();
                }
                
        }
        private void btnKhoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           Form frm = this.CheckExists(typeof(FormKhoa));
            if (frm != null) frm.Activate();
            else
            {
               FormKhoa f = new FormKhoa();
                f.MdiParent = this;
                f.Show();
            }
            
        }
     
    
           public  void HienThiMenu() {
            MAGV.Text = "Mã : " + Program.username;
            HOTEN.Text = "Họ tên nhân viên : " + Program.mHoten;
            NHOM.Text = "Nhóm : " + Program.mGroup;
            // Phân quyền
            
        }

        private void MNV_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnLogOut_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
            FormDangNhap f = new FormDangNhap();
            f.Show();
        }


        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnThi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormThi));
            if (frm != null) frm.Activate();
            else
            {
                FormThi f = new FormThi();
                f.MdiParent = this;
                f.Show();
            }

        }

       

        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoLogin f = new FormTaoLogin(Program.mGroup); 
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormBaoCao));
            if (frm != null) frm.Activate();
            else
            {
                FormBaoCao f = new FormBaoCao();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnShowKetQua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormXemKetQua));
            if (frm != null) frm.Activate();
            else
            {
                FormXemKetQua f = new FormXemKetQua();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
