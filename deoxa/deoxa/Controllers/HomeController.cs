using deoxa.DAL;
using deoxa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace deoxa.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyDbContext db;
        public HomeController(MyDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Sliders.ToList());
        }


        //public IActionResult Test()
        //{
        //    Country ct = new Country();
        //    President ps = new President();

        //    db.Countries.FirstOrDefault(x => x.presidentId == ps.id).Name;

        //    ct.President.Fullname

        //    return View(db.Sliders.ToList());
        //}

        //public IActionResult Test()
        //{
        //    Category ct = new Category();

        //    foreach (ProjectToCategory item in ct.ProjectToCategoies)
        //    {
        //        item.Project.Name
        //    }
        //}
    }
}
