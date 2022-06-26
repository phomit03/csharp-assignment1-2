using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlytiendienKH
{
    public class KhachHangVN : KhachHang
    {
        int MaKH { get; set; }
        int SoLuong { get; set; }
        double[] DonGia = { 1000, 1200, 1500, 2000 };
        int[] DinhMuc = { 50, 100, 200 };
        double ThanhTien { get; set; }
        string NgayHD { get; set; }
        string HoTenKH { get; set; }

        public string[] DoiTuongKH = { "Sinh hoạt", "Kinh doanh", "Sản xuất" };

        int x;

        public KhachHangVN()
        {
            MaKH = 0;
            SoLuong = 0;
            ThanhTien = 0;
            NgayHD = "";
            HoTenKH = "";
        }

        public KhachHangVN(int maKH, int soLuong, double[] donGia, int[] dinhMuc, double thanhTien, string ngayHD, string hoTenKH, string[] doiTuongKH, int x)
        {
            MaKH = maKH;
            SoLuong = soLuong;
            DonGia = donGia;
            DinhMuc = dinhMuc;
            ThanhTien = thanhTien;
            NgayHD = ngayHD;
            HoTenKH = hoTenKH;
            DoiTuongKH = doiTuongKH;
        }

        public double TinhTien()
        {
            if (SoLuong < DinhMuc[0])
            {
                return ThanhTien = SoLuong * DonGia[0];
            }
            else if (DinhMuc[0] <= SoLuong && SoLuong < DinhMuc[1])
            {
                return ThanhTien = SoLuong * DonGia[1];
            }
            else if (DinhMuc[1] <= SoLuong && SoLuong < DinhMuc[2])
            {
                return ThanhTien = SoLuong * DonGia[2];
            }
            else
            {
                return ThanhTien = DonGia[3] * DinhMuc[2] + (SoLuong - DinhMuc[2]) * DonGia[3];
            }
        }

        public void inputKH()
        {
            base.inputKH();
            Console.WriteLine("Nhập đối tượng khách hàng (0 = SinhHoat, 1 = KinhDoanh, 2 = SanXuat): ");
            x = int.Parse(Console.ReadLine());
        }

        public void outputKH()
        {
            base.outputKH();
            Console.WriteLine("Đối tượng khách hàng: " + DoiTuongKH[x]);
            Console.WriteLine("Tổng tiền: " + ThanhTien);        
        }

    }
}
