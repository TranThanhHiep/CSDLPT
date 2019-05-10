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
    public partial class FormSinhVien : Form
    {
        int macn=0;
        public FormSinhVien()
        {
            InitializeComponent();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void FormSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dB.LOP);
            // TODO: This line of code loads data into the 'dB.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dB.BANGDIEM);
            // TODO: This line of code loads data into the 'dB.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dB.SINHVIEN);
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            macn = Program.mChinhanh;
            cmbMaLop.Visible = false;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
                bar1.Visible = false;
                gbSinhVien.Visible = false;

            }
            else cmbCoSo.Enabled = false;
            cmbCoSo.DataSource = Program.bds_dspm;// sao chép bds_dspm đã load ở form đăng nhập qua
            
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
           
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.AddNew();
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbSinhVien.Enabled = true;
            gcSinhVien.Enabled = false;
            gcLop.Enabled = false;
            cmbMaLop.Visible = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được trống!");
                return;
            }
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được trống!");
                return;
            }
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ sinh viên không được trống!");
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên sinh viên không được trống!");
                return;
            }
            if (txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh không được trống!");
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống!");
                return;
            }

            if (btnThem.Enabled == false)
            {
                if (gcSinhVien.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_SINHVIENTONTAI '" + txtMaSV.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại ở cơ sở này hoặc cơ sở khác!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
                {
                    bdsSinhVien.EndEdit();
                    bdsSinhVien.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Update(this.dB.SINHVIEN);

                }
                catch (Exception ex)
                {

                        MessageBox.Show("Lỗi lưu sinh viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                }
                gcSinhVien.Enabled = true;
                gbSinhVien.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnPhucHoi.Enabled = false;
                btnLuu.Enabled = false;
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbSinhVien.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            cmbMaLop.Visible = true;
            txtMaSV.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBangDiem.Count > 0)
            {
                MessageBox.Show("Sinh viên đã có bảng điểm nên không thể xóa", "", MessageBoxButtons.OK);
                return;

            }
            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsSinhVien.RemoveCurrent();
                    this.sINHVIENTableAdapter.Update(this.dB.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSinhVien.CancelEdit();
            gbSinhVien.Enabled = false;
            gcSinhVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.sINHVIENTableAdapter.Fill(this.dB.SINHVIEN);
            this.lOPTableAdapter.Fill(this.dB.LOP);
            gbSinhVien.Enabled = false;
            gcSinhVien.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void gcSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbCoSo.SelectedIndex == -1) return;
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

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dB.LOP);
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.dB.SINHVIEN);
                this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
                this.bANGDIEMTableAdapter.Fill(this.dB.BANGDIEM);
                macn = Program.mChinhanh;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaLop.Text.Trim().Length == 0) return;
            txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
        }
    }
}
