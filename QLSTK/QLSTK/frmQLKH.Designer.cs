namespace QLSTK
{
    partial class frmQLKH
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.txtMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDC = new MaterialSkin.Controls.MaterialTextBox();
            this.txtCMND = new MaterialSkin.Controls.MaterialTextBox();
            this.txtHoTen = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSua = new MaterialSkin.Controls.MaterialButton();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.btnXoa = new MaterialSkin.Controls.MaterialButton();
            this.dgvSoTietKiem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(226, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(81, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(85, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "MaKH";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.AutoSize = true;
            this.txtDiaChi.BackColor = System.Drawing.Color.White;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDiaChi.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtDiaChi.Location = new System.Drawing.Point(81, 214);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(56, 20);
            this.txtDiaChi.TabIndex = 4;
            this.txtDiaChi.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(85, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "CMND";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.LightBlue;
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.txtMaKH);
            this.materialCard1.Controls.Add(this.txtDC);
            this.materialCard1.Controls.Add(this.txtCMND);
            this.materialCard1.Controls.Add(this.txtHoTen);
            this.materialCard1.Controls.Add(this.label2);
            this.materialCard1.Controls.Add(this.label3);
            this.materialCard1.Controls.Add(this.txtDiaChi);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(30, 89);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(587, 258);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 26;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Depth = 0;
            this.txtMaKH.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaKH.Location = new System.Drawing.Point(209, 16);
            this.txtMaKH.MaxLength = 50;
            this.txtMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(245, 50);
            this.txtMaKH.TabIndex = 24;
            this.txtMaKH.Text = "";
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // txtDC
            // 
            this.txtDC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDC.Depth = 0;
            this.txtDC.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtDC.Location = new System.Drawing.Point(209, 184);
            this.txtDC.MaxLength = 50;
            this.txtDC.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDC.Multiline = false;
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(245, 50);
            this.txtDC.TabIndex = 26;
            this.txtDC.Text = "";
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCMND.Depth = 0;
            this.txtCMND.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtCMND.Location = new System.Drawing.Point(209, 128);
            this.txtCMND.MaxLength = 50;
            this.txtCMND.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(245, 50);
            this.txtCMND.TabIndex = 25;
            this.txtCMND.Text = "";
            this.txtCMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCMND_KeyPress);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoTen.Depth = 0;
            this.txtHoTen.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(209, 72);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(245, 50);
            this.txtHoTen.TabIndex = 23;
            this.txtHoTen.Text = "";
            // 
            // btnSua
            // 
            this.btnSua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSua.Depth = 0;
            this.btnSua.DrawShadows = true;
            this.btnSua.HighEmphasis = true;
            this.btnSua.Icon = global::QLSTK.Properties.Resources.icons8_create_32;
            this.btnSua.Location = new System.Drawing.Point(355, 597);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(78, 36);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSua.UseAccentColor = false;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Depth = 0;
            this.btnThem.DrawShadows = true;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::QLSTK.Properties.Resources.icons8_add_book_32;
            this.btnThem.Location = new System.Drawing.Point(441, 597);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 36);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnXoa.Depth = 0;
            this.btnXoa.DrawShadows = true;
            this.btnXoa.HighEmphasis = true;
            this.btnXoa.Icon = global::QLSTK.Properties.Resources.icons8_close_window_4813;
            this.btnXoa.Location = new System.Drawing.Point(539, 597);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 36);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnXoa.UseAccentColor = false;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvSoTietKiem
            // 
            this.dgvSoTietKiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoTietKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoTietKiem.Location = new System.Drawing.Point(9, 355);
            this.dgvSoTietKiem.Name = "dgvSoTietKiem";
            this.dgvSoTietKiem.Size = new System.Drawing.Size(627, 202);
            this.dgvSoTietKiem.TabIndex = 31;
            // 
            // frmQLKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(659, 636);
            this.Controls.Add(this.dgvSoTietKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQLKH";
            this.Text = "Quản lý Khách Hàng";
            this.Load += new System.EventHandler(this.frmQLKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtDiaChi;
        private System.Windows.Forms.Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtDC;
        private MaterialSkin.Controls.MaterialTextBox txtCMND;
        private MaterialSkin.Controls.MaterialTextBox txtMaKH;
        private MaterialSkin.Controls.MaterialTextBox txtHoTen;
        private MaterialSkin.Controls.MaterialButton btnXoa;
        private MaterialSkin.Controls.MaterialButton btnThem;
        private MaterialSkin.Controls.MaterialButton btnSua;
        private System.Windows.Forms.DataGridView dgvSoTietKiem;
    }
}