using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TracNghiem
{
    public partial class FormKhoa : Form
    {
        int macn = 0;
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dB.SINHVIEN);
            // TODO: This line of code loads data into the 'dB.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
            // TODO: This line of code loads data into the 'dB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dB.LOP);
            // TODO: This line of code loads data into the 'dB.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dB.KHOA);
            this.cOSOTableAdapter.Fill(this.dB.COSO);
            cmbCS.Visible = false;
            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
                bar1.Visible = false;
                gbKhoa.Visible = false;
                bar2.Visible = false;
                gbLop.Visible = false;
            }
            else cmbCoSo.Enabled = false;
            cmbCoSo.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập qua
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
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
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dB.LOP);
                this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
                this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                this.kHOATableAdapter.Fill(this.dB.KHOA);


                macn = cmbCoSo.SelectedIndex;

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.AddNew();
            gcKhoa.Enabled = false;
            gbLop.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbKhoa.Enabled = true;
            txtMaCS.Text = cmbCS.SelectedValue.ToString();
            txtMaCS.Enabled = false;
           

        }

        private void btnLuu_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được trống!");
                return;
            }
            if (txtTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Tên khoa không được trống!");
                return;
            }
            if (txtMaCS.Text.Trim() == "")
            {
                MessageBox.Show("Mã cơ sở không được trống!");
                return;
            }
            if (btnThem.Enabled == false)
            {
                if (gcKhoa.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_KHOATONTAI '" + txtMaKH.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại ở cơ sở này hoặc cơ sở khác!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
            {
                bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Update(this.dB.KHOA);

            }
            catch (Exception ex)
            {
               
                    MessageBox.Show("Lỗi lưu khoa. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            gbKhoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            gcKhoa.Enabled = true;

        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLop.Count > 0)
            {
                MessageBox.Show("Khoa đã có lớp nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGiaoVien.Count > 0)
            {
                MessageBox.Show("Khoa đã có giáo viên nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa khoa này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsKhoa.RemoveCurrent();
                    this.kHOATableAdapter.Update(this.dB.KHOA);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa khoa. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
        }

        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbKhoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaCS.Text = cmbCS.SelectedValue.ToString();
            txtMaCS.Enabled = false;
            txtMaKH.Enabled = false;


        }

        private void btnPhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKhoa.CancelEdit();
            gbKhoa.Enabled = false;
            gcKhoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnRefresh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
            this.lOPTableAdapter.Fill(this.dB.LOP);
            this.kHOATableAdapter.Fill(this.dB.KHOA);
            gbKhoa.Enabled = true;
            gcKhoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnThem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.AddNew();
            gbKhoa.Enabled = false;
            gcLop.Enabled = false;
            btnThem1.Enabled = false;
            btnLuu1.Enabled = true;
            btnSua1.Enabled = false;
            btnXoa1.Enabled = false;
            gbLop.Enabled = true;
           
        }

        private void btnLuu1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được trống!");
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được trống!");
                return;
            }
            if (txtMaKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Mã khoa không được trống!");
                return;
            }
            if (btnThem1.Enabled == false)
            {
                if (gcLop.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_LOPTONTAI '" + txtMaLop.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại ở cơ sở này hoặc cơ sở khác!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
            {
                bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Update(this.dB.LOP);

            }
            catch (Exception ex)
            {
               
                    MessageBox.Show("Lỗi lưu lớp. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            gcLop.Enabled = true;
            gbLop.Enabled = false;
            btnThem1.Enabled = true;
            btnSua1.Enabled = true;
            btnXoa1.Enabled = true;
            btnPhucHoi1.Enabled = false;
            btnLuu1.Enabled = false;

        }

        private void btnSua1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbLop.Enabled = true;
            btnThem1.Enabled = false;
            btnSua1.Enabled = false;
            btnXoa1.Enabled = false;
            btnLuu1.Enabled = true;
            txtMaLop.Enabled = false;
        }

        private void btnPhucHoi1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLop.CancelEdit();
            gbLop.Enabled = false;
            gcLop.Enabled = true;
            btnThem1.Enabled = true;
            btnSua1.Enabled = true;
            btnXoa1.Enabled = true;
            btnPhucHoi1.Enabled = true;
            btnLuu1.Enabled = true;
        }

        private void btnRefresh1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIAOVIENTableAdapter.Fill(this.dB.GIAOVIEN);
            this.lOPTableAdapter.Fill(this.dB.LOP);
            this.kHOATableAdapter.Fill(this.dB.KHOA);
            gbLop.Enabled = true;
            gcLop.Enabled = true;
            btnThem1.Enabled = true;
            btnSua1.Enabled = true;
            btnXoa1.Enabled = true;
            btnPhucHoi1.Enabled = true;
            btnLuu1.Enabled = true;
        }

        private void btnThoat1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnXoa1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            if (bdsSinhVien.Count > 0)
            {
                MessageBox.Show("Lớp đã có sinh viên nên không thể xóa", "", MessageBoxButtons.OK);
                return;
            }

            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa lớp này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsLop.RemoveCurrent();
                    this.lOPTableAdapter.Update(this.dB.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
