
namespace QLPM.FORMS
{
    partial class FXetNghiem
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
            this.txtMaXN = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenXN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btThemXN = new System.Windows.Forms.Button();
            this.btSuaXN = new System.Windows.Forms.Button();
            this.btXoaXN = new System.Windows.Forms.Button();
            this.gVXN = new System.Windows.Forms.DataGridView();
            this.cbLXN = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gVXN)).BeginInit();
            this.SuspendLayout();
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(29, 46);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(79, 13);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Mã xét nghiệm:";
            // 
            // txtMaXN
            // 
            this.txtMaXN.Enabled = false;
            this.txtMaXN.Location = new System.Drawing.Point(134, 43);
            this.txtMaXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXN.Name = "txtMaXN";
            this.txtMaXN.Size = new System.Drawing.Size(237, 20);
            this.txtMaXN.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(134, 149);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(237, 20);
            this.txtMoTa.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên xét nghiệm:";
            // 
            // txtTenXN
            // 
            this.txtTenXN.Location = new System.Drawing.Point(134, 77);
            this.txtTenXN.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenXN.Name = "txtTenXN";
            this.txtTenXN.Size = new System.Drawing.Size(237, 20);
            this.txtTenXN.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mô tả:";
            // 
            // btThemXN
            // 
            this.btThemXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemXN.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemXN.Location = new System.Drawing.Point(547, 174);
            this.btThemXN.Name = "btThemXN";
            this.btThemXN.Size = new System.Drawing.Size(109, 58);
            this.btThemXN.TabIndex = 5;
            this.btThemXN.Text = "Thêm xét nghiệm";
            this.btThemXN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemXN.UseVisualStyleBackColor = true;
            this.btThemXN.Click += new System.EventHandler(this.btThemXN_Click);
            // 
            // btSuaXN
            // 
            this.btSuaXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaXN.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaXN.Location = new System.Drawing.Point(792, 174);
            this.btSuaXN.Name = "btSuaXN";
            this.btSuaXN.Size = new System.Drawing.Size(75, 58);
            this.btSuaXN.TabIndex = 7;
            this.btSuaXN.Text = "Sửa";
            this.btSuaXN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaXN.UseVisualStyleBackColor = true;
            this.btSuaXN.Click += new System.EventHandler(this.btSuaXN_Click);
            // 
            // btXoaXN
            // 
            this.btXoaXN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaXN.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaXN.Location = new System.Drawing.Point(688, 174);
            this.btXoaXN.Name = "btXoaXN";
            this.btXoaXN.Size = new System.Drawing.Size(75, 58);
            this.btXoaXN.TabIndex = 6;
            this.btXoaXN.Text = "Xóa";
            this.btXoaXN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaXN.UseVisualStyleBackColor = true;
            this.btXoaXN.Click += new System.EventHandler(this.btXoaXN_Click);
            // 
            // gVXN
            // 
            this.gVXN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVXN.Location = new System.Drawing.Point(32, 267);
            this.gVXN.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVXN.Name = "gVXN";
            this.gVXN.RowHeadersWidth = 62;
            this.gVXN.RowTemplate.Height = 28;
            this.gVXN.Size = new System.Drawing.Size(835, 270);
            this.gVXN.TabIndex = 7;
            this.gVXN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVXN_CellClick);
            // 
            // cbLXN
            // 
            this.cbLXN.FormattingEnabled = true;
            this.cbLXN.Location = new System.Drawing.Point(134, 112);
            this.cbLXN.Margin = new System.Windows.Forms.Padding(2);
            this.cbLXN.Name = "cbLXN";
            this.cbLXN.Size = new System.Drawing.Size(237, 21);
            this.cbLXN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại xét nghiệm:";
            // 
            // FXetNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.cbLXN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSuaXN);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVXN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaXN);
            this.Controls.Add(this.btThemXN);
            this.Controls.Add(this.txtMaXN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenXN);
            this.Name = "FXetNghiem";
            this.Text = "DANH SÁCH XÉT NGHIỆM";
            this.Load += new System.EventHandler(this.FXetNghiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVXN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.TextBox txtTenXN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaXN;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThemXN;
        private System.Windows.Forms.Button btSuaXN;
        private System.Windows.Forms.Button btXoaXN;
        private System.Windows.Forms.DataGridView gVXN;
        private System.Windows.Forms.ComboBox cbLXN;
        private System.Windows.Forms.Label label3;
    }
}