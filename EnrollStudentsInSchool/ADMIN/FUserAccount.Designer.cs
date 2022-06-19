
namespace EnrollStudentsInSchool_
{
    partial class FUserAccount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvUserAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.dgvUserAccount);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvUserAccount
            // 
            this.dgvUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUserAccount.Location = new System.Drawing.Point(0, 513);
            this.dgvUserAccount.Name = "dgvUserAccount";
            this.dgvUserAccount.RowTemplate.Height = 25;
            this.dgvUserAccount.Size = new System.Drawing.Size(1400, 337);
            this.dgvUserAccount.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(477, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ TÀI KHOẢN NGƯỜI DÙNG";
            // 
            // FUserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "FUserAccount";
            this.Size = new System.Drawing.Size(1400, 850);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dgvUserAccount;
    }
}
