namespace QLSTK
{
    partial class frmTraCuu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbKhachHang = new System.Windows.Forms.Label();
            this.lbLoaiTietKiem = new System.Windows.Forms.Label();
            this.lbMaSo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvSoTietKiem = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsThongTinSoTietKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSurface.MaterialCard();
            this.txtMaKH = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaSo = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMaxSoDu = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMinSoDu = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbMaLoaiTietKiem = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard2 = new MaterialSurface.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.btnTraCuu = new MaterialSkin.Controls.MaterialButton();
            this.btnThoat = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbKhachHang
            // 
            this.lbKhachHang.AutoSize = true;
            this.lbKhachHang.BackColor = System.Drawing.Color.White;
            this.lbKhachHang.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbKhachHang.Location = new System.Drawing.Point(11, 98);
            this.lbKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKhachHang.Name = "lbKhachHang";
            this.lbKhachHang.Size = new System.Drawing.Size(110, 19);
            this.lbKhachHang.TabIndex = 11;
            this.lbKhachHang.Text = "Mã khách hàng";
            // 
            // lbLoaiTietKiem
            // 
            this.lbLoaiTietKiem.AutoSize = true;
            this.lbLoaiTietKiem.BackColor = System.Drawing.Color.White;
            this.lbLoaiTietKiem.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbLoaiTietKiem.Location = new System.Drawing.Point(21, 153);
            this.lbLoaiTietKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLoaiTietKiem.Name = "lbLoaiTietKiem";
            this.lbLoaiTietKiem.Size = new System.Drawing.Size(100, 19);
            this.lbLoaiTietKiem.TabIndex = 10;
            this.lbLoaiTietKiem.Text = "Loại tiết kiệm";
            // 
            // lbMaSo
            // 
            this.lbMaSo.AutoSize = true;
            this.lbMaSo.BackColor = System.Drawing.Color.White;
            this.lbMaSo.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbMaSo.Location = new System.Drawing.Point(72, 41);
            this.lbMaSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSo.Name = "lbMaSo";
            this.lbMaSo.Size = new System.Drawing.Size(49, 19);
            this.lbMaSo.TabIndex = 9;
            this.lbMaSo.Text = "Mã sổ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(230, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách sổ tiết kiệm";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTuNgay.Location = new System.Drawing.Point(108, 43);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(119, 26);
            this.dtpTuNgay.TabIndex = 18;
            this.dtpTuNgay.Value = new System.DateTime(1990, 6, 1, 22, 47, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(18, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ngày mở sổ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(18, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Từ ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Đến ngày";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpToiNgay.Location = new System.Drawing.Point(108, 70);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(119, 26);
            this.dtpToiNgay.TabIndex = 23;
            // 
            // dgvSoTietKiem
            // 
            this.dgvSoTietKiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvSoTietKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoTietKiem.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSoTietKiem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSoTietKiem.Location = new System.Drawing.Point(17, 287);
            this.dgvSoTietKiem.Name = "dgvSoTietKiem";
            this.dgvSoTietKiem.Size = new System.Drawing.Size(627, 202);
            this.dgvSoTietKiem.TabIndex = 30;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThongTinSoTietKiem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 26);
            // 
            // tsThongTinSoTietKiem
            // 
            this.tsThongTinSoTietKiem.Name = "tsThongTinSoTietKiem";
            this.tsThongTinSoTietKiem.Size = new System.Drawing.Size(189, 22);
            this.tsThongTinSoTietKiem.Text = "Thông tin sổ tiết kiệm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.ForeColor = System.Drawing.Color.DarkCyan;
            this.label8.Location = new System.Drawing.Point(73, 217);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số dư";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.CardColor = System.Drawing.Color.White;
            this.materialCard1.Controls.Add(this.txtMaKH);
            this.materialCard1.Controls.Add(this.txtMaSo);
            this.materialCard1.Controls.Add(this.txtMaxSoDu);
            this.materialCard1.Controls.Add(this.txtMinSoDu);
            this.materialCard1.Controls.Add(this.cmbMaLoaiTietKiem);
            this.materialCard1.Controls.Add(this.lbMaSo);
            this.materialCard1.Controls.Add(this.lbLoaiTietKiem);
            this.materialCard1.Controls.Add(this.lbKhachHang);
            this.materialCard1.Controls.Add(this.label8);
            this.materialCard1.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard1.Location = new System.Drawing.Point(19, 27);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard1.MouseInteract = false;
            this.materialCard1.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Radius = 8;
            this.materialCard1.ShawdowDepth = 2;
            this.materialCard1.ShawdowOpacity = 50;
            this.materialCard1.Size = new System.Drawing.Size(376, 252);
            this.materialCard1.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard1.TabIndex = 31;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaKH.Depth = 0;
            this.txtMaKH.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaKH.Location = new System.Drawing.Point(145, 67);
            this.txtMaKH.MaxLength = 50;
            this.txtMaKH.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(206, 50);
            this.txtMaKH.TabIndex = 32;
            this.txtMaKH.Text = "";
            // 
            // txtMaSo
            // 
            this.txtMaSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaSo.Depth = 0;
            this.txtMaSo.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaSo.Location = new System.Drawing.Point(145, 12);
            this.txtMaSo.MaxLength = 50;
            this.txtMaSo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaSo.Multiline = false;
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(206, 50);
            this.txtMaSo.TabIndex = 31;
            this.txtMaSo.Text = "";
            // 
            // txtMaxSoDu
            // 
            this.txtMaxSoDu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaxSoDu.Depth = 0;
            this.txtMaxSoDu.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMaxSoDu.Location = new System.Drawing.Point(251, 186);
            this.txtMaxSoDu.MaxLength = 50;
            this.txtMaxSoDu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMaxSoDu.Multiline = false;
            this.txtMaxSoDu.Name = "txtMaxSoDu";
            this.txtMaxSoDu.Size = new System.Drawing.Size(100, 50);
            this.txtMaxSoDu.TabIndex = 30;
            this.txtMaxSoDu.Text = "";
            // 
            // txtMinSoDu
            // 
            this.txtMinSoDu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMinSoDu.Depth = 0;
            this.txtMinSoDu.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtMinSoDu.Location = new System.Drawing.Point(145, 186);
            this.txtMinSoDu.MaxLength = 50;
            this.txtMinSoDu.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMinSoDu.Multiline = false;
            this.txtMinSoDu.Name = "txtMinSoDu";
            this.txtMinSoDu.Size = new System.Drawing.Size(100, 50);
            this.txtMinSoDu.TabIndex = 29;
            this.txtMinSoDu.Text = "";
            // 
            // cmbMaLoaiTietKiem
            // 
            this.cmbMaLoaiTietKiem.AutoResize = false;
            this.cmbMaLoaiTietKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbMaLoaiTietKiem.Depth = 0;
            this.cmbMaLoaiTietKiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMaLoaiTietKiem.DropDownHeight = 174;
            this.cmbMaLoaiTietKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaLoaiTietKiem.DropDownWidth = 121;
            this.cmbMaLoaiTietKiem.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbMaLoaiTietKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbMaLoaiTietKiem.FormattingEnabled = true;
            this.cmbMaLoaiTietKiem.IntegralHeight = false;
            this.cmbMaLoaiTietKiem.ItemHeight = 43;
            this.cmbMaLoaiTietKiem.Location = new System.Drawing.Point(145, 124);
            this.cmbMaLoaiTietKiem.MaxDropDownItems = 4;
            this.cmbMaLoaiTietKiem.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbMaLoaiTietKiem.Name = "cmbMaLoaiTietKiem";
            this.cmbMaLoaiTietKiem.Size = new System.Drawing.Size(206, 49);
            this.cmbMaLoaiTietKiem.TabIndex = 28;
            this.cmbMaLoaiTietKiem.SelectedIndexChanged += new System.EventHandler(this.CmbMaLoaiTietKiem_SelectedIndexChanged);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.CardColor = System.Drawing.Color.White;
            this.materialCard2.Controls.Add(this.label4);
            this.materialCard2.Controls.Add(this.dtpToiNgay);
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.dtpTuNgay);
            this.materialCard2.Controls.Add(this.label5);
            this.materialCard2.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialCard2.Location = new System.Drawing.Point(405, 27);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(5);
            this.materialCard2.MouseInteract = false;
            this.materialCard2.MouseState = MaterialSurface.MouseState.OUT;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Radius = 8;
            this.materialCard2.ShawdowDepth = 2;
            this.materialCard2.ShawdowOpacity = 50;
            this.materialCard2.Size = new System.Drawing.Size(239, 115);
            this.materialCard2.Style = MaterialSurface.MaterialCard.CardStyle.Elevated;
            this.materialCard2.TabIndex = 33;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialCard2);
            this.materialCard3.Controls.Add(this.dgvSoTietKiem);
            this.materialCard3.Controls.Add(this.materialCard1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(9, 111);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(656, 502);
            this.materialCard3.TabIndex = 31;
            // 
            // btnTraCuu
            // 
            this.btnTraCuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTraCuu.Depth = 0;
            this.btnTraCuu.DrawShadows = true;
            this.btnTraCuu.HighEmphasis = true;
            this.btnTraCuu.Icon = global::QLSTK.Properties.Resources.icons8_view_32;
            this.btnTraCuu.Location = new System.Drawing.Point(445, 622);
            this.btnTraCuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTraCuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTraCuu.Name = "btnTraCuu";
            this.btnTraCuu.Size = new System.Drawing.Size(110, 36);
            this.btnTraCuu.TabIndex = 33;
            this.btnTraCuu.Text = "Tra cứu";
            this.btnTraCuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTraCuu.UseAccentColor = false;
            this.btnTraCuu.UseVisualStyleBackColor = true;
            this.btnTraCuu.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThoat.Depth = 0;
            this.btnThoat.DrawShadows = true;
            this.btnThoat.HighEmphasis = true;
            this.btnThoat.Icon = global::QLSTK.Properties.Resources.icons8_exit_32;
            this.btnThoat.Location = new System.Drawing.Point(563, 622);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThoat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 36);
            this.btnThoat.TabIndex = 34;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThoat.UseAccentColor = false;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmTraCuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(659, 636);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTraCuu);
            this.Controls.Add(this.materialCard3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmTraCuu";
            this.Text = "Tra cứu sổ";
            this.Load += new System.EventHandler(this.frmTraCuu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoTietKiem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.materialCard3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKhachHang;
        private System.Windows.Forms.Label lbLoaiTietKiem;
        private System.Windows.Forms.Label lbMaSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private System.Windows.Forms.DataGridView dgvSoTietKiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem tsThongTinSoTietKiem;
        private MaterialSurface.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox txtMinSoDu;
        private MaterialSkin.Controls.MaterialComboBox cmbMaLoaiTietKiem;
        private MaterialSkin.Controls.MaterialTextBox txtMaxSoDu;
        private MaterialSurface.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialButton btnTraCuu;
        private MaterialSkin.Controls.MaterialButton btnThoat;
        private MaterialSkin.Controls.MaterialTextBox txtMaKH;
        private MaterialSkin.Controls.MaterialTextBox txtMaSo;
    }
}