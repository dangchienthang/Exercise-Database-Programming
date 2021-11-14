
namespace QLPM
{
    partial class FDSLoaiXetNghiem
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
            this.txtMaLXN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLXN = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.gVLXN = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVLXN)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(98, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã loại xét nghiệm:";
            // 
            // txtMaLXN
            // 
            this.txtMaLXN.Enabled = false;
            this.txtMaLXN.Location = new System.Drawing.Point(152, 43);
            this.txtMaLXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLXN.Name = "txtMaLXN";
            this.txtMaLXN.Size = new System.Drawing.Size(237, 20);
            this.txtMaLXN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên loại xét nghiệm:";
            // 
            // txtTenLXN
            // 
            this.txtTenLXN.Location = new System.Drawing.Point(152, 77);
            this.txtTenLXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenLXN.Name = "txtTenLXN";
            this.txtTenLXN.Size = new System.Drawing.Size(237, 20);
            this.txtTenLXN.TabIndex = 2;
            // 
            // btThem
            // 
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThem.Location = new System.Drawing.Point(563, 174);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(93, 58);
            this.btThem.TabIndex = 3;
            this.btThem.Text = "  Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSua.Location = new System.Drawing.Point(792, 174);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 58);
            this.btSua.TabIndex = 5;
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoa.Location = new System.Drawing.Point(688, 174);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 58);
            this.btXoa.TabIndex = 4;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // gVLXN
            // 
            this.gVLXN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVLXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVLXN.Location = new System.Drawing.Point(32, 267);
            this.gVLXN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVLXN.Name = "gVLXN";
            this.gVLXN.RowHeadersWidth = 62;
            this.gVLXN.RowTemplate.Height = 28;
            this.gVLXN.Size = new System.Drawing.Size(835, 270);
            this.gVLXN.TabIndex = 6;
            this.gVLXN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVLXN_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(152, 115);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(237, 53);
            this.txtMoTa.TabIndex = 3;
            // 
            // FDSLoaiXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVLXN);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtMaLXN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenLXN);
            this.Name = "FDSLoaiXetNghiem";
            this.Text = "DANH SÁCH LOẠI XÉT NGHIỆM";
            this.Load += new System.EventHandler(this.FLoaiXetNghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVLXN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenLXN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLXN;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DataGridView gVLXN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
    }
}