using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirmaYönetimPanelii.Controllers
{
    public class PortalUserController : Controller
    {
       PortalUserManager pm = new PortalUserManager(new EfPortalUserRepository());

        public IActionResult Index()
        {
            var categoryvalues = pm.GetList();
            return View(categoryvalues);

        }
        [HttpGet]
        public IActionResult PortalUserAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PortalUserAdd(PortalUser p)
        {
           PortalUser w = new PortalUser();

            w.Ad = p.Ad;
            w.Soyad = p.Soyad;          
            w.DogumTarihi = p.DogumTarihi;

            pm.TAdd(w);
            return RedirectToAction("Index", "PortalUser");
        }
    }
}
