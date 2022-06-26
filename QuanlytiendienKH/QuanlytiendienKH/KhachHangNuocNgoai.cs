using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace QuanlytiendienKH
{
    public class KhachHangNuocNgoai : KhachHang 
    {
        int MaKH { get; set; }
        int SoLuong { get; set; }
        double[] DonGia = { 1000, 1200, 1500, 2000 };
        int[] DinhMuc = { 50, 100, 200 };
        double ThanhTien { get; set; }
        string NgayHD { get; set; }
        string HoTenKH { get; set; }
        string QuocTich { get; set; }

        public KhachHangNuocNgoai()
        {
            MaKH = 0;
            SoLuong = 0;
            ThanhTien = 0;
            NgayHD = "";
            HoTenKH = "";
            QuocTich = "";
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
                return ThanhTien = SoLuong * DonGia[3];
            }
        }

        public void inputKH()
        {
            base.inputKH();
            Console.WriteLine("Nhập quốc tịch khách hàng: ");
            QuocTich = Console.ReadLine();
        }

        public void outputKH()
        {
            base.outputKH();
            Console.WriteLine("Quốc tịch khách hàng: " + QuocTich);
            Console.WriteLine("Tổng tiền: " + ThanhTien); 
        }

        ArrayList dskhnn = new ArrayList();
        public void themkhnn(double thanhtien)
        {
            dskhnn.Add(thanhtien);
        }
        public double trungbinh()
        {
            double trungbinh;
            double tong = 0;
            if (dskhnn.Count == 0)
            {
                return trungbinh = 0;
            }
            else
            {
                foreach (double thanhtien in dskhnn)
                {
                    tong += thanhtien;
                }
                return trungbinh = tong / dskhnn.Count;
            }
        }
    }
}
