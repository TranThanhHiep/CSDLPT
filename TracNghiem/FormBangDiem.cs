using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class FormBangDiem : Form
    {
        int macn = 0;
        public FormBangDiem()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FormBangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            // TODO: This line of code loads data into the 'dB.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dB.LOP);
          
            macn = Program.mChinhanh;

            if (Program.mGroup == "TRUONG") //chỉ được xem 
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
              
            }
            else  // nếu không thì tắt cái cmbCoSo di 
                cmbCoSo.Enabled = false;
            cmbCoSo.DataSource = Program.bds_dspm;
            // sao chép bds_dspm đã load ở form đăng nhập qua
            cmbCoSo.DisplayMember = "TENCN";
            cmbCoSo.ValueMember = "TENSERVER";
        }

        private void btnInBangDiem_Click(object sender, EventArgs e)
        {
            string MaLop = cmbMaLop.SelectedValue.ToString();
            string MaMH = cmbMaMH.SelectedValue.ToString();
            int Lan = Convert.ToInt16(cmblan.SelectedItem);
            if (MaLop == "" || MaMH == "" || Lan.ToString() == "")
            {
                MessageBox.Show("Chưa đủ điều kiện in bảng điểm!");
                return;
            }
            else
            {
                DataTable dt = new DataTable();
                dt = Program.ExecSqlDataTable("exec SP_IN_BANGDIEM '" + MaLop + "','" + MaMH + "','" + Lan + "' ");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu!");
                    return;
                }
                else
                {
                    Rpt_InBangDiem report = new Rpt_InBangDiem(MaLop,MaMH,Lan);
                    report.DataSource = dt;
                    report.ShowPreviewDialog();
                }

            }
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
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.dB.LOP);
                macn = cmbCoSo.SelectedIndex;
            }
        }
    }
    }

