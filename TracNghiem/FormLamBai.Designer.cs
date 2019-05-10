namespace TracNghiem
{
    partial class FormLamBai
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
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lbltenMH = new System.Windows.Forms.Label();
            this.lblSoCauThi = new System.Windows.Forms.Label();
            this.lblTgian = new System.Windows.Forms.Label();
            this.lblPhut = new System.Windows.Forms.Label();
            this.lblGiay = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnNopBai = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.lblSoCauHT = new System.Windows.Forms.Label();
            this.txtCauHoi = new System.Windows.Forms.TextBox();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dB = new TracNghiem.DB();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOSOTableAdapter = new TracNghiem.DBTableAdapters.COSOTableAdapter();
            this.tableAdapterManager = new TracNghiem.DBTableAdapters.TableAdapterManager();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.tRACNGHIEMDataSet = new TracNghiem.TRACNGHIEMDataSet();
            this.v_DS_PHANMANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new TracNghiem.TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager1 = new TracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayLai.Location = new System.Drawing.Point(45, 22);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(80, 34);
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Text = "Quay Lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.Location = new System.Drawing.Point(376, 65);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(85, 25);
            this.lblTenSV.TabIndex = 1;
            this.lblTenSV.Text = "TÊN SV";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(619, 65);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(76, 25);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "MÃ SV";
            // 
            // lbltenMH
            // 
            this.lbltenMH.AutoSize = true;
            this.lbltenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltenMH.Location = new System.Drawing.Point(874, 65);
            this.lbltenMH.Name = "lbltenMH";
            this.lbltenMH.Size = new System.Drawing.Size(88, 25);
            this.lbltenMH.TabIndex = 3;
            this.lbltenMH.Text = "TÊN MH";
            // 
            // lblSoCauThi
            // 
            this.lblSoCauThi.AutoSize = true;
            this.lblSoCauThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoCauThi.Location = new System.Drawing.Point(1225, 65);
            this.lblSoCauThi.Name = "lblSoCauThi";
            this.lblSoCauThi.Size = new System.Drawing.Size(90, 25);
            this.lblSoCauThi.TabIndex = 4;
            this.lblSoCauThi.Text = "SỐ CÂU";
            // 
            // lblTgian
            // 
            this.lblTgian.AutoSize = true;
            this.lblTgian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTgian.Location = new System.Drawing.Point(1462, 65);
            this.lblTgian.Name = "lblTgian";
            this.lblTgian.Size = new System.Drawing.Size(60, 25);
            this.lblTgian.TabIndex = 5;
            this.lblTgian.Text = "TIME";
            // 
            // lblPhut
            // 
            this.lblPhut.AutoSize = true;
            this.lblPhut.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhut.ForeColor = System.Drawing.Color.Orange;
            this.lblPhut.Location = new System.Drawing.Point(1731, 144);
            this.lblPhut.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPhut.Name = "lblPhut";
            this.lblPhut.Size = new System.Drawing.Size(78, 50);
            this.lblPhut.TabIndex = 7;
            this.lblPhut.Text = "PHUT";
            // 
            // lblGiay
            // 
            this.lblGiay.AutoSize = true;
            this.lblGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiay.ForeColor = System.Drawing.Color.Orange;
            this.lblGiay.Location = new System.Drawing.Point(1832, 144);
            this.lblGiay.Name = "lblGiay";
            this.lblGiay.Size = new System.Drawing.Size(121, 48);
            this.lblGiay.TabIndex = 8;
            this.lblGiay.Text = "GIAY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnNopBai
            // 
            this.btnNopBai.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNopBai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNopBai.ForeColor = System.Drawing.Color.Orange;
            this.btnNopBai.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNopBai.Location = new System.Drawing.Point(46, 23);
            this.btnNopBai.Name = "btnNopBai";
            this.btnNopBai.Size = new System.Drawing.Size(115, 76);
            this.btnNopBai.TabIndex = 9;
            this.btnNopBai.Text = "NỘP BÀI";
            this.btnNopBai.UseVisualStyleBackColor = false;
            this.btnNopBai.Click += new System.EventHandler(this.btnNopBai_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTiep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTiep.Location = new System.Drawing.Point(1471, 28);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(68, 35);
            this.btnTiep.TabIndex = 10;
            this.btnTiep.Text = "TIẾP";
            this.btnTiep.UseVisualStyleBackColor = false;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // lblSoCauHT
            // 
            this.lblSoCauHT.AutoSize = true;
            this.lblSoCauHT.Location = new System.Drawing.Point(747, 31);
            this.lblSoCauHT.Name = "lblSoCauHT";
            this.lblSoCauHT.Size = new System.Drawing.Size(67, 17);
            this.lblSoCauHT.TabIndex = 11;
            this.lblSoCauHT.Text = "STT CÂU";
            // 
            // txtCauHoi
            // 
            this.txtCauHoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHoi.Location = new System.Drawing.Point(131, 83);
            this.txtCauHoi.Multiline = true;
            this.txtCauHoi.Name = "txtCauHoi";
            this.txtCauHoi.Size = new System.Drawing.Size(1345, 118);
            this.txtCauHoi.TabIndex = 12;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb1.Location = new System.Drawing.Point(198, 247);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(143, 29);
            this.rdb1.TabIndex = 13;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "radioButton1";
            this.rdb1.UseVisualStyleBackColor = true;
            this.rdb1.CheckedChanged += new System.EventHandler(this.rdb1_CheckedChanged);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb2.Location = new System.Drawing.Point(198, 331);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(143, 29);
            this.rdb2.TabIndex = 14;
            this.rdb2.TabStop = true;
            this.rdb2.Text = "radioButton2";
            this.rdb2.UseVisualStyleBackColor = true;
            this.rdb2.CheckedChanged += new System.EventHandler(this.rdb2_CheckedChanged);
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb3.Location = new System.Drawing.Point(198, 408);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(143, 29);
            this.rdb3.TabIndex = 15;
            this.rdb3.TabStop = true;
            this.rdb3.Text = "radioButton3";
            this.rdb3.UseVisualStyleBackColor = true;
            this.rdb3.CheckedChanged += new System.EventHandler(this.rdb3_CheckedChanged);
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb4.Location = new System.Drawing.Point(198, 497);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(143, 29);
            this.rdb4.TabIndex = 16;
            this.rdb4.TabStop = true;
            this.rdb4.Text = "radioButton4";
            this.rdb4.UseVisualStyleBackColor = true;
            this.rdb4.CheckedChanged += new System.EventHandler(this.rdb4_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "TÊN SV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "MÃ SV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(874, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "TÊN MH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1211, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "SỐ CÂU THI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1444, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "THỜI GIAN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblTenSV);
            this.panel1.Controls.Add(this.btnNopBai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblMaSV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbltenMH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblSoCauThi);
            this.panel1.Controls.Add(this.lblTgian);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1953, 127);
            this.panel1.TabIndex = 23;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.rdb1);
            this.groupBox1.Controls.Add(this.rdb2);
            this.groupBox1.Controls.Add(this.rdb3);
            this.groupBox1.Controls.Add(this.btnTiep);
            this.groupBox1.Controls.Add(this.txtCauHoi);
            this.groupBox1.Controls.Add(this.rdb4);
            this.groupBox1.Controls.Add(this.btnQuayLai);
            this.groupBox1.Controls.Add(this.lblSoCauHT);
            this.groupBox1.Location = new System.Drawing.Point(194, 197);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1587, 619);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(673, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "CÂU HỎI:";
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.dB;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAITHITableAdapter = null;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = this.cOSOTableAdapter;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cOSOBindingSource, "MACS", true));
            this.cmbCoSo.DataSource = this.cOSOBindingSource;
            this.cmbCoSo.DisplayMember = "MACS";
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(79, 951);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(44, 24);
            this.cmbCoSo.TabIndex = 26;
            this.cmbCoSo.ValueMember = "MACS";
            // 
            // tRACNGHIEMDataSet
            // 
            this.tRACNGHIEMDataSet.DataSetName = "TRACNGHIEMDataSet";
            this.tRACNGHIEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DS_PHANMANHBindingSource
            // 
            this.v_DS_PHANMANHBindingSource.DataMember = "V_DS_PHANMANH";
            this.v_DS_PHANMANHBindingSource.DataSource = this.tRACNGHIEMDataSet;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = TracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(46, 884);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(115, 24);
            this.cmbCN.TabIndex = 26;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // FormLamBai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1920, 1051);
            this.Controls.Add(this.cmbCN);
            this.Controls.Add(this.cmbCoSo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGiay);
            this.Controls.Add(this.lblPhut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormLamBai";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormThi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRACNGHIEMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DS_PHANMANHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Label lbltenMH;
        private System.Windows.Forms.Label lblSoCauThi;
        private System.Windows.Forms.Label lblTgian;
        private System.Windows.Forms.Label lblPhut;
        private System.Windows.Forms.Label lblGiay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnNopBai;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Label lblSoCauHT;
        private System.Windows.Forms.TextBox txtCauHoi;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private DB dB;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private DBTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCoSo;
        private TRACNGHIEMDataSet tRACNGHIEMDataSet;
        private System.Windows.Forms.BindingSource v_DS_PHANMANHBindingSource;
        private TRACNGHIEMDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox cmbCN;
    }
}