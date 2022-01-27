using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MernisService.KPSPublicSoapClient;

namespace FirmaYönetimPanelii.Controllers
{
    public class MernisController : Controller
    {
        MernisManager mm = new MernisManager(new EfMernisRepository());
       

        public IActionResult Index()
        {
           
            var categoryvalues = mm.GetList();
            return View(categoryvalues);
            
        }
        [HttpGet]
        public IActionResult MernisAdd()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult MernisAdd(Mernis p)
        {
            Mernis w = new Mernis();
            
            w.Ad = p.Ad;
            w.Soyad = p.Soyad;
            w.TcKimlikNo= p.TcKimlikNo;
            w.DogumTarihi = p.DogumTarihi;
           
            mm.TAdd(w);
            return RedirectToAction("Index", "Mernis");
        }
        //public Task<bool> TcKimlikDogrula(PortalUser portalUser)
        //{
        //    bool dogrulamaSonucu = false;
        //    try
        //    {
        //        var mernisClient = new Mernis.KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
        //        var tcKimlikDogrulamaServisResponse = mernisClient.TCKimlikNoDogrulaAsync(long.Parse(kullanici.TcKimlikNo), kullanici.Ad, kullanici.Soyad, kullanici.DogumTarihi.Year).GetAwaiter().GetResult();
        //        dogrulamaSonucu = tcKimlikDogrulamaServisResponse.Body.TCKimlikNoDogrulaResult;
        //    }
        //    catch (Exception ex)
        //    {
        //        dogrulamaSonucu = false;
        //    }
        //    return Task.FromResult(dogrulamaSonucu);
        //}
    }
}
