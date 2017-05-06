using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BUS;

namespace UngDung_QL_TaiKhoan
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        #region move form
        bool ismousedown = false; // Kiểm tra xem con trỏ chuột đã mousedown chưa
        Point mousedownPosition = new Point();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismousedown = true;
            mousedownPosition.X = e.X;
            mousedownPosition.Y = e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismousedown = false;
            Cursor cur = Cursors.Arrow;
            this.Cursor = cur;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismousedown == true)
            {
                Point newPoint = new Point();
                newPoint.X = this.Location.X + (e.X - mousedownPosition.X);
                newPoint.Y = this.Location.Y + (e.Y - mousedownPosition.Y);
                this.Location = newPoint;
            }
        }
        #endregion
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        TaiKhoanBUS taikhoanbus = new TaiKhoanBUS();

       

        private void btnDangNhap_Click_1(object sender, EventArgs e)
        {
             if (taikhoanbus.KTDangNhap(txtTaiKhoan.Text, txtMatKhau.Text) == true)
                        {
                            this.Hide();
                            frmQLTaiKhoan frm = new frmQLTaiKhoan();
                            frm.Show();
                        }
                        else
                            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
        }
    }
}
