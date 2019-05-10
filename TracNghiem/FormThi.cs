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
    public partial class FormThi : Form
    {
        public FormThi()
        {
            InitializeComponent();
        }

        private void gIAOVIEN_DANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gIAOVIEN_DANGKYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void FormChuanBiThi_Load(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'dB.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dB.MONHOC);
            // TODO: This line of code loads data into the 'dB.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.gIAOVIEN_DANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIEN_DANGKYTableAdapter.Fill(this.dB.GIAOVIEN_DANGKY);
            gbThi.Visible = false;
            LayThongTinSV();
        }
        public void LayThongTinSV()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                 SqlDataReader reader = Program.ExecSqlDataReader("exec SP_LAYTHONGTINSINHVIEN '" + Program.username + "' ");
                reader.Read();
                Program.malop = reader.GetString(0).ToString();
                Program.tenlop = reader.GetString(1).ToString();
                lblLop.Text = Program.malop;
                lblMALOP.Text = Program.tenlop;
                lblTenSV.Text = Program.mHoten;
                lblMaSV.Text = Program.username;
            }
            else gbThongTin.Visible = false;

        }

        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            SqlDataReader read = Program.ExecSqlDataReader("exec SP_KIEMTRA_SINHVIEN '" + lblMaSV.Text + "' , '" + cmbMaMH.SelectedValue + "' , '" + cmbLan.SelectedItem + "' ");

            if (read.HasRows)
            {
                MessageBox.Show("Sinh viên đã thi môn này lần  này rồi!");
                return;
            }
            else
                gbThi.Visible = true;
             //SqlDataReader reader  = Program.ExecSqlDataReader("exec SP_LayThongTinThi 'MMTCB' , 'TH09' , '1' ");
            SqlDataReader reader = Program.ExecSqlDataReader("exec SP_LayThongTinThi '" + cmbMaMH.SelectedValue + "' , '" + cmbNgayThi.SelectedValue + "' , '" + cmbLan.SelectedItem + "' ");
            if (reader.HasRows)
            {
                reader.Read();

                Program.tenmonhoc = reader.GetString(0).ToString();
                Program.mamonhoc = reader.GetString(1).ToString();
                Program.lanthi = reader.GetValue(2).ToString();
                Program.socauthi = reader.GetValue(4).ToString();
                Program.thoigianthi = reader.GetValue(5).ToString();
                Program.trinhdo = reader.GetValue(6).ToString();
                Program.hotengv = reader.GetString(7).ToString();
                Program.tenlop = reader.GetString(8).ToString();
                Program.ngaythi = reader.GetValue(3).ToString();
                lblTenMH.Text = Program.tenmonhoc;
                lblTenLop.Text = Program.tenlop;

                if (Program.trinhdo == "A") lblTrinhDo.Text = "Đại học, chuyên ngành ";
                else if (Program.trinhdo == "B") lblTrinhDo.Text = "Đại học, không chuyên ngành ";
                else lblTrinhDo.Text = "Cao đẳng ";

                lblHoTenGV.Text = Program.hotengv;
                lblSoCauThi.Text = Program.socauthi;
                lblThoiGianThi.Text = Program.thoigianthi + " phút";
            }
            else
            {
                MessageBox.Show("Môn học chưa đăng ký hoặc thông tin bạn chọn chưa chính xác!");
                return;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnBatDauThi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = this.CheckExists(typeof(FormLamBai));
            if (frm != null) frm.Activate();
            else
            {
               FormLamBai f = new FormLamBai();
                f.MdiParent = this.MdiParent;
                f.Show();
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
   }


