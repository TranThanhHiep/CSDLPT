using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class FormBaoCao : Form
    {
        int macn = 0;
        public FormBaoCao()
        {
            InitializeComponent();
        }
    
        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coso.lAYCOSO' table. You can move, or remove it, as needed.
            this.lAYCOSOTableAdapter.Fill(this.coso.lAYCOSO);
            this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lAYCOSOTableAdapter.Fill(this.coso.lAYCOSO);
            this.lAYCOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.dB.COSO);


            macn = Program.mChinhanh;
           
            if (Program.mGroup == "TRUONG") //chỉ được xem 
            {
                cmbCoSo.Enabled = true;  // bật tắt theo phân quyền
                                         //  SqlDataReader reader = Program.ExecSqlDataReader("exec lAYCOSO");
                                         //    reader.Read();
                                         //   cmbCoSo.SelectedValue = reader.GetString(0).ToString();
                cmbCoSo.DataSource = lAYCOSOBindingSource;
                cmbCoSo.DisplayMember = "MACS";
                cmbCoSo.ValueMember = "MACS";

            }
            else  // nếu không thì tắt cái cmbCoSo di 
            {
                cmbCoSo.Enabled = false;
                cmbCoSo.DataSource = cOSOBindingSource;// sao chép bds_dspm đã load ở form đăng nhập qua
                cmbCoSo.DisplayMember = "MACS";
                cmbCoSo.ValueMember = "MACS";
                
            }

        }


        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            DateTime TuNgay = dateFrom.Value;
            DateTime DenNgay = dateTo.Value;
            string coso = cmbCoSo.SelectedValue.ToString();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("exec SP_BAOCAO_DANGKITHI '" + TuNgay + "','" + DenNgay + "','" + coso + "' ");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!");
                return;
            }
            else
            {
                rpt_InBaoCao report = new rpt_InBaoCao(TuNgay, DenNgay, coso);
                report.DataSource = dt;
                report.lblTo.Text = dateTo.Text;
                report.lblCoSo.Text = coso;
                report.lblFrom.Text = dateFrom.Text;
                report.ShowPreviewDialog();
            
            }

        }

        private void cmbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            

        }

        private void cmbCN_SelectedIndexChanged_1(object sender, EventArgs e)
        {

          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedIndex == -1) return;
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView") return;


            Program.servername = cmbCN.SelectedValue.ToString();

            if (cmbCN.SelectedIndex != Program.mChinhanh) // khác với cơ sở đăng nhập ban đầu
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

                this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cOSOTableAdapter.Fill(this.dB.COSO);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

 