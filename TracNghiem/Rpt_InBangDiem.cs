using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class Rpt_InBangDiem : DevExpress.XtraReports.UI.XtraReport
    {
        public Rpt_InBangDiem(string MALOP, string MAMH, int LANTHI )
        {
            InitializeComponent();
            this.sP_IN_BANGDIEMTableAdapter3.Connection.ConnectionString = Program.connstr;
            db1.EnforceConstraints = false;
            this.sP_IN_BANGDIEMTableAdapter3.Fill(db1.SP_IN_BANGDIEM, MALOP,MAMH,LANTHI);
        }

    }
}
