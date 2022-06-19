
namespace EnrollStudentsInSchool_
{
    partial class FLopHocPhan
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
            this.label15 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dgvLopHocPhan = new System.Windows.Forms.DataGridView();
            this.comboBox_hocky = new System.Windows.Forms.ComboBox();
            this.comboBox_NNgiangday = new System.Windows.Forms.ComboBox();
            this.btnTraMa_GV = new System.Windows.Forms.Button();
            this.btnTraMa_MonHoc = new System.Windows.Forms.Button();
            this.textBox_mota = new System.Windows.Forms.TextBox();
            this.textBox_namhoc = new System.Windows.Forms.TextBox();
            this.textBoxMaGV = new System.Windows.Forms.TextBox();
            this.textBox_MaMonhoc = new System.Windows.Forms.TextBox();
            this.textBox_SLSV = new System.Windows.Forms.TextBox();
            this.textBox_MaLHP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(538, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(323, 37);
            this.label15.TabIndex = 9;
            this.label15.Text = "QUẢN LÝ LỚP HỌC PHẦN";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btn_update);
            this.pnlMain.Controls.Add(this.btn_del);
            this.pnlMain.Controls.Add(this.btn_add);
            this.pnlMain.Controls.Add(this.dgvLopHocPhan);
            this.pnlMain.Controls.Add(this.comboBox_hocky);
            this.pnlMain.Controls.Add(this.comboBox_NNgiangday);
            this.pnlMain.Controls.Add(this.btnTraMa_GV);
            this.pnlMain.Controls.Add(this.btnTraMa_MonHoc);
            this.pnlMain.Controls.Add(this.textBox_mota);
            this.pnlMain.Controls.Add(this.textBox_namhoc);
            this.pnlMain.Controls.Add(this.textBoxMaGV);
            this.pnlMain.Controls.Add(this.textBox_MaMonhoc);
            this.pnlMain.Controls.Add(this.textBox_SLSV);
            this.pnlMain.Controls.Add(this.textBox_MaLHP);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.TabIndex = 11;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1266, 439);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(1143, 439);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Xóa";
            this.btn_del.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1017, 439);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgvLopHocPhan
            // 
            this.dgvLopHocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLopHocPhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLopHocPhan.Location = new System.Drawing.Point(0, 473);
            this.dgvLopHocPhan.Name = "dgvLopHocPhan";
            this.dgvLopHocPhan.RowTemplate.Height = 25;
            this.dgvLopHocPhan.Size = new System.Drawing.Size(1400, 377);
            this.dgvLopHocPhan.TabIndex = 12;
            // 
            // comboBox_hocky
            // 
            this.comboBox_hocky.FormattingEnabled = true;
            this.comboBox_hocky.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_hocky.Location = new System.Drawing.Point(200, 286);
            this.comboBox_hocky.Name = "comboBox_hocky";
            this.comboBox_hocky.Size = new System.Drawing.Size(194, 23);
            this.comboBox_hocky.TabIndex = 3;
            this.comboBox_hocky.Text = "1";
            // 
            // comboBox_NNgiangday
            // 
            this.comboBox_NNgiangday.FormattingEnabled = true;
            this.comboBox_NNgiangday.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Việt"});
            this.comboBox_NNgiangday.Location = new System.Drawing.Point(904, 199);
            this.comboBox_NNgiangday.Name = "comboBox_NNgiangday";
            this.comboBox_NNgiangday.Size = new System.Drawing.Size(148, 23);
            this.comboBox_NNgiangday.TabIndex = 3;
            this.comboBox_NNgiangday.Text = "Tiếng Việt";
            // 
            // btnTraMa_GV
            // 
            this.btnTraMa_GV.Location = new System.Drawing.Point(1056, 364);
            this.btnTraMa_GV.Name = "btnTraMa_GV";
            this.btnTraMa_GV.Size = new System.Drawing.Size(75, 23);
            this.btnTraMa_GV.TabIndex = 2;
            this.btnTraMa_GV.Text = "Tra mã";
            this.btnTraMa_GV.UseVisualStyleBackColor = true;
            this.btnTraMa_GV.Click += new System.EventHandler(this.btnTraMa_GV_Click);
            // 
            // btnTraMa_MonHoc
            // 
            this.btnTraMa_MonHoc.Location = new System.Drawing.Point(1056, 298);
            this.btnTraMa_MonHoc.Name = "btnTraMa_MonHoc";
            this.btnTraMa_MonHoc.Size = new System.Drawing.Size(75, 23);
            this.btnTraMa_MonHoc.TabIndex = 2;
            this.btnTraMa_MonHoc.Text = "Tra mã";
            this.btnTraMa_MonHoc.UseVisualStyleBackColor = true;
            this.btnTraMa_MonHoc.Click += new System.EventHandler(this.btnTraMa_MonHoc_Click);
            // 
            // textBox_mota
            // 
            this.textBox_mota.Location = new System.Drawing.Point(200, 362);
            this.textBox_mota.Name = "textBox_mota";
            this.textBox_mota.Size = new System.Drawing.Size(194, 23);
            this.textBox_mota.TabIndex = 1;
            // 
            // textBox_namhoc
            // 
            this.textBox_namhoc.Location = new System.Drawing.Point(200, 199);
            this.textBox_namhoc.Name = "textBox_namhoc";
            this.textBox_namhoc.Size = new System.Drawing.Size(194, 23);
            this.textBox_namhoc.TabIndex = 1;
            // 
            // textBoxMaGV
            // 
            this.textBoxMaGV.Location = new System.Drawing.Point(861, 365);
            this.textBoxMaGV.Name = "textBoxMaGV";
            this.textBoxMaGV.Size = new System.Drawing.Size(154, 23);
            this.textBoxMaGV.TabIndex = 1;
            // 
            // textBox_MaMonhoc
            // 
            this.textBox_MaMonhoc.Location = new System.Drawing.Point(862, 289);
            this.textBox_MaMonhoc.Name = "textBox_MaMonhoc";
            this.textBox_MaMonhoc.Size = new System.Drawing.Size(154, 23);
            this.textBox_MaMonhoc.TabIndex = 1;
            // 
            // textBox_SLSV
            // 
            this.textBox_SLSV.Location = new System.Drawing.Point(898, 107);
            this.textBox_SLSV.Name = "textBox_SLSV";
            this.textBox_SLSV.Size = new System.Drawing.Size(154, 23);
            this.textBox_SLSV.TabIndex = 1;
            // 
            // textBox_MaLHP
            // 
            this.textBox_MaLHP.Location = new System.Drawing.Point(240, 108);
            this.textBox_MaLHP.Name = "textBox_MaLHP";
            this.textBox_MaLHP.Size = new System.Drawing.Size(154, 23);
            this.textBox_MaLHP.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(752, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(108, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(752, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngôn ngữ giảng dạy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(752, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã giảng viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(108, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(108, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Năm học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(752, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(108, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp Học Phần";
            // 
            // FLopHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnlMain);
            this.Name = "FLopHocPhan";
            this.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLopHocPhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox textBox_MaLHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mota;
        private System.Windows.Forms.TextBox textBox_namhoc;
        private System.Windows.Forms.TextBox textBoxMaGV;
        private System.Windows.Forms.TextBox textBox_MaMonhoc;
        private System.Windows.Forms.TextBox textBox_SLSV;
        private System.Windows.Forms.Button btnTraMa_GV;
        private System.Windows.Forms.Button btnTraMa_MonHoc;
        private System.Windows.Forms.ComboBox comboBox_NNgiangday;
        private System.Windows.Forms.ComboBox comboBox_hocky;
        public System.Windows.Forms.DataGridView dgvLopHocPhan;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_add;
    }
}