using ConsoleApptoWeb.Reposiotry;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApptoWeb.Controllers
{
    public class HomeController : Controller
    {
        public IAddRepository _addRepository;
        public IAddRepository _addRepository1;
        public HomeController(IAddRepository addRepository, IAddRepository addRepository1)
        {
            _addRepository = addRepository;
            _addRepository1 = addRepository1;
        }

        string s;
        public IActionResult Index()
        {
            //TempData["test"] = ;
            return RedirectToAction("Index2");
        }
        //_addRepository.getResult().ToString()

        public IActionResult Index2()
        {
            var r = _addRepository.getResult().ToString() + "(-)" + _addRepository1.getResult().ToString();
            return Content(r);
        }

    }
}
