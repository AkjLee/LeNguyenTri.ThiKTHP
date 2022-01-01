
namespace QLCuaHangDiDong
{
    partial class frmThemSP
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXanNhan = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(150, 231);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(87, 26);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnXanNhan
            // 
            this.btnXanNhan.Location = new System.Drawing.Point(247, 231);
            this.btnXanNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXanNhan.Name = "btnXanNhan";
            this.btnXanNhan.Size = new System.Drawing.Size(87, 26);
            this.btnXanNhan.TabIndex = 1;
            this.btnXanNhan.Text = "Xác Nhận";
            this.btnXanNhan.UseVisualStyleBackColor = true;
            this.btnXanNhan.Click += new System.EventHandler(this.btnXanNhan_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(150, 147);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(184, 21);
            this.txtGia.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giá:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(150, 105);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(184, 21);
            this.txtTenSP.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(150, 186);
            this.txtLoaiSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(184, 21);
            this.txtLoaiSP.TabIndex = 18;
            this.txtLoaiSP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Loại sản phẩm:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(98, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "THÊM SẢN PHẨM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(150, 65);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(184, 21);
            this.txtMaSP.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // frmThemSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(380, 270);
            this.ControlBox = false;
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXanNhan);
            this.Controls.Add(this.btnHuy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmThemSP";
            this.Text = "frmThemSPcs";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXanNhan;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
    }
}