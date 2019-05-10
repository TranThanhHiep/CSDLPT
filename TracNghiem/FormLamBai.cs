using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class FormLamBai : Form
    {

        int stt = 1;
        List<CauHoi> lstCauHoi = new List<CauHoi>();//khoi tao 1 list cauhoi
        DataTable dtCauHoi;
        public FormLamBai()
        {
            InitializeComponent();
        }

        private void FormThi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRACNGHIEMDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.tRACNGHIEMDataSet.V_DS_PHANMANH);
            // TODO: This line of code loads data into the 'dB.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cOSOTableAdapter.Fill(this.dB.COSO);
            LayThongTin();
            btnQuayLai.Enabled = false;
            cmbCoSo.Visible = false;
            cmbCN.Visible = false;
            cmbCN.DataSource = Program.bds_dspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
           dtCauHoi = Program.ExecSqlDataTable("exec SP_LayCauHoi_NgauNhien '" + Program.mamonhoc + "','" + Program.trinhdo + "','" + Program.socauthi + "','" + cmbCoSo.SelectedValue + "' ");
            foreach (DataRow dr in dtCauHoi.Rows) // dr biến tạm...
            {
                CauHoi cauHoi = new CauHoi()
                {
                    CAUHOI = Convert.ToInt32(dr["CAUHOI"]),
                    MAMH = dr["MAMH"].ToString(),
                    TRINHDO = dr["TRINHDO"].ToString(),
                    NOIDUNG = dr["NOIDUNG"].ToString(),
                    A = dr["A"].ToString(),
                    B = dr["B"].ToString(),
                    C = dr["C"].ToString(),
                    D = dr["D"].ToString(),
                    DAPAN = dr["DAP_AN"].ToString(),
                    MAGV = dr["MAGV"].ToString(),
                    DA_SV_CHON = " "
                };
                lstCauHoi.Add(cauHoi);
            }

            //hien thi cau hoi dau tien
            lblSoCauHT.Text = stt.ToString() + "/" + lstCauHoi.Count(); //so thu tu 
            txtCauHoi.Text = lstCauHoi[stt - 1].NOIDUNG;
            rdb1.Text = lstCauHoi[stt - 1].A;
            rdb2.Text = lstCauHoi[stt - 1].B;
            rdb3.Text = lstCauHoi[stt - 1].C;
            rdb4.Text = lstCauHoi[stt - 1].D;
         
        }
        private void LayThongTin()
        {
            lblTenSV.Text = Program.mHoten;
            lblMaSV.Text = Program.username;
            lbltenMH.Text = Program.tenmonhoc;
            lblSoCauThi.Text = Program.socauthi;
            lblTgian.Text = Program.thoigianthi + " phút";
            timer1.Start();
            lblPhut.Text = string.Format(Program.thoigianthi, "00");
            lblGiay.Text = "00";
        }

        private void btnNopBai_Click(object sender, EventArgs e)
        {
            if (lblPhut.Text != "00" || lblGiay.Text != "00")
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn nộp bài thi không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    timer1.Stop();
                    TinhDiemThi();
                }
                else
                {
                    return;
                }
            }
            else
            TinhDiemThi();
            LuuBaiThi();
            DataTable dt = new DataTable();
            dt = Program.ExecSqlDataTable("exec SP_KETQUA '" + Program.mlogin + "', '" + Program.mamonhoc + "', '" + Program.lanthi + "' ");
            rpt_XemKetQua report = new rpt_XemKetQua(Program.mlogin,Program.mamonhoc, Convert.ToInt32(Program.lanthi));
            report.DataSource = dt;
            report.lblHoTen.Text = Program.mHoten;
            report.lblMonThi.Text = Program.tenmonhoc;
            report.lblLanThi.Text = Program.lanthi;
            report.ShowPreviewDialog();


        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            btnTiep.Enabled = true;
            stt = stt - 1;
            if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "") // nếu chưa chọn thì hiện ra chưa chọn 
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
            }
            //nếu chọn rồi thì hiện ra đáp án đã chọn
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "A") rdb1.Checked = true;
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "B") rdb2.Checked = true;
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "C") rdb3.Checked = true;
            else rdb4.Checked = true;
            lblSoCauHT.Text = (stt).ToString() + "/" + lstCauHoi.Count();
            txtCauHoi.Text = lstCauHoi[stt - 1].NOIDUNG;
            rdb1.Text = lstCauHoi[stt - 1].A;
            rdb2.Text = lstCauHoi[stt - 1].B;
            rdb3.Text = lstCauHoi[stt - 1].C;
            rdb4.Text = lstCauHoi[stt - 1].D;
            if (stt == 1)
            {
                btnQuayLai.Enabled = false;
            }
        }

        public void LuuBaiThi()
        {
            int j = 1;
            for (int i = 0; i < lstCauHoi.Count(); i++)
                
            {
                string phuongan;
                phuongan = " A= " + lstCauHoi[i].A + " B= " + lstCauHoi[i].B + " C= " + lstCauHoi[i].C + " D= " + lstCauHoi[i].D;
                Program.ExecSqlNonQuery("exec SP_LUUBAITHI '" + j + "','" + lstCauHoi[i].NOIDUNG + "','" + phuongan + "','" + lstCauHoi[i].DAPAN + "','" + lstCauHoi[i].DA_SV_CHON + "','" + Program.mlogin + "','" + Program.lanthi+ "','" + Program.mamonhoc+ "' ");
                j++;
            }
        }
        public void TinhDiemThi()
        {
            int dem = 0;
            for (int i = 0; i < lstCauHoi.Count(); i++)
            {
                if (lstCauHoi[i].DAPAN.Trim().ToString() == lstCauHoi[i].DA_SV_CHON.Trim().ToString())
                {
                    dem += 1;
                }
            }
            Program.diem = ((float)10 / (float)(lstCauHoi.Count()) * (float)dem);
            MessageBox.Show("Điểm thi của bạn là: " + Program.diem.ToString());
            //DateTime timeThi = DateTime.Now;

            if (Program.mGroup == "SINHVIEN")
            {
                Program.ExecSqlNonQuery("exec SP_LUUDIEM '" + Program.username + "','" + Program.mamonhoc + "','" + Program.lanthi + "','" + Program.ngaythi + "','" + Program.diem + "' ");
               
                    MessageBox.Show("Đã lưu điểm thi!");
                    return;
              
            }
        }

        private void btnTiep_Click(object sender, EventArgs e)
        {
            btnQuayLai.Enabled = true;
            stt = stt + 1;
            if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "")
            {
                rdb1.Checked = false;
                rdb2.Checked = false;
                rdb3.Checked = false;
                rdb4.Checked = false;
            }
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "A") rdb1.Checked = true;
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "B") rdb2.Checked = true;
            else if (lstCauHoi[stt - 1].DA_SV_CHON.Trim() == "C") rdb3.Checked = true;
            else rdb4.Checked = true;
            lblSoCauHT.Text = (stt).ToString() + "/" + lstCauHoi.Count();
            txtCauHoi.Text = lstCauHoi[stt - 1].NOIDUNG;
            rdb1.Text = lstCauHoi[stt - 1].A;
            rdb2.Text = lstCauHoi[stt - 1].B;
            rdb3.Text = lstCauHoi[stt - 1].C;
            rdb4.Text = lstCauHoi[stt - 1].D;
            if (stt == lstCauHoi.Count())
            {
                btnTiep.Enabled = false;
            }
        }

        private void rdb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb1.Checked) lstCauHoi[stt - 1].DA_SV_CHON = "A";
        }

        private void rdb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb2.Checked) lstCauHoi[stt - 1].DA_SV_CHON = "B";
        }

        private void rdb3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb3.Checked) lstCauHoi[stt - 1].DA_SV_CHON = "C";
        }

        private void rdb4_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb4.Checked) lstCauHoi[stt - 1].DA_SV_CHON = "D";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // 1 giay 
            timer1.Interval = 1000; 
            int giay = int.Parse(lblGiay.Text);
            int phut = int.Parse(lblPhut.Text);
            if (phut > 0) 
            {
                if (giay > 0)
                    giay--;
                else
                {
                    phut--;
                    giay = 59;
                }

            }
            else
            {
                if (giay > 0) giay--;
                if (giay == 0)
                {
                    lblGiay.Text = "00";
                    timer1.Stop();
                    MessageBox.Show("Hết thời gian làm bài!", "Thông báo", MessageBoxButtons.OK);
                    btnNopBai.PerformClick();
                }
            }
            this.lblGiay.Text = giay.ToString();
            this.lblPhut.Text = phut.ToString();
        }

        private void cOSOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cOSOBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB);

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
