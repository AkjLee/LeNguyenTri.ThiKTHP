
namespace QLCuaHangDiDong
{
    partial class frmQLSP
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SanPhambindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBLLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysdiagramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sanPhamBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.maSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhambindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBLLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysdiagramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSPDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.giaDataGridViewTextBoxColumn,
            this.loaiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sanPhamBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(156, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(18, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Đăng Xuất";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(318, 106);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(427, 106);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(530, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 61);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quản lý sản phẩm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 55);
            this.button3.TabIndex = 6;
            this.button3.Text = "Quản lý hóa đơn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 293);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(121, 60);
            this.button4.TabIndex = 7;
            this.button4.Text = "Quản lý khách hàng";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(22, 363);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(10, 13);
            this.lbl.TabIndex = 8;
            this.lbl.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(318, 79);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(136, 20);
            this.txtTenSP.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(479, 80);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(126, 20);
            this.txtGia.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(98, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(377, 31);
            this.label3.TabIndex = 13;
            this.label3.Text = "QUẢN LÝ THIẾT BỊ DI ĐỘNG";
            // 
            // sanPhamBLLBindingSource
            // 
            this.sanPhamBLLBindingSource.DataSource = typeof(QLCuaHangDiDong.BLL.SanPhamBLL);
            // 
            // sysdiagramBindingSource
            // 
            this.sysdiagramBindingSource.DataSource = typeof(QLCuaHangDiDong.DAL.sysdiagram);
            // 
            // sanPhamBindingSource1
            // 
            this.sanPhamBindingSource1.DataSource = typeof(QLCuaHangDiDong.DAL.SanPham);
            // 
            // maSPDataGridViewTextBoxColumn
            // 
            this.maSPDataGridViewTextBoxColumn.DataPropertyName = "MaSP";
            this.maSPDataGridViewTextBoxColumn.HeaderText = "Mã Sản phẩm";
            this.maSPDataGridViewTextBoxColumn.Name = "maSPDataGridViewTextBoxColumn";
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            // 
            // giaDataGridViewTextBoxColumn
            // 
            this.giaDataGridViewTextBoxColumn.DataPropertyName = "Gia";
            this.giaDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giaDataGridViewTextBoxColumn.Name = "giaDataGridViewTextBoxColumn";
            // 
            // loaiDataGridViewTextBoxColumn
            // 
            this.loaiDataGridViewTextBoxColumn.DataPropertyName = "Loai";
            this.loaiDataGridViewTextBoxColumn.HeaderText = "Loại sản phẩm";
            this.loaiDataGridViewTextBoxColumn.Name = "loaiDataGridViewTextBoxColumn";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(164, 80);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(118, 20);
            this.txtMaSP.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // frmQLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(609, 447);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmQLSP";
            this.Text = "frmQLSP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SanPhambindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBLLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysdiagramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanPhamBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource SanPhambindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sanPhamBindingSource1;
        private System.Windows.Forms.BindingSource sanPhamBLLBindingSource;
        private System.Windows.Forms.BindingSource sysdiagramBindingSource;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label4;
    }
}