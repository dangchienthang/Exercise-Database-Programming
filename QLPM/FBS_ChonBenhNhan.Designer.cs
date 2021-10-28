
namespace QLPM
{
    partial class FBS_ChonBenhNhan
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
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.txtMaLK = new System.Windows.Forms.TextBox();
            this.btKham = new System.Windows.Forms.Button();
            this.gVLK = new System.Windows.Forms.DataGridView();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaYT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVLK)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(73, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã lịch khám:";
            // 
            // txtMaLK
            // 
            this.txtMaLK.Enabled = false;
            this.txtMaLK.Location = new System.Drawing.Point(146, 43);
            this.txtMaLK.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLK.Name = "txtMaLK";
            this.txtMaLK.Size = new System.Drawing.Size(237, 20);
            this.txtMaLK.TabIndex = 1;
            // 
            // btKham
            // 
            this.btKham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btKham.Image = global::QLPM.Properties.Resources.Start_icon;
            this.btKham.Location = new System.Drawing.Point(750, 191);
            this.btKham.Name = "btKham";
            this.btKham.Size = new System.Drawing.Size(117, 58);
            this.btKham.TabIndex = 6;
            this.btKham.Text = "Bắt đầu khám";
            this.btKham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btKham.UseVisualStyleBackColor = true;
            this.btKham.Click += new System.EventHandler(this.btKham_Click);
            // 
            // gVLK
            // 
            this.gVLK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVLK.Location = new System.Drawing.Point(32, 267);
            this.gVLK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVLK.Name = "gVLK";
            this.gVLK.RowHeadersWidth = 62;
            this.gVLK.RowTemplate.Height = 28;
            this.gVLK.Size = new System.Drawing.Size(835, 270);
            this.gVLK.TabIndex = 7;
            this.gVLK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVLK_CellClick);
            // 
            // dtpNgayHen
            // 
            this.dtpNgayHen.CustomFormat = "";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHen.Location = new System.Drawing.Point(146, 191);
            this.dtpNgayHen.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayHen.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayHen.MinDate = new System.DateTime(2003, 1, 1, 0, 0, 0, 0);
            this.dtpNgayHen.Name = "dtpNgayHen";
            this.dtpNgayHen.Size = new System.Drawing.Size(237, 20);
            this.dtpNgayHen.TabIndex = 5;
            this.dtpNgayHen.Value = new System.DateTime(2021, 9, 14, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ngày hẹn:";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Location = new System.Drawing.Point(29, 82);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(79, 13);
            this.label123.TabIndex = 25;
            this.label123.Text = "Mã bệnh nhân:";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Location = new System.Drawing.Point(146, 79);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(237, 20);
            this.txtMaBN.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mã y tá:";
            // 
            // txtMaYT
            // 
            this.txtMaYT.Enabled = false;
            this.txtMaYT.Location = new System.Drawing.Point(146, 114);
            this.txtMaYT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaYT.Name = "txtMaYT";
            this.txtMaYT.Size = new System.Drawing.Size(237, 20);
            this.txtMaYT.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mã bác sĩ:";
            // 
            // txtMaBS
            // 
            this.txtMaBS.Enabled = false;
            this.txtMaBS.Location = new System.Drawing.Point(146, 152);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(237, 20);
            this.txtMaBS.TabIndex = 4;
            // 
            // FBS_ChonBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaYT);
            this.Controls.Add(this.label123);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btKham);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVLK);
            this.Controls.Add(this.txtMaLK);
            this.Name = "FBS_ChonBenhNhan";
            this.Text = "LỊCH KHÁM";
            this.Load += new System.EventHandler(this.FChonBenhNhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaLK;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Button btKham;
        private System.Windows.Forms.DataGridView gVLK;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label123;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaYT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaBS;
    }
}