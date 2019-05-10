using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TracNghiem
{
    public partial class rpt_InBaoCao : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_InBaoCao(DateTime TUNGAY, DateTime DENNGAY,String MACS)
        {
            InitializeComponent();
            this.sP_BAOCAO_DANGKITHITableAdapter1.Connection.ConnectionString = Program.connstr;
            
            db1.EnforceConstraints = false;
            this.sP_BAOCAO_DANGKITHITableAdapter1.Fill(db1.SP_BAOCAO_DANGKITHI, TUNGAY, DENNGAY, MACS);
        }

    }
}
