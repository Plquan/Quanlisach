namespace DoAn
{
    partial class frmTHELOAI
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMOTATL = new System.Windows.Forms.TextBox();
            this.txtTENTL = new System.Windows.Forms.TextBox();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTENKH = new System.Windows.Forms.Label();
            this.txtTIMKIEM = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 176);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tìm kiếm theo tên:";
            // 
            // txtMOTATL
            // 
            this.txtMOTATL.Location = new System.Drawing.Point(133, 66);
            this.txtMOTATL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMOTATL.Multiline = true;
            this.txtMOTATL.Name = "txtMOTATL";
            this.txtMOTATL.Size = new System.Drawing.Size(144, 20);
            this.txtMOTATL.TabIndex = 1;
            // 
            // txtTENTL
            // 
            this.txtTENTL.Location = new System.Drawing.Point(133, 31);
            this.txtTENTL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTENTL.Name = "txtTENTL";
            this.txtTENTL.Size = new System.Drawing.Size(144, 20);
            this.txtTENTL.TabIndex = 0;
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(465, 62);
            this.btnTHOAT.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 27);
            this.btnTHOAT.TabIndex = 6;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click_1);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(465, 29);
            this.btnXOA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(75, 27);
            this.btnXOA.TabIndex = 3;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(300, 62);
            this.btnLUU.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(75, 27);
            this.btnLUU.TabIndex = 4;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTHEM);
            this.groupBox1.Controls.Add(this.txtMOTATL);
            this.groupBox1.Controls.Add(this.txtTENTL);
            this.groupBox1.Controls.Add(this.btnTHOAT);
            this.groupBox1.Controls.Add(this.btnXOA);
            this.groupBox1.Controls.Add(this.btnLUU);
            this.groupBox1.Controls.Add(this.btnHUY);
            this.groupBox1.Controls.Add(this.btnSUA);
            this.groupBox1.Controls.Add(this.lblSDT);
            this.groupBox1.Controls.Add(this.lblTENKH);
            this.groupBox1.Location = new System.Drawing.Point(58, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(564, 108);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin";
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(300, 29);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(75, 27);
            this.btnTHEM.TabIndex = 0;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click_1);
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(383, 62);
            this.btnHUY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(75, 27);
            this.btnHUY.TabIndex = 5;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(382, 29);
            this.btnSUA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(75, 27);
            this.btnSUA.TabIndex = 2;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(19, 69);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(86, 13);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Mô Tả Thể Loại:";
            // 
            // lblTENKH
            // 
            this.lblTENKH.AutoSize = true;
            this.lblTENKH.Location = new System.Drawing.Point(19, 34);
            this.lblTENKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTENKH.Name = "lblTENKH";
            this.lblTENKH.Size = new System.Drawing.Size(87, 13);
            this.lblTENKH.TabIndex = 0;
            this.lblTENKH.Text = "Tên Thể Loại (*):";
            // 
            // txtTIMKIEM
            // 
            this.txtTIMKIEM.Location = new System.Drawing.Point(191, 173);
            this.txtTIMKIEM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTIMKIEM.Name = "txtTIMKIEM";
            this.txtTIMKIEM.Size = new System.Drawing.Size(108, 20);
            this.txtTIMKIEM.TabIndex = 0;
            this.txtTIMKIEM.TextChanged += new System.EventHandler(this.txtTIMKIEM_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(0, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(564, 172);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAI";
            this.Column1.HeaderText = "Mã Loại";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENTHELOAI";
            this.Column2.HeaderText = "Tên Thể Loại";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MOTATHELOAI";
            this.Column3.HeaderText = "Mô Tả Thể Loại";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(58, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 191);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỂ LOẠI ";
            // 
            // frmTHELOAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 436);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTIMKIEM);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTHELOAI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTHELOAI";
            this.Load += new System.EventHandler(this.frmTHELOAI_Load);
            this.DoubleClick += new System.EventHandler(this.frmTHELOAI_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMOTATL;
        private System.Windows.Forms.TextBox txtTENTL;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTENKH;
        private System.Windows.Forms.TextBox txtTIMKIEM;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}