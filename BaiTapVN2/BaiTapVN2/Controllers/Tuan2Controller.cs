﻿using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan2Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Hữu Huy";
            ViewBag.MSSV = "1822040740";
            ViewData["Nam"] = "Năm 2024";
            return View();
        }
        public IActionResult MayTinh(int a, int b, string pheptinh)
        {
            double PhepTinh;
            if (pheptinh == "cong")
                PhepTinh = a + b;
            else if (pheptinh == "tru")
                PhepTinh = a - b;
            else if (pheptinh == "nhan")
                PhepTinh = a * b;
            else
                PhepTinh = (double)a / b;
            ViewBag.KetQua = PhepTinh;
            return View();
        }
        public IActionResult Profile()
        {
            ViewBag.HoTen = "Nguyễn Hữu Huy";
            ViewBag.MSSV = "1822040740";
            return View();
        }
    }
}