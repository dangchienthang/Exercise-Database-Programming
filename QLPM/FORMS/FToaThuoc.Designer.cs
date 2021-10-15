
namespace QLPM.FORMS
{
    partial class FToaThuoc
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
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSuaToa = new System.Windows.Forms.Button();
            this.btXoaToa = new System.Windows.Forms.Button();
            this.gVToa = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayKeToa = new System.Windows.Forms.DateTimePicker();
            this.cbBS = new System.Windows.Forms.ComboBox();
            this.cbBN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gVToa)).BeginInit();
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
            // txtMaToa
            // 
            this.txtMaToa.Enabled = false;
            this.txtMaToa.Location = new System.Drawing.Point(134, 43);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(237, 20);
            this.txtMaToa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày kê toa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên bác sĩ:";
            // 
            // btSuaToa
            // 
            this.btSuaToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaToa.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaToa.Location = new System.Drawing.Point(792, 174);
            this.btSuaToa.Name = "btSuaToa";
            this.btSuaToa.Size = new System.Drawing.Size(75, 58);
            this.btSuaToa.TabIndex = 6;
            this.btSuaToa.Text = "Sửa";
            this.btSuaToa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaToa.UseVisualStyleBackColor = true;
            this.btSuaToa.Click += new System.EventHandler(this.btSuaToa_Click);
            // 
            // btXoaToa
            // 
            this.btXoaToa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaToa.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaToa.Location = new System.Drawing.Point(688, 174);
            this.btXoaToa.Name = "btXoaToa";
            this.btXoaToa.Size = new System.Drawing.Size(75, 58);
            this.btXoaToa.TabIndex = 5;
            this.btXoaToa.Text = "Xóa";
            this.btXoaToa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaToa.UseVisualStyleBackColor = true;
            this.btXoaToa.Click += new System.EventHandler(this.btXoaToa_Click);
            // 
            // gVToa
            // 
            this.gVToa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gVToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVToa.Location = new System.Drawing.Point(32, 267);
            this.gVToa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVToa.Name = "gVToa";
            this.gVToa.RowHeadersWidth = 62;
            this.gVToa.RowTemplate.Height = 28;
            this.gVToa.Size = new System.Drawing.Size(835, 270);
            this.gVToa.TabIndex = 7;
            this.gVToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVToa_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên bệnh nhân:";
            // 
            // dtpNgayKeToa
            // 
            this.dtpNgayKeToa.CustomFormat = "";
            this.dtpNgayKeToa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKeToa.Location = new System.Drawing.Point(134, 74);
            this.dtpNgayKeToa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayKeToa.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayKeToa.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpNgayKeToa.Name = "dtpNgayKeToa";
            this.dtpNgayKeToa.Size = new System.Drawing.Size(237, 20);
            this.dtpNgayKeToa.TabIndex = 2;
            this.dtpNgayKeToa.Value = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            // 
            // cbBS
            // 
            this.cbBS.FormattingEnabled = true;
            this.cbBS.Location = new System.Drawing.Point(134, 113);
            this.cbBS.Margin = new System.Windows.Forms.Padding(2);
            this.cbBS.Name = "cbBS";
            this.cbBS.Size = new System.Drawing.Size(237, 21);
            this.cbBS.TabIndex = 3;
            // 
            // cbBN
            // 
            this.cbBN.FormattingEnabled = true;
            this.cbBN.Location = new System.Drawing.Point(134, 149);
            this.cbBN.Margin = new System.Windows.Forms.Padding(2);
            this.cbBN.Name = "cbBN";
            this.cbBN.Size = new System.Drawing.Size(237, 21);
            this.cbBN.TabIndex = 4;
            // 
            // FToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.cbBN);
            this.Controls.Add(this.dtpNgayKeToa);
            this.Controls.Add(this.cbBS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSuaToa);
            this.Controls.Add(this.hoTenNhanVienLabel);
            this.Controls.Add(this.gVToa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoaToa);
            this.Controls.Add(this.txtMaToa);
            this.Controls.Add(this.label2);
            this.Name = "FToaThuoc";
            this.Text = "DANH SÁCH TOA THUỐC";
            this.Load += new System.EventHandler(this.FToaThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gVToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuaToa;
        private System.Windows.Forms.Button btXoaToa;
        private System.Windows.Forms.DataGridView gVToa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayKeToa;
        private System.Windows.Forms.ComboBox cbBS;
        private System.Windows.Forms.ComboBox cbBN;
    }
}