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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMView.V_DS_PHANMANH' table. You can move, or remove it, as needed.
           // this.v_CoSoKhoaTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_CoSoKhoaTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            cmbCoSo.SelectedIndex = 1;
            cmbCoSo.SelectedIndex = 0;

       

        }
        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {

            if (txtLoginName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật mã không được trống", "", MessageBoxButtons.OK);
                return;
            }
      
            Program.mlogin = txtLoginName.Text;
            Program.password = txtPassword.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = cmbCoSo.SelectedIndex;  
            Program.bds_dspm = v_CoSoKhoaBindingSource;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
                MessageBox.Show("Đăng nhập thành công!");
            
                Program.myReader = Program.ExecSqlDataReader("EXEC SP_DANGNHAP'" + Program.mlogin + "'");
                Program.myReader.Read();
               
                if (Program.myReader == null) return; //tra về bảng thông báo sai tên đăng nhập 
                Program.username = Program.myReader.GetString(0); // lay ma trong mảng 
         
        /*    if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                return;
            }
    */      
    try
            {
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi dang nhap" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }


            Program.myReader.Close();
            Program.conn.Close();
            Program.frmChinh = new FormMain();
            Program.frmChinh.HienThiMenu();
            Program.frmChinh.Show();
            this.Visible = false;


          
            
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbCoSo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Program.servername = cmbCoSo.SelectedValue.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

