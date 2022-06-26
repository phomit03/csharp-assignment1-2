using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlytiendienKH
{

    public class Program
    {
        public static void Main(string[] args)
        {
            //nhap
            KhachHangVN khvn1 = new KhachHangVN();
            KhachHangVN khvn2 = new KhachHangVN();
            KhachHangVN khvn3 = new KhachHangVN();
            Console.WriteLine("Vui lòng nhập thông tin khách hàng Việt Nam 1.");
            khvn1.inputKH();
            Console.WriteLine("\nVui lòng nhập thông tin khách hàng Việt Nam 2.");
            khvn2.inputKH();
            Console.WriteLine("\nVui lòng nhập thông tin khách hàng Việt Nam 3.");
            khvn3.inputKH();


            KhachHangNuocNgoai khnn1 = new KhachHangNuocNgoai();
            Console.WriteLine("\nVui lòng nhập thông tin khách hàng nước ngoài 1.");
            khnn1.inputKH();
            KhachHangNuocNgoai khnn2 = new KhachHangNuocNgoai();
            Console.WriteLine("\nVui lòng nhập thông tin khách hàng nước ngoài 2.");
            khnn2.inputKH();
            KhachHangNuocNgoai khnn3 = new KhachHangNuocNgoai();
            Console.WriteLine("\nVui lòng nhập thông tin khách hàng nước ngoài 3.");
            khnn3.inputKH();

            //in
            Console.WriteLine("\nThông tin khách hàng Việt Nam 1: ");
            khvn1.TinhTien();
            khvn1.outputKH();
            Console.WriteLine("\nThông tin khách hàng Việt Nam 2: ");
            khvn2.TinhTien();
            khvn2.outputKH();
            Console.WriteLine("\nThông tin khách hàng Việt Nam 3: ");
            khvn3.TinhTien();
            khvn3.outputKH();

            Console.WriteLine("\nThông tin khách hàng nước ngoài 1: ");
            khnn1.TinhTien();
            khnn1.outputKH();
            Console.WriteLine("\nThông tin khách hàng nước ngoài 2: ");
            khnn2.TinhTien();
            khnn2.outputKH();
            Console.WriteLine("\nThông tin khách hàng nước ngoài 3: ");
            khnn3.TinhTien();
            khnn3.outputKH();

            //Tổng số lượng kw của từng loại khách hàng
            int sum1, sum2;
            sum1 = khvn1.SoLuong + khvn2.SoLuong + khvn3.SoLuong;
            sum2 = khnn1.SoLuong + khnn2.SoLuong + khnn3.SoLuong;
            Console.WriteLine("\nTong So Luong (KW) Dien cua KH Viet Nam: " + sum1 + " (KW)");
            Console.WriteLine("Tong So Luong (KW) Dien cua KH Nuoc Ngoai: " + sum2 + " (KW)");

            //Tính trung bình thành tiền của khách hàng người nước ngoài.
            KhachHangNuocNgoai dsknn1 = new KhachHangNuocNgoai();
            dsknn1.themKHNN(khnn1.TinhTien());
            dsknn1.themKHNN(khnn2.TinhTien());
            dsknn1.themKHNN(khnn3.TinhTien());
            dsknn1.trungBinh();
            Console.WriteLine("\nTrung bình tiền điện của KH Nước Ngoài: " + dsknn1.trungBinh() + "$");

            //Xuất ra các hoá đơn trong tháng 01 năm 2019 (a cả 2 loại khách hàng).
            Console.WriteLine("Các hoá đơn trong tháng 01 năm 2019 của KH Việt Nam: ");
            Console.WriteLine("Các hoá đơn trong tháng 01 năm 2019 của KH Nước Ngoài: ");
        }
    }
}