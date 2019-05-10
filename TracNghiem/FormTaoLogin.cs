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
    public partial class FormTaoLogin : Form
    {
        public FormTaoLogin(String Role)
        {
            InitializeComponent();
            if (String.Compare(Role, "TRUONG") == 0)
            {
                cmbGroup.Items.Add("TRUONG");
            }
            else if (String.Compare(Role, "COSO") == 0)
            {
                cmbGroup.Items.Add("COSO");
                cmbGroup.Items.Add("GIANGVIEN");
                cmbGroup.Items.Add("SINHVIEN");
              
            }
            cmbGroup.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String username = txtUserName.Text;
            String matkhau = txtPass.Text;
            String loginname = txtLoginName.Text;
            try
            {
                String connectionstring = "Server=" + Program.servername + ";initial catalog=" + Program.database + ";persist security info=true;User id=" + Program.mlogin + ";Password=" + Program.password;

                SqlConnection sqlConnection = new SqlConnection(connectionstring);
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                //kirm tra
                      sqlCommand.CommandText = "SP_TAOLOGIN";
                      sqlCommand.Parameters.Add(new SqlParameter("@LGNAME", loginname));
                      sqlCommand.Parameters.Add(new SqlParameter("@PASS", matkhau));
                      sqlCommand.Parameters.Add(new SqlParameter("@USERNAME", username));
                      sqlCommand.Parameters.Add(new SqlParameter("@ROLE", cmbGroup.Text));
                     
                SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
           
                sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
                sqlCommand.Parameters.Add(sqlParameter);
                
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Tạo Thành Công!!!!!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tạo Login : " + ex.Message);

            }
        }
      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTaoLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
