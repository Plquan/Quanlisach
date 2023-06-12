namespace DoAn
{
    partial class frmHOADON
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtGIA = new System.Windows.Forms.TextBox();
            this.txtKHO = new System.Windows.Forms.TextBox();
            this.cboTENSACH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.soluong = new System.Windows.Forms.Label();
            this.txtSOLUONG = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONGMUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnXUAT = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnTHEMSACH = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNGAYLAP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTENKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTHEMHD = new System.Windows.Forms.Button();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Số lượng:";
            // 
            // txtGIA
            // 
            this.txtGIA.Location = new System.Drawing.Point(289, 31);
            this.txtGIA.Name = "txtGIA";
            this.txtGIA.ReadOnly = true;
            this.txtGIA.Size = new System.Drawing.Size(95, 20);
            this.txtGIA.TabIndex = 9;
            // 
            // txtKHO
            // 
            this.txtKHO.Location = new System.Drawing.Point(81, 66);
            this.txtKHO.Name = "txtKHO";
            this.txtKHO.ReadOnly = true;
            this.txtKHO.Size = new System.Drawing.Size(124, 20);
            this.txtKHO.TabIndex = 10;
            // 
            // cboTENSACH
            // 
            this.cboTENSACH.FormattingEnabled = true;
            this.cboTENSACH.Location = new System.Drawing.Point(81, 31);
            this.cboTENSACH.Name = "cboTENSACH";
            this.cboTENSACH.Size = new System.Drawing.Size(124, 21);
            this.cboTENSACH.TabIndex = 8;
            this.cboTENSACH.SelectedIndexChanged += new System.EventHandler(this.cboMASACH_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Giá tiền:";
            // 
            // soluong
            // 
            this.soluong.AutoSize = true;
            this.soluong.Location = new System.Drawing.Point(6, 69);
            this.soluong.Name = "soluong";
            this.soluong.Size = new System.Drawing.Size(51, 13);
            this.soluong.TabIndex = 6;
            this.soluong.Text = "Tồn Kho:";
            // 
            // txtSOLUONG
            // 
            this.txtSOLUONG.Location = new System.Drawing.Point(289, 66);
            this.txtSOLUONG.Name = "txtSOLUONG";
            this.txtSOLUONG.Size = new System.Drawing.Size(95, 20);
            this.txtSOLUONG.TabIndex = 9;
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
            this.Column9,
            this.SOLUONGMUA,
            this.DELETE});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView2.Location = new System.Drawing.Point(0, 19);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(564, 153);
            this.dataGridView2.TabIndex = 25;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MASACH";
            this.Column7.HeaderText = "Mã Sách";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TENSACH";
            this.Column8.HeaderText = "Tên Sách";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "GIA";
            this.Column9.HeaderText = "Giá Tiền";
            this.Column9.Name = "Column9";
            // 
            // SOLUONGMUA
            // 
            this.SOLUONGMUA.HeaderText = "Số Lượng";
            this.SOLUONGMUA.Name = "SOLUONGMUA";
            // 
            // DELETE
            // 
            this.DELETE.FillWeight = 22F;
            this.DELETE.HeaderText = "Del";
            this.DELETE.Image = global::DoAn.Properties.Resources.OIP;
            this.DELETE.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.DELETE.Name = "DELETE";
            this.DELETE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DELETE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(483, 78);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(69, 29);
            this.btnHUY.TabIndex = 28;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnXUAT
            // 
            this.btnXUAT.Location = new System.Drawing.Point(306, 78);
            this.btnXUAT.Name = "btnXUAT";
            this.btnXUAT.Size = new System.Drawing.Size(171, 29);
            this.btnXUAT.TabIndex = 1;
            this.btnXUAT.Text = "Xuất Hóa Đơn";
            this.btnXUAT.UseVisualStyleBackColor = true;
            this.btnXUAT.Click += new System.EventHandler(this.btnXUAT_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Location = new System.Drawing.Point(541, 462);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(75, 30);
            this.btnTHOAT.TabIndex = 2;
            this.btnTHOAT.Text = "Thoát";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTHEMSACH
            // 
            this.btnTHEMSACH.Location = new System.Drawing.Point(445, 35);
            this.btnTHEMSACH.Name = "btnTHEMSACH";
            this.btnTHEMSACH.Size = new System.Drawing.Size(88, 36);
            this.btnTHEMSACH.TabIndex = 0;
            this.btnTHEMSACH.Text = "Thêm Sách ";
            this.btnTHEMSACH.UseVisualStyleBackColor = true;
            this.btnTHEMSACH.Click += new System.EventHandler(this.btnTHEMSACH_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Sách:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboTENSACH);
            this.groupBox2.Controls.Add(this.txtSOLUONG);
            this.groupBox2.Controls.Add(this.btnTHEMSACH);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtKHO);
            this.groupBox2.Controls.Add(this.txtGIA);
            this.groupBox2.Controls.Add(this.soluong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(52, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 107);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "VND";
            // 
            // txtNGAYLAP
            // 
            this.txtNGAYLAP.Location = new System.Drawing.Point(84, 91);
            this.txtNGAYLAP.Name = "txtNGAYLAP";
            this.txtNGAYLAP.ReadOnly = true;
            this.txtNGAYLAP.Size = new System.Drawing.Size(121, 20);
            this.txtNGAYLAP.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = " Khách Hàng:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Ngày Lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã đơn hàng:";
            // 
            // cboTENKH
            // 
            this.cboTENKH.FormattingEnabled = true;
            this.cboTENKH.Location = new System.Drawing.Point(84, 61);
            this.cboTENKH.Name = "cboTENKH";
            this.cboTENKH.Size = new System.Drawing.Size(121, 21);
            this.cboTENKH.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTHEMHD);
            this.groupBox1.Controls.Add(this.txtMAHD);
            this.groupBox1.Controls.Add(this.cboTENKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnHUY);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnXUAT);
            this.groupBox1.Controls.Add(this.txtNGAYLAP);
            this.groupBox1.Location = new System.Drawing.Point(52, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 124);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết ";
            // 
            // btnTHEMHD
            // 
            this.btnTHEMHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTHEMHD.Location = new System.Drawing.Point(306, 29);
            this.btnTHEMHD.Name = "btnTHEMHD";
            this.btnTHEMHD.Size = new System.Drawing.Size(246, 30);
            this.btnTHEMHD.TabIndex = 0;
            this.btnTHEMHD.Text = "Lập hóa đơn mới ";
            this.btnTHEMHD.UseVisualStyleBackColor = true;
            this.btnTHEMHD.Click += new System.EventHandler(this.btnTHEMHD_Click);
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(84, 29);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.ReadOnly = true;
            this.txtMAHD.Size = new System.Drawing.Size(121, 20);
            this.txtMAHD.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(262, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "Hóa Đơn ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(52, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 172);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn ";
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
            // frmHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTHOAT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmHOADON";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn ";
            this.Load += new System.EventHandler(this.HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGIA;
        private System.Windows.Forms.TextBox txtKHO;
        private System.Windows.Forms.ComboBox cboTENSACH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label soluong;
        private System.Windows.Forms.TextBox txtSOLUONG;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnXUAT;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnTHEMSACH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNGAYLAP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTENKH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTHEMHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONGMUA;
        private System.Windows.Forms.DataGridViewImageColumn DELETE;
    }
}