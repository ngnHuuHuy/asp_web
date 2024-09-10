using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap02()
        {
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "hp laser da nang",
                GiaBan = 6000,
                AnhMoTa = "/images/hp-laser-da-nang-laserjet-135a-4zb82a-thumb-600x600.jpg"
            };

            return View(sanpham);
        }
    }
}
