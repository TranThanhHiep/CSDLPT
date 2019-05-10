namespace TracNghiem
{
    partial class FormThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.dB = new TracNghiem.DB();
            this.gIAOVIEN_DANGKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gIAOVIEN_DANGKYTableAdapter = new TracNghiem.DBTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TracNghiem.DBTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new TracNghiem.DBTableAdapters.MONHOCTableAdapter();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMALOP = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnLayThongTin = new System.Windows.Forms.Button();
            this.btnBatDauThi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cmbMaMH = new System.Windows.Forms.ComboBox();
            this.cmbLan = new System.Windows.Forms.ComboBox();
            this.cmbNgayThi = new System.Windows.Forms.ComboBox();
            this.lblTenLop = new System.Windows.Forms.Label();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblHoTenGV = new System.Windows.Forms.Label();
            this.lblSoCauThi = new System.Windows.Forms.Label();
            this.lblThoiGianThi = new System.Windows.Forms.Label();
            this.lblTrinhDo = new System.Windows.Forms.Label();
            this.gbThi = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bangdiemTableAdapter1 = new TracNghiem.DBTableAdapters.BANGDIEMTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            mAMHLabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.gbThi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(106, 56);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(74, 17);
            mAMHLabel.TabIndex = 5;
            mAMHLabel.Text = "MÔN HỌC";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(119, 194);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(61, 17);
            lANLabel.TabIndex = 6;
            lANLabel.Text = "LẦN THI";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(107, 122);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(73, 17);
            mALOPLabel.TabIndex = 8;
            mALOPLabel.Text = "NGÀY THI";
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gIAOVIEN_DANGKYBindingSource
            // 
            this.gIAOVIEN_DANGKYBindingSource.DataMember = "GIAOVIEN_DANGKY";
            this.gIAOVIEN_DANGKYBindingSource.DataSource = this.dB;
            // 
            // gIAOVIEN_DANGKYTableAdapter
            // 
            this.gIAOVIEN_DANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.gIAOVIEN_DANGKYTableAdapter;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dB;
            // 
            // gbThongTin
            // 
            this.gbThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbThongTin.Controls.Add(this.label11);
            this.gbThongTin.Controls.Add(this.label10);
            this.gbThongTin.Controls.Add(this.label9);
            this.gbThongTin.Controls.Add(this.label8);
            this.gbThongTin.Controls.Add(this.lblTenSV);
            this.gbThongTin.Controls.Add(this.lblMALOP);
            this.gbThongTin.Controls.Add(this.lblLop);
            this.gbThongTin.Controls.Add(this.lblMaSV);
            this.gbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTin.Location = new System.Drawing.Point(0, 0);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1578, 155);
            this.gbThongTin.TabIndex = 2;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông Tin Sinh Viên";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(652, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "MÃ SV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(975, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "TÊN SV:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(652, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "MÃ LỚP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(986, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "LỚP:";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Location = new System.Drawing.Point(1048, 43);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(58, 17);
            this.lblTenSV.TabIndex = 3;
            this.lblTenSV.Text = "TÊN SV";
            // 
            // lblMALOP
            // 
            this.lblMALOP.AutoSize = true;
            this.lblMALOP.Location = new System.Drawing.Point(1048, 100);
            this.lblMALOP.Name = "lblMALOP";
            this.lblMALOP.Size = new System.Drawing.Size(36, 17);
            this.lblMALOP.TabIndex = 2;
            this.lblMALOP.Text = "LỚP";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(725, 100);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(60, 17);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "MÃ LỚP";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Location = new System.Drawing.Point(725, 43);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(54, 17);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "MÃ SV ";
            // 
            // btnLayThongTin
            // 
            this.btnLayThongTin.BackColor = System.Drawing.Color.SlateGray;
            this.btnLayThongTin.ForeColor = System.Drawing.Color.White;
            this.btnLayThongTin.Location = new System.Drawing.Point(90, 257);
            this.btnLayThongTin.Name = "btnLayThongTin";
            this.btnLayThongTin.Size = new System.Drawing.Size(175, 56);
            this.btnLayThongTin.TabIndex = 3;
            this.btnLayThongTin.Text = "LẤY THÔNG TIN";
            this.btnLayThongTin.UseVisualStyleBackColor = false;
            this.btnLayThongTin.Click += new System.EventHandler(this.btnLayThongTin_Click);
            // 
            // btnBatDauThi
            // 
            this.btnBatDauThi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBatDauThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatDauThi.ForeColor = System.Drawing.Color.White;
            this.btnBatDauThi.Location = new System.Drawing.Point(807, 707);
            this.btnBatDauThi.Name = "btnBatDauThi";
            this.btnBatDauThi.Size = new System.Drawing.Size(230, 81);
            this.btnBatDauThi.TabIndex = 4;
            this.btnBatDauThi.Text = "BẮT ĐẦU THI";
            this.btnBatDauThi.UseVisualStyleBackColor = false;
            this.btnBatDauThi.Click += new System.EventHandler(this.btnBatDauThi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SlateGray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(298, 257);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(168, 56);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cmbMaMH
            // 
            this.cmbMaMH.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.cmbMaMH.DisplayMember = "MAMH";
            this.cmbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaMH.FormattingEnabled = true;
            this.cmbMaMH.Location = new System.Drawing.Point(217, 53);
            this.cmbMaMH.Name = "cmbMaMH";
            this.cmbMaMH.Size = new System.Drawing.Size(191, 24);
            this.cmbMaMH.TabIndex = 6;
            this.cmbMaMH.ValueMember = "MAMH";
            // 
            // cmbLan
            // 
            this.cmbLan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gIAOVIEN_DANGKYBindingSource, "LAN", true));
            this.cmbLan.FormattingEnabled = true;
            this.cmbLan.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLan.Location = new System.Drawing.Point(214, 191);
            this.cmbLan.Name = "cmbLan";
            this.cmbLan.Size = new System.Drawing.Size(194, 24);
            this.cmbLan.TabIndex = 7;
            // 
            // cmbNgayThi
            // 
            this.cmbNgayThi.DataSource = this.gIAOVIEN_DANGKYBindingSource;
            this.cmbNgayThi.DisplayMember = "NGAYTHI";
            this.cmbNgayThi.FormattingEnabled = true;
            this.cmbNgayThi.Location = new System.Drawing.Point(217, 119);
            this.cmbNgayThi.Name = "cmbNgayThi";
            this.cmbNgayThi.Size = new System.Drawing.Size(191, 24);
            this.cmbNgayThi.TabIndex = 9;
            this.cmbNgayThi.ValueMember = "NGAYTHI";
            // 
            // lblTenLop
            // 
            this.lblTenLop.AutoSize = true;
            this.lblTenLop.Location = new System.Drawing.Point(157, 98);
            this.lblTenLop.Name = "lblTenLop";
            this.lblTenLop.Size = new System.Drawing.Size(46, 17);
            this.lblTenLop.TabIndex = 10;
            this.lblTenLop.Text = "label1";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Location = new System.Drawing.Point(313, 98);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(46, 17);
            this.lblTenMH.TabIndex = 11;
            this.lblTenMH.Text = "label2";
            // 
            // lblHoTenGV
            // 
            this.lblHoTenGV.AutoSize = true;
            this.lblHoTenGV.Location = new System.Drawing.Point(491, 98);
            this.lblHoTenGV.Name = "lblHoTenGV";
            this.lblHoTenGV.Size = new System.Drawing.Size(46, 17);
            this.lblHoTenGV.TabIndex = 12;
            this.lblHoTenGV.Text = "label3";
            // 
            // lblSoCauThi
            // 
            this.lblSoCauThi.AutoSize = true;
            this.lblSoCauThi.Location = new System.Drawing.Point(662, 98);
            this.lblSoCauThi.Name = "lblSoCauThi";
            this.lblSoCauThi.Size = new System.Drawing.Size(46, 17);
            this.lblSoCauThi.TabIndex = 13;
            this.lblSoCauThi.Text = "label4";
            // 
            // lblThoiGianThi
            // 
            this.lblThoiGianThi.AutoSize = true;
            this.lblThoiGianThi.Location = new System.Drawing.Point(842, 98);
            this.lblThoiGianThi.Name = "lblThoiGianThi";
            this.lblThoiGianThi.Size = new System.Drawing.Size(46, 17);
            this.lblThoiGianThi.TabIndex = 14;
            this.lblThoiGianThi.Text = "label5";
            // 
            // lblTrinhDo
            // 
            this.lblTrinhDo.AutoSize = true;
            this.lblTrinhDo.Location = new System.Drawing.Point(975, 98);
            this.lblTrinhDo.Name = "lblTrinhDo";
            this.lblTrinhDo.Size = new System.Drawing.Size(46, 17);
            this.lblTrinhDo.TabIndex = 15;
            this.lblTrinhDo.Text = "label1";
            // 
            // gbThi
            // 
            this.gbThi.Controls.Add(this.label7);
            this.gbThi.Controls.Add(this.label6);
            this.gbThi.Controls.Add(this.label5);
            this.gbThi.Controls.Add(this.label4);
            this.gbThi.Controls.Add(this.label3);
            this.gbThi.Controls.Add(this.label2);
            this.gbThi.Controls.Add(this.lblTenLop);
            this.gbThi.Controls.Add(this.lblTenMH);
            this.gbThi.Controls.Add(this.lblTrinhDo);
            this.gbThi.Controls.Add(this.lblHoTenGV);
            this.gbThi.Controls.Add(this.lblThoiGianThi);
            this.gbThi.Controls.Add(this.lblSoCauThi);
            this.gbThi.Location = new System.Drawing.Point(281, 546);
            this.gbThi.Name = "gbThi";
            this.gbThi.Size = new System.Drawing.Size(1211, 143);
            this.gbThi.TabIndex = 17;
            this.gbThi.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(961, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "TRÌNH ĐỘ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(842, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "TIME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "SỐ CÂU THI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "TÊN GIÁO VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "TÊN MÔN HỌC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "TÊN LỚP";
            // 
            // bangdiemTableAdapter1
            // 
            this.bangdiemTableAdapter1.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.cmbMaMH);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(mALOPLabel);
            this.groupBox1.Controls.Add(this.cmbLan);
            this.groupBox1.Controls.Add(this.btnLayThongTin);
            this.groupBox1.Controls.Add(this.cmbNgayThi);
            this.groupBox1.Controls.Add(lANLabel);
            this.groupBox1.Location = new System.Drawing.Point(618, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 342);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // FormThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 877);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbThi);
            this.Controls.Add(this.btnBatDauThi);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormThi";
            this.Text = "THI ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormChuanBiThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gIAOVIEN_DANGKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbThi.ResumeLayout(false);
            this.gbThi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DB dB;
        private System.Windows.Forms.BindingSource gIAOVIEN_DANGKYBindingSource;
        private DBTableAdapters.GIAOVIEN_DANGKYTableAdapter gIAOVIEN_DANGKYTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private DBTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lblMALOP;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Button btnLayThongTin;
        private System.Windows.Forms.Button btnBatDauThi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbMaMH;
        private System.Windows.Forms.ComboBox cmbLan;
        private System.Windows.Forms.ComboBox cmbNgayThi;
        private System.Windows.Forms.Label lblTenLop;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblHoTenGV;
        private System.Windows.Forms.Label lblSoCauThi;
        private System.Windows.Forms.Label lblThoiGianThi;
        private System.Windows.Forms.Label lblTrinhDo;
        private System.Windows.Forms.GroupBox gbThi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private DBTableAdapters.BANGDIEMTableAdapter bangdiemTableAdapter1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}