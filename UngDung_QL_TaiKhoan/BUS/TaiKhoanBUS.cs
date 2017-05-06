using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class TaiKhoanBUS
    {
        QLTaiKhoanDataContext TaiKhoans = new QLTaiKhoanDataContext();

        //Ham kiem tra dang nhap
        //Neu tra ve 1 dong duy nhat la ket noi duoc voi CSDL con khong thong bao khong ket noi duoc voi CSDL
        public bool KTDangNhap(string tendangnhap, string matkhau)
        {
            int TaiKhoan = (from tk in TaiKhoans.TAIKHOANs
                            where tk.TaiKhoan == tendangnhap && tk.MatKhau == matkhau
                            select tk).Count();

            if(TaiKhoan==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
