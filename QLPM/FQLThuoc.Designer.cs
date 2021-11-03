
namespace QLPM
{
    partial class FQLThuoc
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
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemThuoc = new System.Windows.Forms.Button();
            this.btSuaThuoc = new System.Windows.Forms.Button();
            this.btXoaThuoc = new System.Windows.Forms.Button();
            this.gVThuoc = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gVThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(55, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã thuốc:";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Enabled = false;
            this.txtMaThuoc.Location = new System.Drawing.Point(134, 43);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(237, 20);
            this.txtMaThuoc.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(134, 113);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(237, 20);
            this.txtMoTa.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên thuốc:";
            // 
            // txtTenThuoc
            // 
            this.txtTenThuoc.Location = new System.Drawing.Point(134, 77);
            this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenThuoc.Name = "txtTenThuoc";
            this.txtTenThuoc.Size = new System.Drawing.Size(237, 20);
            this.txtTenThuoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mô tả:";
            // 
            // btThemThuoc
            // 
            this.btThemThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemThuoc.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemThuoc.Location = new System.Drawing.Point(504, 174);
            this.btThemThuoc.Name = "btThemThuoc";
            this.btThemThuoc.Size = new System.Drawing.Size(109, 58);
            this.btThemThuoc.TabIndex = 4;
            this.btThemThuoc.Text = "Thêm thuốc";
            this.btThemThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemThuoc.UseVisualStyleBackColor = true;
            this.btThemThuoc.Click += new System.EventHandler(this.btThemThuoc_Click);
            // 
            // btSuaThuoc
            // 
            this.btSuaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaThuoc.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaThuoc.Location = new System.Drawing.Point(700, 174);
            this.btSuaThuoc.Name = "btSuaThuoc";
            this.btSuaThuoc.Size = new System.Drawing.Size(75, 58);
            this.btSuaThuoc.TabIndex = 6;
            this.btSuaThuoc.Text = "Sửa";
            this.btSuaThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaThuoc.UseVisualStyleBackColor = true;
            this.btSuaThuoc.Click += new System.EventHandler(this.btSuaThuoc_Click);
            // 
            // btXoaThuoc
            // 
            this.btXoaThuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaThuoc.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaThuoc.Location = new System.Drawing.Point(619, 174);
            this.btXoaThuoc.Name = "btXoaThuoc";
            this.btXoaThuoc.Size = new System.Drawing.Size(75, 58);
            this.btXoaThuoc.TabIndex = 5;
            this.btXoaThuoc.Text = "Xóa";
            this.btXoaThuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaThuoc.UseVisualStyleBackColor = true;
            this.btXoaThuoc.Click += new System.EventHandler(this.btXoaThuoc_Click);
            // 
            // gVThuoc
            // 
            this.gVThuoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVThuoc.Location = new System.Drawing.Point(32, 267);
            this.gVThuoc.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVThuoc.Name = "gVThuoc";
            this.gVThuoc.RowHeadersWidth = 62;
            this.gVThuoc.RowTemplate.Height = 28;
            this.gVThuoc.Size = new System.Drawing.Size(835, 270);
            this.gVThuoc.TabIndex = 8;
            this.gVThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVThuoc_CellClick);
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
            this.btThongKe.TabIndex = 9;
            this.btThongKe.Text = "Thống kê";
            this.btThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
            // 
            // FQLThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.btThongKe);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.btSuaThuoc);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVThuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaThuoc);
            this.Controls.Add(this.btThemThuoc);
            this.Controls.Add(this.txtMaThuoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenThuoc);
            this.Name = "FQLThuoc";
            this.Text = "QUẢN LÝ THUỐC";
            this.Load += new System.EventHandler(this.FQLThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThemThuoc;
        private System.Windows.Forms.Button btSuaThuoc;
        private System.Windows.Forms.Button btXoaThuoc;
        private System.Windows.Forms.DataGridView gVThuoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Button btThongKe;
    }
}