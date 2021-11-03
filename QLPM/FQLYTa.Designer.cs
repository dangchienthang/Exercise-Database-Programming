
namespace QLPM
{
    partial class FQLYTa
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
            this.txtMaLNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtMaYT = new System.Windows.Forms.TextBox();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenYT = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemYT = new System.Windows.Forms.Button();
            this.btSuaYT = new System.Windows.Forms.Button();
            this.btXoaYT = new System.Windows.Forms.Button();
            this.gVYT = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVYT)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMaLNV
            // 
            this.txtMaLNV.Enabled = false;
            this.txtMaLNV.Location = new System.Drawing.Point(630, 114);
            this.txtMaLNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLNV.Name = "txtMaLNV";
            this.txtMaLNV.Size = new System.Drawing.Size(237, 20);
            this.txtMaLNV.TabIndex = 6;
            this.txtMaLNV.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại nhân viên";
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(45, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã y tá:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(134, 111);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(237, 20);
            this.dtpNgaySinh.TabIndex = 3;
            this.dtpNgaySinh.Value = new System.DateTime(1995, 12, 31, 0, 0, 0, 0);
            // 
            // txtMaYT
            // 
            this.txtMaYT.Enabled = false;
            this.txtMaYT.Location = new System.Drawing.Point(134, 43);
            this.txtMaYT.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaYT.Name = "txtMaYT";
            this.txtMaYT.Size = new System.Drawing.Size(237, 20);
            this.txtMaYT.TabIndex = 1;
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.AutoSize = true;
            this.ngaySinhLabel.Location = new System.Drawing.Point(29, 117);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(57, 13);
            this.ngaySinhLabel.TabIndex = 4;
            this.ngaySinhLabel.Text = "Ngày sinh:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(630, 77);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(2);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(237, 20);
            this.txtDienThoai.TabIndex = 5;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên y tá:";
            // 
            // txtTenYT
            // 
            this.txtTenYT.Location = new System.Drawing.Point(134, 77);
            this.txtTenYT.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenYT.Name = "txtTenYT";
            this.txtTenYT.Size = new System.Drawing.Size(237, 20);
            this.txtTenYT.TabIndex = 2;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(630, 43);
            this.cbGioiTinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(237, 21);
            this.cbGioiTinh.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giới tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Điện thoại:";
            // 
            // btThemYT
            // 
            this.btThemYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemYT.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemYT.Location = new System.Drawing.Point(515, 174);
            this.btThemYT.Name = "btThemYT";
            this.btThemYT.Size = new System.Drawing.Size(98, 58);
            this.btThemYT.TabIndex = 7;
            this.btThemYT.Text = "Thêm y tá";
            this.btThemYT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemYT.UseVisualStyleBackColor = true;
            this.btThemYT.Click += new System.EventHandler(this.btThemYT_Click);
            // 
            // btSuaYT
            // 
            this.btSuaYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaYT.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaYT.Location = new System.Drawing.Point(700, 174);
            this.btSuaYT.Name = "btSuaYT";
            this.btSuaYT.Size = new System.Drawing.Size(75, 58);
            this.btSuaYT.TabIndex = 9;
            this.btSuaYT.Text = "Sửa";
            this.btSuaYT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaYT.UseVisualStyleBackColor = true;
            this.btSuaYT.Click += new System.EventHandler(this.btSuaYT_Click);
            // 
            // btXoaYT
            // 
            this.btXoaYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaYT.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaYT.Location = new System.Drawing.Point(619, 174);
            this.btXoaYT.Name = "btXoaYT";
            this.btXoaYT.Size = new System.Drawing.Size(75, 58);
            this.btXoaYT.TabIndex = 8;
            this.btXoaYT.Text = "Xóa";
            this.btXoaYT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaYT.UseVisualStyleBackColor = true;
            this.btXoaYT.Click += new System.EventHandler(this.btXoaYT_Click);
            // 
            // gVYT
            // 
            this.gVYT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVYT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVYT.Location = new System.Drawing.Point(32, 267);
            this.gVYT.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVYT.Name = "gVYT";
            this.gVYT.RowHeadersWidth = 62;
            this.gVYT.RowTemplate.Height = 28;
            this.gVYT.Size = new System.Drawing.Size(835, 270);
            this.gVYT.TabIndex = 11;
            this.gVYT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVYT_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(32, 194);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(237, 20);
            this.txtTimKiem.TabIndex = 53;
            // 
            // btTimKiem
            // 
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Image = global::QLPM.Properties.Resources.Start_Menu_Search_icon;
            this.btTimKiem.Location = new System.Drawing.Point(296, 174);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(91, 58);
            this.btTimKiem.TabIndex = 52;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btThongKe
            // 
            this.btThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThongKe.Image = global::QLPM.Properties.Resources.list_icon;
            this.btThongKe.Location = new System.Drawing.Point(781, 174);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(86, 58);
            this.btThongKe.TabIndex = 10;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // FQLYTa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.txtMaLNV);
            this.Controls.Add(this.btSuaYT);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.gVYT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btXoaYT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btThemYT);
            this.Controls.Add(this.txtMaYT);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ngaySinhLabel);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenYT);
            this.Name = "FQLYTa";
            this.Text = "QUẢN LÝ Y TÁ";
            this.Load += new System.EventHandler(this.FQLYTa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVYT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMaLNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenYT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtMaYT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btThemYT;
        private System.Windows.Forms.Button btSuaYT;
        private System.Windows.Forms.Button btXoaYT;
        private System.Windows.Forms.DataGridView gVYT;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThongKe;
    }
}