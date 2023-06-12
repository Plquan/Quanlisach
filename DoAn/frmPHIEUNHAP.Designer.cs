namespace DoAn
{
    partial class frmPHIEUNHAP
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
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLAP = new System.Windows.Forms.Button();
            this.txtSOPN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTENNXB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHUY = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGHI = new System.Windows.Forms.Button();
            this.txtNGAYNHAP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTACGIA = new System.Windows.Forms.TextBox();
            this.txtTHELOAI = new System.Windows.Forms.TextBox();
            this.cboTENSACH = new System.Windows.Forms.ComboBox();
            this.txtSOLUONG = new System.Windows.Forms.TextBox();
            this.btnTHEMSACH = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGIANHAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 30F;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = global::DoAn.Properties.Resources.delete;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 33);
            this.label7.TabIndex = 39;
            this.label7.Text = "PHIẾU NHẬP ";
            // 
            // btnLAP
            // 
            this.btnLAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLAP.Location = new System.Drawing.Point(438, 59);
            this.btnLAP.Name = "btnLAP";
            this.btnLAP.Size = new System.Drawing.Size(98, 31);
            this.btnLAP.TabIndex = 3;
            this.btnLAP.Text = "Lập phiếu";
            this.btnLAP.UseVisualStyleBackColor = true;
            this.btnLAP.Click += new System.EventHandler(this.btnLAP_Click);
            // 
            // txtSOPN
            // 
            this.txtSOPN.Location = new System.Drawing.Point(84, 26);
            this.txtSOPN.Name = "txtSOPN";
            this.txtSOPN.ReadOnly = true;
            this.txtSOPN.Size = new System.Drawing.Size(121, 20);
            this.txtSOPN.TabIndex = 35;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLAP);
            this.groupBox1.Controls.Add(this.txtSOPN);
            this.groupBox1.Controls.Add(this.cboTENNXB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnHUY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGHI);
            this.groupBox1.Controls.Add(this.txtNGAYNHAP);
            this.groupBox1.Location = new System.Drawing.Point(43, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 105);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết ";
            // 
            // cboTENNXB
            // 
            this.cboTENNXB.FormattingEnabled = true;
            this.cboTENNXB.Location = new System.Drawing.Point(345, 25);
            this.cboTENNXB.Name = "cboTENNXB";
            this.cboTENNXB.Size = new System.Drawing.Size(188, 21);
            this.cboTENNXB.TabIndex = 0;
            this.cboTENNXB.SelectedIndexChanged += new System.EventHandler(this.cboTENNXB_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số phiếu nhập:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ngày Nhập:";
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(363, 59);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(69, 31);
            this.btnHUY.TabIndex = 2;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà Xuất Bản:";
            // 
            // btnGHI
            // 
            this.btnGHI.Location = new System.Drawing.Point(270, 59);
            this.btnGHI.Name = "btnGHI";
            this.btnGHI.Size = new System.Drawing.Size(84, 31);
            this.btnGHI.TabIndex = 1;
            this.btnGHI.Text = "Ghi phiếu";
            this.btnGHI.UseVisualStyleBackColor = true;
            this.btnGHI.Click += new System.EventHandler(this.btnGHI_Click);
            // 
            // txtNGAYNHAP
            // 
            this.txtNGAYNHAP.Location = new System.Drawing.Point(84, 65);
            this.txtNGAYNHAP.Name = "txtNGAYNHAP";
            this.txtNGAYNHAP.ReadOnly = true;
            this.txtNGAYNHAP.Size = new System.Drawing.Size(121, 20);
            this.txtNGAYNHAP.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(396, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "VND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTACGIA);
            this.groupBox2.Controls.Add(this.txtTHELOAI);
            this.groupBox2.Controls.Add(this.cboTENSACH);
            this.groupBox2.Controls.Add(this.txtSOLUONG);
            this.groupBox2.Controls.Add(this.btnTHEMSACH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtGIANHAP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(43, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 125);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // txtTACGIA
            // 
            this.txtTACGIA.Location = new System.Drawing.Point(84, 89);
            this.txtTACGIA.Name = "txtTACGIA";
            this.txtTACGIA.ReadOnly = true;
            this.txtTACGIA.Size = new System.Drawing.Size(124, 20);
            this.txtTACGIA.TabIndex = 12;
            // 
            // txtTHELOAI
            // 
            this.txtTHELOAI.Location = new System.Drawing.Point(84, 57);
            this.txtTHELOAI.Name = "txtTHELOAI";
            this.txtTHELOAI.ReadOnly = true;
            this.txtTHELOAI.Size = new System.Drawing.Size(124, 20);
            this.txtTHELOAI.TabIndex = 11;
            // 
            // cboTENSACH
            // 
            this.cboTENSACH.FormattingEnabled = true;
            this.cboTENSACH.Location = new System.Drawing.Point(84, 23);
            this.cboTENSACH.Name = "cboTENSACH";
            this.cboTENSACH.Size = new System.Drawing.Size(124, 21);
            this.cboTENSACH.TabIndex = 8;
            this.cboTENSACH.SelectedIndexChanged += new System.EventHandler(this.cboTENSACH_SelectedIndexChanged);
            // 
            // txtSOLUONG
            // 
            this.txtSOLUONG.Location = new System.Drawing.Point(295, 57);
            this.txtSOLUONG.Name = "txtSOLUONG";
            this.txtSOLUONG.Size = new System.Drawing.Size(95, 20);
            this.txtSOLUONG.TabIndex = 9;
            // 
            // btnTHEMSACH
            // 
            this.btnTHEMSACH.Location = new System.Drawing.Point(433, 57);
            this.btnTHEMSACH.Name = "btnTHEMSACH";
            this.btnTHEMSACH.Size = new System.Drawing.Size(88, 34);
            this.btnTHEMSACH.TabIndex = 0;
            this.btnTHEMSACH.Text = "Thêm Sách ";
            this.btnTHEMSACH.UseVisualStyleBackColor = true;
            this.btnTHEMSACH.Click += new System.EventHandler(this.btnTHEMSACH_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tác Giả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Thể Loại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Sách:";
            // 
            // txtGIANHAP
            // 
            this.txtGIANHAP.Location = new System.Drawing.Point(295, 23);
            this.txtGIANHAP.Name = "txtGIANHAP";
            this.txtGIANHAP.Size = new System.Drawing.Size(95, 20);
            this.txtGIANHAP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giá nhập:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(43, 299);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 179);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn ";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.GIANHAP,
            this.SOLUONGNHAP,
            this.DELETE});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView2.Location = new System.Drawing.Point(0, 20);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 159);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MASACH";
            this.Column7.HeaderText = "Mã Sách";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TENSACH";
            this.Column8.HeaderText = "Tên Sách";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // GIANHAP
            // 
            this.GIANHAP.HeaderText = "Giá Nhập";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.ReadOnly = true;
            // 
            // SOLUONGNHAP
            // 
            this.SOLUONGNHAP.HeaderText = "Số Lượng";
            this.SOLUONGNHAP.Name = "SOLUONGNHAP";
            this.SOLUONGNHAP.ReadOnly = true;
            // 
            // DELETE
            // 
            this.DELETE.FillWeight = 30F;
            this.DELETE.HeaderText = "Del";
            this.DELETE.Image = global::DoAn.Properties.Resources.OIP;
            this.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DELETE.Name = "DELETE";
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(532, 484);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 23);
            this.btnTHOAT.TabIndex = 37;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // frmPHIEUNHAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 518);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnTHOAT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmPHIEUNHAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHIEUNHAP";
            this.Load += new System.EventHandler(this.PHIEUNHAP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLAP;
        private System.Windows.Forms.TextBox txtSOPN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTENNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGHI;
        private System.Windows.Forms.TextBox txtNGAYNHAP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTENSACH;
        private System.Windows.Forms.TextBox txtSOLUONG;
        private System.Windows.Forms.Button btnTHEMSACH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGIANHAP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.TextBox txtTACGIA;
        private System.Windows.Forms.TextBox txtTHELOAI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGNHAP;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}