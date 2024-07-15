using Microsoft.AspNetCore.Mvc;
using System.Linq;
using proje.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace proje.Controllers
{
    public class DepartController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PageDepartman()
        {
            var DepartList = c._GorevDepartmans.ToList();
            return View(DepartList);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {
            c._GorevDepartmans.Add(d);
            c.SaveChanges();
            return RedirectToAction("PageDepartman");
        }

        public IActionResult SilDepartman(int ID)
        {
            var d = c._GorevDepartmans.Find(ID);
            c._GorevDepartmans.Remove(d);
            c.SaveChanges();

            return RedirectToAction("PageDepartman");
        }

        public IActionResult GuncelleDepartman(int ID)
        {
            var d = c._GorevDepartmans.Find(ID);

            return View("GuncelleDepartman", d);
        }

        public IActionResult DepartmanGuncelle(departmanlar d)
        {
            var dep = c._GorevDepartmans.Find(d.ID);
            dep.DepartmanAd = d.DepartmanAd;
            dep.Detay = d.Detay;
            c.SaveChanges();

            return RedirectToAction("PageDepartman");
        }
    }
}
