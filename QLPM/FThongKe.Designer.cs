
namespace QLPM
{
    partial class FThongKe
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
            this.label2 = new System.Windows.Forms.Label();
            this.gVPK = new System.Windows.Forms.DataGridView();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.dtpMocBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpMocKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVPK)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(68, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mốc bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mốc kết thúc:";
            // 
            // gVPK
            // 
            this.gVPK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVPK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVPK.Location = new System.Drawing.Point(32, 267);
            this.gVPK.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVPK.Name = "gVPK";
            this.gVPK.RowHeadersWidth = 62;
            this.gVPK.RowTemplate.Height = 28;
            this.gVPK.Size = new System.Drawing.Size(835, 270);
            this.gVPK.TabIndex = 7;
            // 
            // btTimKiem
            // 
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Image = global::QLPM.Properties.Resources.Start_Menu_Search_icon;
            this.btTimKiem.Location = new System.Drawing.Point(670, 187);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(91, 58);
            this.btTimKiem.TabIndex = 52;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // dtpMocBatDau
            // 
            this.dtpMocBatDau.CustomFormat = "";
            this.dtpMocBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMocBatDau.Location = new System.Drawing.Point(144, 40);
            this.dtpMocBatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMocBatDau.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpMocBatDau.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpMocBatDau.Name = "dtpMocBatDau";
            this.dtpMocBatDau.Size = new System.Drawing.Size(237, 20);
            this.dtpMocBatDau.TabIndex = 53;
            this.dtpMocBatDau.Value = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            // 
            // dtpMocKetThuc
            // 
            this.dtpMocKetThuc.CustomFormat = "";
            this.dtpMocKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMocKetThuc.Location = new System.Drawing.Point(630, 40);
            this.dtpMocKetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpMocKetThuc.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpMocKetThuc.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpMocKetThuc.Name = "dtpMocKetThuc";
            this.dtpMocKetThuc.Size = new System.Drawing.Size(237, 20);
            this.dtpMocKetThuc.TabIndex = 54;
            this.dtpMocKetThuc.Value = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            // 
            // btThongKe
            // 
            this.btThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKe.Image = global::QLPM.Properties.Resources.list_icon;
            this.btThongKe.Location = new System.Drawing.Point(781, 187);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(86, 58);
            this.btThongKe.TabIndex = 55;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // FThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.dtpMocKetThuc);
            this.Controls.Add(this.dtpMocBatDau);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVPK);
            this.Controls.Add(this.label2);
            this.Name = "FThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVPK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.DataGridView gVPK;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.DateTimePicker dtpMocBatDau;
        private System.Windows.Forms.DateTimePicker dtpMocKetThuc;
        private System.Windows.Forms.Button btThongKe;
    }
}