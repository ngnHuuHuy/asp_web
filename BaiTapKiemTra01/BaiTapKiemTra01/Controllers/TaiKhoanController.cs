using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class TaiKhoanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DangKy(TaiKhoanViewModel taikhoan)
        {
            if (taikhoan != null && taikhoan.MatKhau !=null && (taikhoan.MatKhau).Length>0)
            {
                taikhoan.MatKhau = taikhoan.MatKhau + "_chuoi_ma_hoa";
            }

            return View(taikhoan);
        }
    }
}
