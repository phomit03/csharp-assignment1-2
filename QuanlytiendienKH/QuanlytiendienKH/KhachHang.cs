using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlytiendienKH
{
    public class KhachHang
    {
        int MaKH { get; set; }
        int SoLuong { get; set; }
        double[] DonGia = { 1000, 1200, 1500, 2000 };
        int[] DinhMuc = { 50, 100, 200 };
        double ThanhTien { get; set; }
        string NgayHD { get; set; }
        string HoTenKH { get; set; }

        public KhachHang()
        {
            MaKH = 0;
            SoLuong = 0;
            ThanhTien = 0;
            NgayHD = "";
            HoTenKH = "";
        }

        public KhachHang(int maKH, int soLuong, double[] donGia, double thanhTien, String ngayHD, String hoTenKH)
        {
            MaKH = maKH;
            SoLuong = soLuong;
            DonGia = donGia;
            ThanhTien = thanhTien;
            NgayHD = ngayHD;
            HoTenKH = hoTenKH;
        }

        public void inputKH()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            int MaKH = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập tên khách hàng: ");
            HoTenKH = Console.ReadLine();
            Console.WriteLine("Nhập ngày xuất hoá đơn: ");
            NgayHD = Console.ReadLine();
            Console.WriteLine("Nhập số lượng tiêu thụ: ");
            int SoLuong = int.Parse(Console.ReadLine());
        }
        public void outputKH()
        {
            Console.WriteLine("Mã khách hàng: " + MaKH);
            Console.WriteLine("Tên khách hàng: " + HoTenKH);
            Console.WriteLine("Ngày xuất hoá đơn: " + NgayHD);
            Console.WriteLine("Số lượng tiêu thụ: " + SoLuong);
        }


    }
    
}
