using QLSTKBUS;
using QLSTKDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSTK
{
    public partial class frmPhieuRutTien : Form
    {
        public frmPhieuRutTien()
        {
            InitializeComponent();
        }
        PhieuRutTienBUS prtBUS;
        SoTietKiemBUS stkBUS;
        KhachHangBUS khBUS;

        private void frmPhieuRutTien_Load(object sender, EventArgs e)
        {
            prtBUS = new PhieuRutTienBUS();
            stkBUS = new SoTietKiemBUS();
            khBUS = new KhachHangBUS();
            txtMaSoPRT.Text = prtBUS.getNewMaSo();
            loadKhachhHang_Combobox();
            loadSTK_Combobox();
            txtNgayRut.Text = DateTime.Now.ToShortDateString();
            txtNgayRut.Enabled = false;
        }


        private void btnLuuVaXuatPhieu_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuRutTienDTO prt = new PhieuRutTienDTO();
            try
            {
                
                prt.StrMaSoPRT = txtMaSoPRT.Text;
                prt.StrMaSTK = cmbMaSoSTK.SelectedValue.ToString();
                prt.DSoTienRut = double.Parse(txtSoTienRut.Text);
                prt.StrNgayRut = DateTime.Now.Date.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kiểm tra lại dữ liệu");
                frmPhieuRutTien_Load(this,null);
                return;

            }
            SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.SelectedValue.ToString());

            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not
            if (stk.StrMaLTK.Equals("1"))
            {
                if (double.Parse(txtSoTienRut.Text) > stk.DSoDu)
                {
                    MessageBox.Show("Số tiền rút không hợp lệ");
                }
                else
                {
                    //3. Thêm vào DB
                    stk.DSoDu = stk.DSoDu - double.Parse(txtSoTienRut.Text);
                    if (stk.DSoDu == 0) stkBUS.dongSoTietKiem(stk);
                    else
                    {
                        bool kq = stkBUS.suaSoTietKiem(stk);
                        if (kq == false)
                            MessageBox.Show("Cập nhật sổ tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
                        else
                        {
                            MessageBox.Show("Cập nhật sổ tiết kiệm thành công.");
                            kq = prtBUS.them(prt);
                            if (kq == false)
                                MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
                            else
                            {
                                MessageBox.Show("Thêm Phiếu rút tiền thành công");
                            }
                        }
                    }

                }
            }
            else
            {
                stk.DSoDu = 0;
                bool kq = stkBUS.suaSoTietKiem(stk);
                if (kq == false)
                    MessageBox.Show("Cập nhật sổ tiết kiệm thất bại. Vui lòng kiểm tra lại dũ liệu");
                else
                {
                    bool k = stkBUS.dongSoTietKiem(stk);
                    if (k)
                    {
                        MessageBox.Show("Sổ đóng");
                    }

                    kq = prtBUS.them(prt);
                    if (kq == false)
                        MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
                    else
                    {
                        MessageBox.Show("Thêm Phiếu rút tiền thành công");
                    }
                }
            }
      
    //--------------------------------------------
}

        private void CmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maKh = cmbKhachHang.SelectedValue.ToString();
            loadSTK_Combobox();
        }

        private void CmbMaSoSTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maSTK = cmbMaSoSTK.SelectedValue.ToString();
        }

        private void TxtSoTienRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Đã huỷ, bạn có muốn đóng ứng dụng sổ tiết kiệm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            PhieuRutTienDTO prt = new PhieuRutTienDTO();
            if (txtSoTienRut.Text.Length == 0)
            {
                MessageBox.Show("Nhập số tiền rút");
                return;
            }

            prt.StrMaSoPRT = txtMaSoPRT.Text;
            prt.StrMaSTK = cmbMaSoSTK.SelectedValue.ToString();
            prt.DSoTienRut = double.Parse(txtSoTienRut.Text);
            prt.StrNgayRut = DateTime.Now.ToString();

            //----------------------------------------

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = prtBUS.them(prt);
            if (kq == false)
                MessageBox.Show("Thêm Phiếu rút tiền thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Thêm Phiếu rút tiền thành công");
            //--------------------------------------------
        }
        private void loadKhachhHang_Combobox()
        {

            List<KhachHangDTO> listLTK = khBUS.selectListLTK();

            if (listLTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LaoiTietKiem từ DB");
                return;
            }
            // Load Loai tiet kiem
            cmbKhachHang.DataSource = new BindingSource(listLTK, String.Empty);
            cmbKhachHang.DisplayMember = "StrHoTenKH";
            cmbKhachHang.ValueMember = "StrMaKH";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbKhachHang.DataSource];
            myCurrencyManager.Refresh();

            if (cmbKhachHang.Items.Count > 0)
            {
                cmbKhachHang.SelectedIndex = 0;
            }
        }
        private void loadSTK_Combobox()
        {

            List<SoTietKiemDTO> listLTK = stkBUS.selectSTKcuaKhachHang(cmbKhachHang.SelectedValue.ToString());

            if (listLTK == null)
            {
                MessageBox.Show("Có lỗi khi lấy LaoiTietKiem từ DB");
                return;
            }
            // Load Loai tiet kiem
            cmbMaSoSTK.DataSource = new BindingSource(listLTK, String.Empty);
            cmbMaSoSTK.DisplayMember = "StrMaSoSTK";
            cmbMaSoSTK.ValueMember = "StrMaSoSTK";
            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cmbMaSoSTK.DataSource];
            myCurrencyManager.Refresh();

            if (cmbMaSoSTK.Items.Count > 0)
            {
                cmbMaSoSTK.SelectedIndex = 0;
            }
        }

        //private void txtSoTienRut_Leave(object sender, EventArgs e)
        //{
        //    if (cmbMaSoSTK.Text == "1")
        //    {
        //        SoTietKiemDTO stk = stkBUS.getSoTietKiem(cmbMaSoSTK.Text);

        //        if (double.Parse(txtSoTienRut.Text) > double.Parse(stk.DSoDu.ToString()))
        //        {
        //            MessageBox.Show("Số tiền rút không hợp lệ");
        //        }

        //    }
        //}

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
