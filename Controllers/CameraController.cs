using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebCamTest.Controllers
{
    public class CameraController : Controller
    {
        public IActionResult Capture()
        {
            return View();
        }
    }
}