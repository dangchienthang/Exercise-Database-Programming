
namespace QLPM
{
    partial class FBS_KeToa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBS_KeToa));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbThuoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSuaTT = new System.Windows.Forms.Button();
            this.btXoaTT = new System.Windows.Forms.Button();
            this.btThemTT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGToa = new System.Windows.Forms.DataGridView();
            this.btTaoToa = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGToa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtMaThuoc);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtLieuDung);
            this.groupBox3.Controls.Add(this.numSoLuong);
            this.groupBox3.Controls.Add(this.cbThuoc);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaToa);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(94, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 132);
            this.groupBox3.TabIndex = 29;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Enabled = false;
            this.txtMaThuoc.Location = new System.Drawing.Point(151, 52);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(214, 20);
            this.txtMaThuoc.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Mã thuốc:";
            // 
            // txtLieuDung
            // 
            this.txtLieuDung.Location = new System.Drawing.Point(538, 59);
            this.txtLieuDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtLieuDung.Name = "txtLieuDung";
            this.txtLieuDung.Size = new System.Drawing.Size(216, 20);
            this.txtLieuDung.TabIndex = 5;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(538, 31);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(216, 20);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numSoLuong_KeyPress);
            // 
            // cbThuoc
            // 
            this.cbThuoc.FormattingEnabled = true;
            this.cbThuoc.Location = new System.Drawing.Point(151, 77);
            this.cbThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbThuoc.Name = "cbThuoc";
            this.cbThuoc.Size = new System.Drawing.Size(214, 21);
            this.cbThuoc.TabIndex = 3;
            this.cbThuoc.SelectedIndexChanged += new System.EventHandler(this.cbThuoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Liều dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên thuốc:";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Enabled = false;
            this.txtMaToa.Location = new System.Drawing.Point(151, 28);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(214, 20);
            this.txtMaToa.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mã toa thuốc:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(423, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(427, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "KÊ TOA THUỐC";
            // 
            // btSuaTT
            // 
            this.btSuaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btSuaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaTT.ForeColor = System.Drawing.Color.Black;
            this.btSuaTT.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaTT.Location = new System.Drawing.Point(678, 263);
            this.btSuaTT.Name = "btSuaTT";
            this.btSuaTT.Size = new System.Drawing.Size(75, 58);
            this.btSuaTT.TabIndex = 7;
            this.btSuaTT.Text = "Sửa";
            this.btSuaTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaTT.UseVisualStyleBackColor = false;
            this.btSuaTT.Click += new System.EventHandler(this.btSuaTT_Click);
            // 
            // btXoaTT
            // 
            this.btXoaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btXoaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaTT.ForeColor = System.Drawing.Color.Black;
            this.btXoaTT.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaTT.Location = new System.Drawing.Point(775, 263);
            this.btXoaTT.Name = "btXoaTT";
            this.btXoaTT.Size = new System.Drawing.Size(73, 58);
            this.btXoaTT.TabIndex = 8;
            this.btXoaTT.Text = "Xóa";
            this.btXoaTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaTT.UseVisualStyleBackColor = false;
            this.btXoaTT.Click += new System.EventHandler(this.btXoaTT_Click);
            // 
            // btThemTT
            // 
            this.btThemTT.BackColor = System.Drawing.SystemColors.Control;
            this.btThemTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemTT.ForeColor = System.Drawing.Color.Black;
            this.btThemTT.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemTT.Location = new System.Drawing.Point(575, 263);
            this.btThemTT.Name = "btThemTT";
            this.btThemTT.Size = new System.Drawing.Size(80, 58);
            this.btThemTT.TabIndex = 6;
            this.btThemTT.Text = "Thêm";
            this.btThemTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemTT.UseVisualStyleBackColor = false;
            this.btThemTT.Click += new System.EventHandler(this.btThemTT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dGToa);
            this.groupBox1.Location = new System.Drawing.Point(94, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 221);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách:";
            // 
            // dGToa
            // 
            this.dGToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGToa.Location = new System.Drawing.Point(21, 18);
            this.dGToa.Margin = new System.Windows.Forms.Padding(2);
            this.dGToa.Name = "dGToa";
            this.dGToa.RowTemplate.Height = 24;
            this.dGToa.Size = new System.Drawing.Size(733, 188);
            this.dGToa.TabIndex = 9;
            this.dGToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGToa_CellClick);
            // 
            // btTaoToa
            // 
            this.btTaoToa.Image = global::QLPM.Properties.Resources.Accept_icon;
            this.btTaoToa.Location = new System.Drawing.Point(781, 596);
            this.btTaoToa.Name = "btTaoToa";
            this.btTaoToa.Size = new System.Drawing.Size(89, 55);
            this.btTaoToa.TabIndex = 10;
            this.btTaoToa.Text = "Kê toa";
            this.btTaoToa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTaoToa.UseVisualStyleBackColor = true;
            this.btTaoToa.Click += new System.EventHandler(this.btTaoToa_Click);
            // 
            // FBS_KeToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 691);
            this.Controls.Add(this.btTaoToa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSuaTT);
            this.Controls.Add(this.btXoaTT);
            this.Controls.Add(this.btThemTT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FBS_KeToa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kê toa thuốc";
            this.Load += new System.EventHandler(this.FKeToa_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.ComboBox cbThuoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btSuaTT;
        private System.Windows.Forms.Button btXoaTT;
        private System.Windows.Forms.Button btThemTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGToa;
        private System.Windows.Forms.Button btTaoToa;
    }
}