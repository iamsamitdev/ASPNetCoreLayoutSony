using ASPNetCoreLayout.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreLayout.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            // return "id="+id.ToString();
            
            // การส่ง (pass) ตัวแปรไปแสดงผลที่ View
            // เราสามารถทำได้ 3 คำสั่งด้วยกัน
            
            // 1. ผ่าน ViewBag.name
            // ViewBag.id = id;

            // 2. ผ่าน ViewData["name"]
            // ViewData["id"] = id;

            // 3. ผ่าน TempData["name"]
            TempData["id"] = id;

            return View();
        }

        // https://localhost:5001/Home/About
        public IActionResult About()
        {

            var userDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            ViewData["mytime"] = userDate;

            // ส่งข้อมูลแบบ List
            ArrayList Colors = new ArrayList();
            Colors.Add("Red");
            Colors.Add("Green");
            Colors.Add("Blue");
            Colors.Add("Yellow");
            Colors.Add("Pink");
            Colors.Add("Violet");

            ViewData["myColor"] = Colors;

            // return "About page";
            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
