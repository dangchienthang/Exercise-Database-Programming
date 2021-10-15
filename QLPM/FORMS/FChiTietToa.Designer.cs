
namespace QLPM
{
    partial class FChiTietToa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChiTietToa));
            this.btSuaTT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gVToa = new System.Windows.Forms.DataGridView();
            this.btXoaTT = new System.Windows.Forms.Button();
            this.btThemTT = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.txtLD = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVToa)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSuaTT
            // 
            this.btSuaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btSuaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSuaTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSuaTT.Image = global::QLPM.Properties.Resources.fix_it_icon;
            this.btSuaTT.Location = new System.Drawing.Point(718, 164);
            this.btSuaTT.Name = "btSuaTT";
            this.btSuaTT.Size = new System.Drawing.Size(75, 58);
            this.btSuaTT.TabIndex = 31;
            this.btSuaTT.Text = "Sửa";
            this.btSuaTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSuaTT.UseVisualStyleBackColor = false;
            this.btSuaTT.Click += new System.EventHandler(this.btSuaTT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.gVToa);
            this.groupBox1.Location = new System.Drawing.Point(52, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 300);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toa thuốc:";
            // 
            // gVToa
            // 
            this.gVToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVToa.Location = new System.Drawing.Point(23, 17);
            this.gVToa.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.gVToa.Name = "gVToa";
            this.gVToa.RowHeadersWidth = 62;
            this.gVToa.RowTemplate.Height = 28;
            this.gVToa.Size = new System.Drawing.Size(837, 267);
            this.gVToa.TabIndex = 8;
            this.gVToa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gVToa_CellClick);
            // 
            // btXoaTT
            // 
            this.btXoaTT.BackColor = System.Drawing.SystemColors.Control;
            this.btXoaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoaTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btXoaTT.Image = global::QLPM.Properties.Resources.delete_file_icon;
            this.btXoaTT.Location = new System.Drawing.Point(837, 164);
            this.btXoaTT.Name = "btXoaTT";
            this.btXoaTT.Size = new System.Drawing.Size(75, 58);
            this.btXoaTT.TabIndex = 32;
            this.btXoaTT.Text = "Xóa";
            this.btXoaTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btXoaTT.UseVisualStyleBackColor = false;
            this.btXoaTT.Click += new System.EventHandler(this.btXoaTT_Click);
            // 
            // btThemTT
            // 
            this.btThemTT.BackColor = System.Drawing.SystemColors.Control;
            this.btThemTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemTT.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btThemTT.Image = global::QLPM.Properties.Resources.Button_Add_icon;
            this.btThemTT.Location = new System.Drawing.Point(512, 164);
            this.btThemTT.Name = "btThemTT";
            this.btThemTT.Size = new System.Drawing.Size(166, 58);
            this.btThemTT.TabIndex = 30;
            this.btThemTT.Text = "Thêm chi tiết toa thuốc";
            this.btThemTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThemTT.UseVisualStyleBackColor = false;
            this.btThemTT.Click += new System.EventHandler(this.btThemTT_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtMaThuoc);
            this.groupBox3.Controls.Add(this.txtLD);
            this.groupBox3.Controls.Add(this.txtSL);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtMaToa);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(52, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 160);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin";
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Enabled = false;
            this.txtMaThuoc.Location = new System.Drawing.Point(151, 59);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(230, 20);
            this.txtMaThuoc.TabIndex = 2;
            // 
            // txtLD
            // 
            this.txtLD.Location = new System.Drawing.Point(151, 110);
            this.txtLD.Margin = new System.Windows.Forms.Padding(2);
            this.txtLD.Name = "txtLD";
            this.txtLD.Size = new System.Drawing.Size(230, 20);
            this.txtLD.TabIndex = 4;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(151, 84);
            this.txtSL.Margin = new System.Windows.Forms.Padding(2);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(230, 20);
            this.txtSL.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Liều dùng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Số lượng:";
            // 
            // txtMaToa
            // 
            this.txtMaToa.Enabled = false;
            this.txtMaToa.Location = new System.Drawing.Point(151, 28);
            this.txtMaToa.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaToa.Name = "txtMaToa";
            this.txtMaToa.Size = new System.Drawing.Size(230, 20);
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
            this.label16.Location = new System.Drawing.Point(43, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Mã thuốc:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(441, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 20);
            this.label18.TabIndex = 33;
            this.label18.Text = "CHI TIẾT TOA THUỐC";
            // 
            // FCTToaThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btSuaTT);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btXoaTT);
            this.Controls.Add(this.btThemTT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label18);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FCTToaThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết toa thuốc";
            this.Activated += new System.EventHandler(this.FCTToaThuoc_Activated);
            this.Load += new System.EventHandler(this.FCTToaThuoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gVToa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSuaTT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gVToa;
        private System.Windows.Forms.Button btXoaTT;
        private System.Windows.Forms.Button btThemTT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private System.Windows.Forms.TextBox txtLD;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
    }
}