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
    public partial class FormBoDe : Form
    {
        public FormBoDe()
        {
            InitializeComponent();
        }

        private void FormBoDe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            // TODO: This line of code loads data into the 'dB.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            this.bODETableAdapter.Fill(this.dB.BODE);
             gbBoDe.Enabled = false;
            cmbMaMH.Visible = false;

            if (Program.mGroup == "TRUONG")
            {
                bar1.Visible = false;
                gbBoDe.Visible = false;
            }

        }

        

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBoDe.AddNew();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            gbBoDe.Enabled = true;
            gcBoDe.Enabled = false;
            txtCauHoi.Text = bdsBoDe.Count.ToString();
            txtCauHoi.Enabled = false;

            txtMaGV.Text = Program.username;
            txtMaGV.Enabled = false;

            cmbMaMH.Visible = true;

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCauHoi.Text.Trim() == "")
            {
                MessageBox.Show("Câu hỏi không được trống!");
            }
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được trống!");
            }
            if (txtNoiDung.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung không được trống!");
            }
            if (cmbTrinhDo.Text.Trim() == "")
            {
                MessageBox.Show("Trình độ không được trống!");
            }
            if (txtA.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung đáp án A không được trống!");
            }
            if (txtB.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung đáp án B không được trống!");
            }
            if (txtC.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung đáp án C không được trống!");
            }
            if (txtD.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung đáp án D không được trống!");
            }
            if (cmbDapAn.Text.Trim() == "")
            {
                MessageBox.Show("Đáp án không được trống!");
            }
            if (Program.username.Trim() != txtMaGV.Text.Trim() && btnSua.Enabled == false)
            {
                MessageBox.Show("Bộ đề không phải do bạn soạn!");
                return;
            }
            if (btnThem.Enabled == false)
            {
                if (gcBoDe.Enabled == false)
                {
                    SqlDataReader reader = Program.ExecSqlDataReader("exec SP_KIEMTRA_CAUHOITONTAI '" + txtCauHoi.Text + "' ");
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Số Câu Hỏi đã tồn tại", "Lỗi", MessageBoxButtons.OK);
                        reader.Close();
                        return;
                    }
                    reader.Close();
                }
                try
                {
                    

                    bdsBoDe.EndEdit();
                    bdsBoDe.ResetCurrentItem();
                    this.bODETableAdapter.Update(this.dB.BODE);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu BỘ ĐỀ " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            gcBoDe.Enabled = true;
            gbBoDe.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = false;
            btnLuu.Enabled = false;
            
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gbBoDe.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtCauHoi.Enabled = true;
            txtMaGV.Enabled = false;
            txtCauHoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.username.Trim() != txtMaGV.Text.Trim() )
            {
                MessageBox.Show("Bộ đề không phải do bạn soạn nên không thể xóa!");
                return;
            }
            DialogResult Dialog = (MessageBox.Show("Bạn có muốn xóa đề thi này?", "Thông báo", MessageBoxButtons.YesNo));
            if (Dialog == DialogResult.Yes)
            {
                try
                {
                    bdsBoDe.RemoveCurrent();
                    this.bODETableAdapter.Update(this.dB.BODE);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa đề thi. " + ex.Message, "", MessageBoxButtons.OK);
                }
            }
            else return;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBoDe.CancelEdit();
            gbBoDe.Enabled = false;
            gcBoDe.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnLuu.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.bODETableAdapter.Fill(this.dB.BODE);
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

        private void gbBoDe_Enter(object sender, EventArgs e)
        {

        }

        private void cmbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaMH.Text.Trim().Length == 0) return;
            txtMaMH.Text = cmbMaMH.SelectedValue.ToString();
        }

        private void gcBoDe_Click(object sender, EventArgs e)
        {

        }
    }
}
