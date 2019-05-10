using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace TracNghiem
{
    public partial class FormGiaoVien : Form
    {
        int macn = 0;
        public FormGiaoVien()
        {
           
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void gIAOVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGiaoVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void FormGiaoVien_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.dB.KHOA);
            // TODO: This line of code loads data into the 'dB.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dB.KHOA);
            // TODO: This line of code loads data into the 'dB.BODE' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'dB.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);

            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_CoSoKhoa' table. You can move, or remove it, as needed.
                 this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
                 this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
                 // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
                 this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                 this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
                  // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.BODE' table. You can move, or remove it, as needed.
                this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dB.BODE);


            macn = Program.mChinhanh;
            cmbMaKhoa.Visible = false;
            
               if (Program.mGroup == "TRUONG") //chỉ được xem 
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
                 bar1.Visible = false;  //tắt bar tính năng
                gbGiaoVien.Visible = false; //tắt thông tin giáo viên 
            }
            else  // nếu không thì tắt cái cmbCoSo di 
             cmbCoSo.Enabled = false;        
             cmbCoSo.DataSource = Program.bds_dspm;
            // sao chép bds_dspm đã load ở form đăng nhập qua
               cmbCoSo.DisplayMember = "TENCN";
               cmbCoSo.ValueMember = "TENSERVER";
             
        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsGiaoVien.AddNew();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbGiaoVien.Enabled = true;
            gcGiaoVien.Enabled = false;
            cmbMaKhoa.Visible = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbGiaoVien.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            cmbMaKhoa.Visible = false;
            cmbMaKhoa.Visible = true;
            txtMaGV.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Giáo viên đã đăng ký thi nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Giáo viên đã soạn câu hỏi thi nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa giáo viên này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsGiaoVien.RemoveCurrent();
                    this.gIAOVIENTableAdapter.Update(this.dB.GIAOVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
            
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGiaoVien.CancelEdit();
            gbGiaoVien.Enabled = false;
            gcGiaoVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được trống!");
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được trống!");
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ giáo viên không được trống!");
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên giáo viên không được trống!");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống!");
                return;
            }

            if (btnThem.Enabled == false)
            {
                if (gcGiaoVien.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_GIAOVIENTONTAI '" + txtMaGV.Text + "' ");

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã giáo viên đã tồn tại ở cơ sở này hoặc cơ sở khác!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
                {
                    bdsGiaoVien.EndEdit();
                    bdsGiaoVien.ResetCurrentItem();
                    this.gIAOVIENTableAdapter.Update(this.dB.GIAOVIEN);

                }
                catch (Exception ex)
                {
                        MessageBox.Show("Lỗi lưu giáo viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            gcGiaoVien.Enabled = true;
            gbGiaoVien.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
       
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
            gcGiaoVien.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

      
        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void cmbKhoa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void gcGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedValue == null) return;
            if (cmbCoSo.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbCoSo.SelectedValue.ToString();

            if (cmbCoSo.SelectedIndex != Program.mChinhanh) // khác với cơ sở đăng nhập ban đầu
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở mới", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                 this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                 this.kHOATableAdapter.Fill(this.dB.KHOA);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);

                macn = cmbCoSo.SelectedIndex;
            }
        }

        private void cmbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaKhoa.Text.Trim().Length == 0) return;
            txtMaKhoa.Text = cmbMaKhoa.SelectedValue.ToString();
        }
    }
}
