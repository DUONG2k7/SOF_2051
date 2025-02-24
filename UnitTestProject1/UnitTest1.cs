using DAL_QLBanHang;
using DTO_QLBanHang;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NvLogin_TC1()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "Fpoly@fe.edu.vn";
            nv.MatKhau = "SD1805";
            bool kq = login.NhanVienDangNhap(nv);
            Console.WriteLine("Ket qua: " + kq);
            Assert.IsFalse(kq);
        }

        [TestMethod]
        public void NvLogin_TC2()
        {
            DTO_NhanVien nv = new DTO_NhanVien();
            DAL_NhanVien login = new DAL_NhanVien();
            nv.EmailNV = "Fpoly@fe.edu.vn";
            nv.MatKhau = "12193117185192241182";
            bool kq = login.NhanVienDangNhap(nv);
            Console.WriteLine("Ket qua: " + kq);
            Assert.IsTrue(kq);
        }
    }
}
