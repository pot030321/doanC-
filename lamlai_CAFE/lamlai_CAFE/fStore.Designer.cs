namespace lamlai_CAFE
{
    partial class fStore
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpkTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkFrom = new System.Windows.Forms.DateTimePicker();
            this.cbViewFull = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgvStore = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbDVT = new System.Windows.Forms.TextBox();
            this.txbGiaNhap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNgayNhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbTenNL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbMaNL = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStore)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpkTo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpkFrom);
            this.panel1.Controls.Add(this.cbViewFull);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(497, 61);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 50);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "Xem";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Đến ngày :";
            // 
            // dtpkTo
            // 
            this.dtpkTo.Location = new System.Drawing.Point(263, 89);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(200, 22);
            this.dtpkTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian cần xem :";
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Location = new System.Drawing.Point(28, 89);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(200, 22);
            this.dtpkFrom.TabIndex = 1;
            // 
            // cbViewFull
            // 
            this.cbViewFull.AutoSize = true;
            this.cbViewFull.Location = new System.Drawing.Point(4, 20);
            this.cbViewFull.Name = "cbViewFull";
            this.cbViewFull.Size = new System.Drawing.Size(117, 20);
            this.cbViewFull.TabIndex = 1;
            this.cbViewFull.Text = "Xem tất cả Kho";
            this.cbViewFull.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Kho ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgvStore);
            this.panel2.Location = new System.Drawing.Point(13, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 289);
            this.panel2.TabIndex = 1;
            // 
            // dtgvStore
            // 
            this.dtgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStore.Location = new System.Drawing.Point(-1, 0);
            this.dtgvStore.Name = "dtgvStore";
            this.dtgvStore.RowHeadersWidth = 51;
            this.dtgvStore.RowTemplate.Height = 24;
            this.dtgvStore.Size = new System.Drawing.Size(669, 282);
            this.dtgvStore.TabIndex = 0;
            this.dtgvStore.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStore_CellClick);
            this.dtgvStore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStore_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbSoLuong);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txbDVT);
            this.panel3.Controls.Add(this.txbGiaNhap);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txbNgayNhap);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txbTenNL);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txbMaNL);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(680, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(423, 426);
            this.panel3.TabIndex = 2;
            // 
            // txbSoLuong
            // 
            this.txbSoLuong.Location = new System.Drawing.Point(142, 249);
            this.txbSoLuong.Name = "txbSoLuong";
            this.txbSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txbSoLuong.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Số Lượng :";
            // 
            // txbDVT
            // 
            this.txbDVT.Location = new System.Drawing.Point(142, 211);
            this.txbDVT.Name = "txbDVT";
            this.txbDVT.Size = new System.Drawing.Size(100, 22);
            this.txbDVT.TabIndex = 23;
            // 
            // txbGiaNhap
            // 
            this.txbGiaNhap.Location = new System.Drawing.Point(142, 168);
            this.txbGiaNhap.Name = "txbGiaNhap";
            this.txbGiaNhap.Size = new System.Drawing.Size(100, 22);
            this.txbGiaNhap.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Đơn vị tính :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Gía Nhập :";
            // 
            // txbNgayNhap
            // 
            this.txbNgayNhap.Location = new System.Drawing.Point(142, 131);
            this.txbNgayNhap.Name = "txbNgayNhap";
            this.txbNgayNhap.Size = new System.Drawing.Size(156, 22);
            this.txbNgayNhap.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ngày Nhập :";
            // 
            // txbTenNL
            // 
            this.txbTenNL.Location = new System.Drawing.Point(142, 98);
            this.txbTenNL.Name = "txbTenNL";
            this.txbTenNL.Size = new System.Drawing.Size(100, 22);
            this.txbTenNL.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tên Nguyên Liệu :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mã Nguyên Liệu :";
            // 
            // txbMaNL
            // 
            this.txbMaNL.Location = new System.Drawing.Point(142, 63);
            this.txbMaNL.Name = "txbMaNL";
            this.txbMaNL.Size = new System.Drawing.Size(100, 22);
            this.txbMaNL.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(117, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(223, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fStore";
            this.Text = "fStore";
            this.Load += new System.EventHandler(this.fStore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStore)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbViewFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpkTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgvStore;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbMaNL;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbTenNL;
        private System.Windows.Forms.TextBox txbSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbDVT;
        private System.Windows.Forms.TextBox txbGiaNhap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNgayNhap;
        private System.Windows.Forms.Button btnView;
    }
}