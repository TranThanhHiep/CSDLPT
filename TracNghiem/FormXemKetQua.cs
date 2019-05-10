using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using System.Data.SqlClient;

namespace TracNghiem
{
    public partial class FormXemKetQua : Form
    {
        public FormXemKetQua()
        {
            InitializeComponent();
        }

        private void FormXemKetQua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            // TODO: This line of code loads data into the 'dB.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);

        }

        private void btnInKetQua_Click(object sender, EventArgs e)
        {
            if (cmbMaMH.Text.Trim() == "" )
            {
                MessageBox.Show("Môn học không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (cmbLan.Text.Trim() == "")
            {
                MessageBox.Show("Số lần không được trống", "", MessageBoxButtons.OK);
                return;
            }
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("exec SP_KETQUA '" + Program.mlogin + "', '" + cmbMaMH.SelectedValue.ToString() + "', '" + Convert.ToInt32(cmbLan.Text)  + "' ");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Sinh Viên Chưa Thi Môn Này Lần Này!");
                return;
            }
            else
            {
                
                rpt_XemKetQua report = new rpt_XemKetQua(Program.mlogin, cmbMaMH.SelectedValue.ToString(), Convert.ToInt32(cmbLan.Text));
                report.DataSource = dt;
                report.lblHoTen.Text = Program.mHoten;
                report.lblMonThi.Text = cmbMaMH.Text;
                report.lblLanThi.Text = cmbLan.Text;
                report.ShowPreviewDialog();
            }
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }
    }
}
