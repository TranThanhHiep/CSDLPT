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
    public partial class FormNhapMH : Form
    {
        public FormNhapMH()
        {
            InitializeComponent();
        }

      
        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMonHoc.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FormNhapMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);
            // TODO: This line of code loads data into the 'dB.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dB.BODE);
            // TODO: This line of code loads data into the 'dB.BANGDIEM' table. You can move, or remove it, as needed.
            this.bANGDIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.bANGDIEMTableAdapter.Fill(this.dB.BANGDIEM);
            // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);

            if (Program.mGroup == "TRUONG")
            {
                bar1.Visible = false;
                gbMonHoc.Visible = false;
            }

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống!");
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được trống!");
                return;
            }
            if (btnThem.Enabled == false)
            {
                if (gcMonHoc.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_MONHOCTONTAI '" + txtMaMH.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Mã MÔN HỌC đã tồn tại!", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
            {
                bdsMonHoc.EndEdit();
                bdsMonHoc.ResetCurrentItem();
                this.mONHOCTableAdapter.Update(this.dB.MONHOC);

            }
            catch (Exception ex)
            {
                    MessageBox.Show("Lỗi lưu môn học . " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            gcMonHoc.Enabled = true;
            gbMonHoc.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbMonHoc.Enabled = true;
            gcMonHoc.Enabled = false;
            gcBoDe.Enabled = false;
            gcGVDK.Enabled = false;
            bdsMonHoc.AddNew();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbMonHoc.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
            txtMaMH.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsGVDK.Count > 0)
            {
                MessageBox.Show("Môn học đã đăng ký thi nên không thể xóa", "", MessageBoxButtons.OK);
                return;

            }
            if (bdsBoDe.Count > 0)
            {
                MessageBox.Show("Môn học đã soạn câu hỏi thi nên không thể xóa", "", MessageBoxButtons.OK);
                return;

            }
          
            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa môn học này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsMonHoc.RemoveCurrent();
                    this.mONHOCTableAdapter.Update(this.dB.MONHOC);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa môn học. " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else return;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMonHoc.CancelEdit();
            gbMonHoc.Enabled = false;
            gcMonHoc.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            gcBoDe.Enabled = true;
            gcGVDK.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            gbMonHoc.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
            btnRefresh.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
