using QLSTKBUS;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmQLKH : Form
    {
        KhachHangBUS khBUS;
        public frmQLKH()
        {
            InitializeComponent();
            khBUS = new KhachHangBUS();
            txtMaKH.Text = khBUS.getNewMaSo();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            khBUS = new KhachHangBUS();
            datagridLoad();
        }

        private void datagridLoad()
        {
            List<KhachHangDTO> listSTK = khBUS.selectListLTK();

            if (listSTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }

            dgvSoTietKiem.Columns.Clear();
            dgvSoTietKiem.DataSource = null;

            dgvSoTietKiem.AutoGenerateColumns = false;
            dgvSoTietKiem.AllowUserToAddRows = false;
            dgvSoTietKiem.DataSource = listSTK;

            DataGridViewTextBoxColumn clSTT = new DataGridViewTextBoxColumn();
            clSTT.Name = "STT";
            clSTT.HeaderText = "STT";
            clSTT.CellTemplate.Value = "*";
            dgvSoTietKiem.Columns.Add(clSTT);

            DataGridViewTextBoxColumn clMaKH = new DataGridViewTextBoxColumn();
            clMaKH.Name = "MaKH";
            clMaKH.HeaderText = "Mã khách hàng";
            clMaKH.DataPropertyName = "StrMaKH";
            dgvSoTietKiem.Columns.Add(clMaKH);

            DataGridViewTextBoxColumn clHoTen = new DataGridViewTextBoxColumn();
            clHoTen.Name = "HoTen";
            clHoTen.HeaderText = "Họ tên";
            clHoTen.DataPropertyName = "StrHoTenKH";
            dgvSoTietKiem.Columns.Add(clHoTen);

            DataGridViewTextBoxColumn clCMND = new DataGridViewTextBoxColumn();
            clCMND.Name = "CMND";
            clCMND.HeaderText = "CMND";
            clCMND.DataPropertyName = "StrCMND";
            dgvSoTietKiem.Columns.Add(clCMND);

            DataGridViewTextBoxColumn clDiaChi = new DataGridViewTextBoxColumn();
            clDiaChi.Name = "DiaChi";
            clDiaChi.HeaderText = "Địa chỉ";
            clDiaChi.DataPropertyName = "StrDiaChi";
            dgvSoTietKiem.Columns.Add(clDiaChi);

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[dgvSoTietKiem.DataSource];// ho tro binding du lieu
            myCurrencyManager.Refresh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            KhachHangDTO kh = new KhachHangDTO();

            if(txtHoTen.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên");
                return;
            }

            if (txtCMND.Text.Length == 0)
            {
                MessageBox.Show("Nhập CMND");
                return;
            }

            if (txtDC.Text.Length == 0)
            {
                MessageBox.Show("Nhập địa chỉ");
                return;
            }

            if (txtHoTen.Text.Length == 0)
            {
                MessageBox.Show("Nhập họ tên");
                return;
            }
            kh.StrMaKH = txtMaKH.Text;
            kh.StrHoTenKH = txtHoTen.Text;
            kh.StrDiaChi = txtDC.Text;
            kh.StrCMND = txtCMND.Text;
            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = khBUS.them(kh);
            if (kq == false)
                MessageBox.Show("Thêm Khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
            {
                MessageBox.Show("Thêm Khách hàng thành công");
              
            }
            frmQLKH_Load(this, null);
            //--------------------------------------------
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //1. Map key primary from GUI
            KhachHangDTO kh = new KhachHangDTO();
            kh.StrMaKH = txtMaKH.Text;
            //2. Kiểm tra data hợp lệ

            //3. Xóa khỏi DB
            bool kq = khBUS.xoa(kh);
            if (kq == false)
                MessageBox.Show("Xóa khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Xóa khách hàng thành công");
            frmQLKH_Load(this, null);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            KhachHangDTO kh = new KhachHangDTO();
            kh.StrMaKH = txtMaKH.Text;
            kh.StrHoTenKH = txtHoTen.Text;
            kh.StrDiaChi = txtDC.Text;
            kh.StrCMND = txtCMND.Text;

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = khBUS.sua(kh);
            if (kq == false)
                MessageBox.Show("Sửa khách hàng thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sửa khách hàng thành công");

            frmQLKH_Load(this, null);
        }

        //private void TxtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || e.KeyChar == 8 || e.KeyChar == 32);
        //}

        private void TxtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

      

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                KhachHangDTO khachHang = khBUS.getKhachHang(txtMaKH.Text);
                txtHoTen.Text = khachHang.StrHoTenKH;
                txtCMND.Text = khachHang.StrCMND;
                txtDC.Text = khachHang.StrDiaChi;

            }
            catch
            {
                return;
            }
        }
    }
}
