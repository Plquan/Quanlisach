namespace DoAn
{
    partial class frmTONKHO
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTHONGKE = new System.Windows.Forms.Button();
            this.BTNTHOAT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNHAP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(6, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 319);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASACH";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSACH";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TENNXB";
            this.Column3.HeaderText = "Nhà xuất bản";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SOLUONG";
            this.Column4.HeaderText = "Số lượng tồn";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnTHONGKE
            // 
            this.btnTHONGKE.Location = new System.Drawing.Point(392, 71);
            this.btnTHONGKE.Name = "btnTHONGKE";
            this.btnTHONGKE.Size = new System.Drawing.Size(98, 30);
            this.btnTHONGKE.TabIndex = 15;
            this.btnTHONGKE.Text = "Thống kê";
            this.btnTHONGKE.UseVisualStyleBackColor = true;
            this.btnTHONGKE.Click += new System.EventHandler(this.btnTHONGKE_Click);
            // 
            // BTNTHOAT
            // 
            this.BTNTHOAT.Location = new System.Drawing.Point(857, 461);
            this.BTNTHOAT.Name = "BTNTHOAT";
            this.BTNTHOAT.Size = new System.Drawing.Size(75, 28);
            this.BTNTHOAT.TabIndex = 17;
            this.BTNTHOAT.Text = "Thoát ";
            this.BTNTHOAT.UseVisualStyleBackColor = true;
            this.BTNTHOAT.Click += new System.EventHandler(this.BTNTHOAT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(332, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "THỐNG KÊ SỐ LƯỢNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(34, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(904, 338);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // btnNHAP
            // 
            this.btnNHAP.Location = new System.Drawing.Point(508, 71);
            this.btnNHAP.Name = "btnNHAP";
            this.btnNHAP.Size = new System.Drawing.Size(75, 30);
            this.btnNHAP.TabIndex = 20;
            this.btnNHAP.Text = "Nhập sách";
            this.btnNHAP.UseVisualStyleBackColor = true;
            this.btnNHAP.Click += new System.EventHandler(this.btnNHAP_Click);
            // 
            // frmTONKHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 504);
            this.Controls.Add(this.btnNHAP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTHONGKE);
            this.Controls.Add(this.BTNTHOAT);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTONKHO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kho sách";
            this.Load += new System.EventHandler(this.frmTONKHO_Load);
            this.Click += new System.EventHandler(this.frmTONKHO_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTHONGKE;
        private System.Windows.Forms.Button BTNTHOAT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}