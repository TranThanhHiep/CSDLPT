namespace TracNghiem
{
    partial class FormBaoCao
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
            System.Windows.Forms.Label tENCNLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCoSo = new System.Windows.Forms.ComboBox();
            this.lAYCOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coso = new TracNghiem.coso();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dB = new TracNghiem.DB();
            this.tableAdapterManager = new TracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager();
            this.cOSOTableAdapter = new TracNghiem.DBTableAdapters.COSOTableAdapter();
            this.tableAdapterManager1 = new TracNghiem.cosoTableAdapters.TableAdapterManager();
            this.tableAdapterManager2 = new TracNghiem.DBTableAdapters.TableAdapterManager();
            this.cOSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lAYCOSOTableAdapter = new TracNghiem.cosoTableAdapters.lAYCOSOTableAdapter();
            tENCNLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lAYCOSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tENCNLabel
            // 
            tENCNLabel.AutoSize = true;
            tENCNLabel.Location = new System.Drawing.Point(101, 126);
            tENCNLabel.Name = "tENCNLabel";
            tENCNLabel.Size = new System.Drawing.Size(113, 25);
            tENCNLabel.TabIndex = 5;
            tENCNLabel.Text = "Tên Cơ Sở ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCoSo);
            this.groupBox1.Controls.Add(this.cmbCN);
            this.groupBox1.Controls.Add(tENCNLabel);
            this.groupBox1.Controls.Add(this.btnInBaoCao);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(521, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BÁO CÁO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbCoSo
            // 
            this.cmbCoSo.DataSource = this.lAYCOSOBindingSource;
            this.cmbCoSo.DisplayMember = "MACS";
            this.cmbCoSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCoSo.FormattingEnabled = true;
            this.cmbCoSo.Location = new System.Drawing.Point(248, 123);
            this.cmbCoSo.Name = "cmbCoSo";
            this.cmbCoSo.Size = new System.Drawing.Size(362, 33);
            this.cmbCoSo.TabIndex = 8;
            this.cmbCoSo.ValueMember = "MACS";
            // 
            // lAYCOSOBindingSource
            // 
            this.lAYCOSOBindingSource.DataMember = "lAYCOSO";
            this.lAYCOSOBindingSource.DataSource = this.coso;
            // 
            // coso
            // 
            this.coso.DataSetName = "coso";
            this.coso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCN
            // 
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(248, 123);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(300, 33);
            this.cmbCN.TabIndex = 8;
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnInBaoCao.Location = new System.Drawing.Point(248, 346);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(255, 72);
            this.btnInBaoCao.TabIndex = 4;
            this.btnInBaoCao.Text = "IN BÁO CÁO";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(248, 238);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(362, 30);
            this.dateTo.TabIndex = 3;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(248, 177);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(362, 30);
            this.dateFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ Ngày";
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = TracNghiem.TRACNGHIEMDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cOSOTableAdapter
            // 
            this.cOSOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = TracNghiem.cosoTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.BAITHITableAdapter = null;
            this.tableAdapterManager2.BANGDIEMTableAdapter = null;
            this.tableAdapterManager2.BODETableAdapter = null;
            this.tableAdapterManager2.COSOTableAdapter = this.cOSOTableAdapter;
            this.tableAdapterManager2.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager2.GIAOVIENTableAdapter = null;
            this.tableAdapterManager2.KHOATableAdapter = null;
            this.tableAdapterManager2.LOPTableAdapter = null;
            this.tableAdapterManager2.MONHOCTableAdapter = null;
            this.tableAdapterManager2.SINHVIENTableAdapter = null;
            this.tableAdapterManager2.UpdateOrder = TracNghiem.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cOSOBindingSource
            // 
            this.cOSOBindingSource.DataMember = "COSO";
            this.cOSOBindingSource.DataSource = this.dB;
            // 
            // lAYCOSOTableAdapter
            // 
            this.lAYCOSOTableAdapter.ClearBeforeFill = true;
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 877);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBaoCao";
            this.Text = "BÁO CÁO ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lAYCOSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOSOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TRACNGHIEMDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB dB;
        private DBTableAdapters.COSOTableAdapter cOSOTableAdapter;
        private coso coso;
        private cosoTableAdapters.TableAdapterManager tableAdapterManager1;
        private DBTableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.BindingSource cOSOBindingSource;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.BindingSource lAYCOSOBindingSource;
        private cosoTableAdapters.lAYCOSOTableAdapter lAYCOSOTableAdapter;
        private System.Windows.Forms.ComboBox cmbCoSo;
    }
}