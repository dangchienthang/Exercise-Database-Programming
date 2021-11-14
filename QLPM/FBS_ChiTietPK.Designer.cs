
namespace QLPM
{
    partial class FChiTietPK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChiTietPK));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gVCTPK = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtYC = new System.Windows.Forms.TextBox();
            this.dtpNgayXN = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaPK = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThemCT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVCTPK)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.gVCTPK);
            this.groupBox6.Location = new System.Drawing.Point(284, 374);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(876, 274);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách:";
            // 
            // gVCTPK
            // 
            this.gVCTPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVCTPK.Location = new System.Drawing.Point(29, 17);
            this.gVCTPK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVCTPK.Name = "gVCTPK";
            this.gVCTPK.RowHeadersWidth = 62;
            this.gVCTPK.RowTemplate.Height = 28;
            this.gVCTPK.Size = new System.Drawing.Size(823, 240);
            this.gVCTPK.TabIndex = 10;
            this.gVCTPK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVCTPK_CellClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.txtMaXN);
            this.groupBox8.Controls.Add(this.dtpNgayHen);
            this.groupBox8.Controls.Add(this.txtKQ);
            this.groupBox8.Controls.Add(this.txtYC);
            this.groupBox8.Controls.Add(this.dtpNgayXN);
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label15);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.txtMaPK);
            this.groupBox8.Location = new System.Drawing.Point(284, 113);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(876, 162);
            this.groupBox8.TabIndex = 21;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã xét nghiệm:";
            // 
            // txtMaXN
            // 
            this.txtMaXN.Enabled = false;
            this.txtMaXN.Location = new System.Drawing.Point(125, 61);
            this.txtMaXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Size = new System.Drawing.Size(230, 20);
            this.txtMaXN.TabIndex = 2;
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.CustomFormat = "";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHen.Location = new System.Drawing.Point(614, 134);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayHen.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHen.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(238, 20);
            this.dtpNgayHen.TabIndex = 6;
            this.dtpNgayHen.Value = new System.DateTime(2021, 10, 7, 0, 0, 0, 0);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(614, 98);
            this.txtKQ.Margin = new System.Windows.Forms.Padding(2);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(237, 20);
            this.txtKQ.TabIndex = 5;
            // 
            // txtYC
            // 
            this.txtYC.Location = new System.Drawing.Point(614, 61);
            this.txtYC.Margin = new System.Windows.Forms.Padding(2);
            this.txtYC.Name = "txtYC";
            this.txtYC.Size = new System.Drawing.Size(237, 20);
            this.txtYC.TabIndex = 4;
            // 
            // dtpNgayXN
            // 
            this.dtpNgayXN.CustomFormat = "";
            this.dtpNgayXN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXN.Location = new System.Drawing.Point(614, 21);
            this.dtpNgayXN.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayXN.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayXN.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgayXN.Name = "dtpNgayXN";
            this.dtpNgayXN.Size = new System.Drawing.Size(238, 20);
            this.dtpNgayXN.TabIndex = 3;
            this.dtpNgayXN.Value = new System.DateTime(2021, 10, 7, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ngày xét nghiệm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(480, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Yêu cầu xét nghiệm:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Mã phiếu khám:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(480, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Ngày hẹn lấy kết quả:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(480, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Kết quả xét nghiệm:";
            // 
            // txtMaPK
            // 
            this.txtMaPK.Enabled = false;
            this.txtMaPK.Location = new System.Drawing.Point(125, 24);
            this.txtMaPK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaPK.Name = "txtMaPK";
            this.txtMaPK.Size = new System.Drawing.Size(230, 20);
            this.txtMaPK.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 23);
            this.label17.TabIndex = 24;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.Control;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSua.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSua.Location = new System.Drawing.Point(941, 293);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(88, 58);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoa.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoa.Location = new System.Drawing.Point(1053, 293);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(83, 58);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThemCT
            // 
            this.btThemCT.BackColor = System.Drawing.SystemColors.Control;
            this.btThemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemCT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThemCT.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemCT.Location = new System.Drawing.Point(822, 293);
            this.btThemCT.Name = "btThemCT";
            this.btThemCT.Size = new System.Drawing.Size(92, 58);
            this.btThemCT.TabIndex = 7;
            this.btThemCT.Text = "Thêm chi tiết";
            this.btThemCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemCT.UseVisualStyleBackColor = false;
            this.btThemCT.Click += new System.EventHandler(this.btThemCT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 661);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 93);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.panel4.Location = new System.Drawing.Point(170, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1064, 93);
            this.panel4.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(448, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "CHI TIẾT PHIẾU KHÁM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 39;
            this.label1.Text = "Datha";
            // 
            // FChiTietPK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 661);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThemCT);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.label17);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FChiTietPK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết phiếu khám";
            this.Activated += new System.EventHandler(this.FChiTietPK_Activated);
            this.Load += new System.EventHandler(this.FChiTietPK_Load);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVCTPK)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView gVCTPK;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaPK;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayXN;
        private System.Windows.Forms.TextBox txtYC;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThemCT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}