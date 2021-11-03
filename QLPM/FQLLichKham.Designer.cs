
namespace QLPM
{
    partial class FQLLichKham
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
            this.btThemLich = new System.Windows.Forms.Button();
            this.btSuaLich = new System.Windows.Forms.Button();
            this.btXoaLich = new System.Windows.Forms.Button();
            this.gVLK = new System.Windows.Forms.DataGridView();
            this.cbBN = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btThongKe = new System.Windows.Forms.Button();
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
            // btThemLich
            // 
            this.btThemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemLich.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemLich.Location = new System.Drawing.Point(515, 154);
            this.btThemLich.Name = "btThemLich";
            this.btThemLich.Size = new System.Drawing.Size(98, 58);
            this.btThemLich.TabIndex = 6;
            this.btThemLich.Text = "Thêm lịch";
            this.btThemLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemLich.UseVisualStyleBackColor = true;
            this.btThemLich.Click += new System.EventHandler(this.btThemLich_Click);
            // 
            // btSuaLich
            // 
            this.btSuaLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaLich.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaLich.Location = new System.Drawing.Point(700, 154);
            this.btSuaLich.Name = "btSuaLich";
            this.btSuaLich.Size = new System.Drawing.Size(75, 58);
            this.btSuaLich.TabIndex = 8;
            this.btSuaLich.Text = "Sửa";
            this.btSuaLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaLich.UseVisualStyleBackColor = true;
            this.btSuaLich.Click += new System.EventHandler(this.btSuaLich_Click);
            // 
            // btXoaLich
            // 
            this.btXoaLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaLich.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaLich.Location = new System.Drawing.Point(619, 154);
            this.btXoaLich.Name = "btXoaLich";
            this.btXoaLich.Size = new System.Drawing.Size(75, 58);
            this.btXoaLich.TabIndex = 7;
            this.btXoaLich.Text = "Xóa";
            this.btXoaLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaLich.UseVisualStyleBackColor = true;
            this.btXoaLich.Click += new System.EventHandler(this.btXoaLich_Click);
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
            this.gVLK.TabIndex = 10;
            // 
            // cbBN
            // 
            this.cbBN.FormattingEnabled = true;
            this.cbBN.Location = new System.Drawing.Point(146, 77);
            this.cbBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbBN.Name = "cbBN";
            this.cbBN.Size = new System.Drawing.Size(237, 21);
            this.cbBN.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tên bệnh nhân:";
            // 
            // cbYT
            // 
            this.cbYT.FormattingEnabled = true;
            this.cbYT.Location = new System.Drawing.Point(146, 113);
            this.cbYT.Margin = new System.Windows.Forms.Padding(2);
            this.cbYT.Name = "cbYT";
            this.cbYT.Size = new System.Drawing.Size(237, 21);
            this.cbYT.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên y tá:";
            // 
            // cbBS
            // 
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(146, 151);
            this.cbBS.Margin = new System.Windows.Forms.Padding(2);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(237, 21);
            this.cbBS.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tên bác sĩ chỉ định:";
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
            // btThongKe
            // 
            this.btThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKe.Image = global::QLPM.Properties.Resources.list_icon;
            this.btThongKe.Location = new System.Drawing.Point(781, 154);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(86, 58);
            this.btThongKe.TabIndex = 9;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // FQLLichKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.cbYT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btSuaLich);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVLK);
            this.Controls.Add(this.btXoaLich);
            this.Controls.Add(this.btThemLich);
            this.Controls.Add(this.txtMaLK);
            this.Name = "FQLLichKham";
            this.Text = "QUẢN LÝ LỊCH KHÁM";
            this.Load += new System.EventHandler(this.FQLLichKham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaLK;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Button btThemLich;
        private System.Windows.Forms.Button btSuaLich;
        private System.Windows.Forms.Button btXoaLich;
        private System.Windows.Forms.DataGridView gVLK;
        private System.Windows.Forms.ComboBox cbBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbYT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btThongKe;
    }
}