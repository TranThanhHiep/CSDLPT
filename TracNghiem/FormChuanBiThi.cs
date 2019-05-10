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
    public partial class FormChuanBiThi : Form
    {
        int macn=0;
        public FormChuanBiThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGVDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FormGVDK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            // TODO: This line of code loads data into the 'dB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dB.LOP);
            // TODO: This line of code loads data into the 'dB.GIAOVIEN' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dB.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);
            cmbMaMH.Visible = false;
            cmbMaLop.Visible = false;
            macn = Program.mChinhanh;

            if (Program.mGroup == "TRUONG")
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
                bar1.Visible = false;
                gbGVDK.Visible = false;
              
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                cmbCoSo.Enabled = false;
                gbGVDK.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            cmbCoSo.Enabled = false;  
            gbGVDK.Enabled = false;
            cmbCoSo.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập qua
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
         

        }
        private void cmbMaLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbMaLop.Text.Trim().Length == 0) return;
               txtMaLop.Text = cmbMaLop.SelectedValue.ToString();
        }

        private void cmbMaMH_SelectedIndexChanged_1(object sender, EventArgs e)
        {
             if (cmbMaMH.Text.Trim().Length == 0) return;
                 txtMaMH.Text = cmbMaMH.SelectedValue.ToString();

        }
    
     

    
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGVDK.AddNew();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbGVDK.Enabled = true;
            gcGVDK.Enabled = false;
            txtMaGV.Text = Program.username;
            txtMaGV.Enabled = false;
            cmbMaMH.Visible = true;
            cmbMaLop.Visible = true;
          

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtMaGV.Text.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được trống!");
                return;
            }
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống!");
                return;
            }
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được trống!");
                return;
            }
            if (cmbTRINHDO.Text.Trim() == "")
            {
                MessageBox.Show("Trình độ không được trống!");
                return;
            }
            if (dateNgayThi.Text.Trim() == "")
            {
                MessageBox.Show("Ngày thi không được trống!");
                return;
            }
            if (cmbLan.Text.Trim() == "")
            {
                MessageBox.Show("Lần thi không được trống!");
                return;
            }
             SqlDataReader rd = Program.ExecSqlDataReader("exec SP_LAYLCAUHOIBODE '"  + cmbMaMH.SelectedValue + "','" + cmbTRINHDO.SelectedItem + "' ");
            rd.Read();

            if (int.Parse(txtSoCauThi.Text) > rd.GetInt32(0))
            {
                MessageBox.Show("Số lượng câu hỏi đăng ký vượt quá số lượng đề thi!");
                return;
            }
            if (txtSoCauThi.Text.Trim() == "")
            {
                MessageBox.Show("Số câu thi không được trống!");
                return;
            }
            if (Convert.ToInt32(txtThoiGian.Text) < 15 || Convert.ToInt32(txtThoiGian.Text) > 60)
            {
                MessageBox.Show("Thời gian thi phải từ 15 phút đến 60 phút!");
                return;
            }
            if (Convert.ToInt32(cmbLan.Text) > 2 && Convert.ToInt32(cmbLan.Text) <=0 )
            {
                MessageBox.Show("Chỉ có 2 lần thi !");
                return;
            }
            if (txtThoiGian.Text.Trim() == "")
            {
                MessageBox.Show("Thời gian thi không được trống!");
                return;
            }
            if (btnThem.Enabled == false)
            {
                if (gcGVDK.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_GVDKTONTAI '" + txtMaGV.Text + "','" + txtMaMH.Text + "','" + dateNgayThi.Value + "','" + cmbLan.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Giáo viên đã đăng kí môn này, ngày này với lần này  ở cơ sở này hoặc cơ sở khác!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
                {
                    bdsGVDK.EndEdit();
                    bdsGVDK.ResetCurrentItem();
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dB.GIAOVIEN_DANGKY);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu giáo viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }

            gcGVDK.Enabled = true;
            gbGVDK.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            cmbMaMH.Visible = false;
            cmbMaLop.Visible = false;
            btnLuu.Enabled = false;
         }

        private void btnSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            gbGVDK.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnPhucHoi.Enabled = true;

            txtMaGV.Enabled = false;
        }

        private void btnXoa_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa giáo viên đăng kí này không?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsGVDK.RemoveCurrent();
                    this.gIAOVIEN_DANGKYTableAdapter.Update(this.dB.GIAOVIEN_DANGKY);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giáo viên. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
        }

        private void btnPhucHoi_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            bdsGVDK.CancelEdit();
            gbGVDK.Enabled = false;
            gcGVDK.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
          
        }

        private void btnRefresh_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

       

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
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
                this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dB.LOP);
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dB.MONHOC);

                macn = cmbCoSo.SelectedIndex;
            }
        }

        private void gcLop_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
