using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class rpt_XemKetQua : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_XemKetQua(String MASV,String MAMH,int LAN)
        {
            InitializeComponent();
            this.sP_KETQUATableAdapter1.Connection.ConnectionString = Program.connstr;

            db1.EnforceConstraints = false;
            this.sP_KETQUATableAdapter1.Fill(db1.SP_KETQUA, MASV,MAMH,LAN);
        }

    }
}
