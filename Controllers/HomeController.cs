using Microsoft.AspNetCore.Mvc;
using Samed_Koç_Fİnal.Models;
using System.Diagnostics;

namespace Samed_Koç_Fİnal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() //fonksiyon access modifier erişim belirleyici
        {
            return View(); //fonksiyon ismi:index //
        }
        public IActionResult Hastalar()
        {
            // Tek Bir Veri Gönderilecekse
            /*
             Hasta HastaNesne = new Hasta();
             HastaNesne.Id = 1;
             HastaNesne.AdSoyad = "Samed Koc"; 
             HastaNesne.TCKimlikNo = "11111111111";
             HastaNesne.Yas = 20;
                        return View(HastaNesne);
           */
            // Birden Fazla Veri  Gönderilmek İstenirse 
            List<Hasta> hastalarListesi = new List<Hasta>()
    {
        new Hasta { Id = 1, AdSoyad = "Samed Koç", TCKimlikNo = "11111111111", Yas = 25 },
        new Hasta { Id = 2, AdSoyad = "Melih Sezgin", TCKimlikNo = "22222222222", Yas = 20 },
        new Hasta { Id = 3, AdSoyad = "Serkan Gökel", TCKimlikNo = "33333333333", Yas = 30 },
        new Hasta { Id = 4, AdSoyad = "Ferhat Çırrık", TCKimlikNo = "44444444444", Yas = 22 },
        new Hasta { Id = 5, AdSoyad = "Hasan Arslan", TCKimlikNo = "55555555555", Yas = 50 }
    }; // Liste burada bitti ve noktalı virgül ile kapattık

            return View(hastalarListesi); // Listeyi View'a gönderiyoruz
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
