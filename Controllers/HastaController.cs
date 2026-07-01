using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Samed_Koç_Fİnal.Data;
using Samed_Koç_Fİnal.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Samed_Koç_Fİnal.Controllers
{
    public class HastaController : Controller
    {
        private readonly ProjeDBcontext _context;

        public HastaController(ProjeDBcontext context)
        {
            _context = context;
        }

        // Hastaları Listele
        public IActionResult Index()
        {
            List<Hasta> Hastalar = _context.Hastalar.ToList();
            return View(Hastalar);
        }

        // Hasta Ekle Sayfası
        [HttpGet]
        public IActionResult HastaEkle()
        {
            return View();
        }

        // Hasta Ekle
        [HttpPost]
        public IActionResult HastaEkle(Hasta hasta)
        {
            if (string.IsNullOrWhiteSpace(hasta.AdSoyad))
            {
                TempData["Uyarı Mesajı"] = "Ad Soyad boş bırakılamaz!";
                return View(hasta);
            }

            if (string.IsNullOrWhiteSpace(hasta.TCKimlikNo) || hasta.TCKimlikNo.Length != 11)
            {
                TempData["Uyarı Mesajı"] = "TC Kimlik No 11 haneli olmalıdır!";
                return View(hasta);
            }

            if (hasta.Yas < 15)
            {
                TempData["Uyarı Mesajı"] = "Hasta yaşı en az 15 olmalıdır!";
                return View(hasta);
            }

            string temizlenenAd = hasta.AdSoyad.Trim();

            bool isimVarMi = _context.Hastalar
                .AsEnumerable() 
                .Any(h => string.Equals(h.AdSoyad.Trim(), temizlenenAd, StringComparison.CurrentCultureIgnoreCase));

            if (isimVarMi)
            {
                TempData["Uyarı Mesajı"] = "Bu isim ve soyisimle yeni bir kayıt oluşturulamaz, hasta zaten sistemde kayıtlı!";
                return View(hasta);
            }

            // Aynı TC kontrolü
            if (_context.Hastalar.Any(h => h.TCKimlikNo == hasta.TCKimlikNo))
            {
                TempData["Uyarı Mesajı"] = "Bu TC Kimlik numarası zaten sistemde kayıtlı!";
                return View(hasta);
            }

            _context.Hastalar.Add(hasta);
            _context.SaveChanges();

            TempData["Uyarı Mesajı"] = "✔ Başarıyla Kaydedildi";
            return RedirectToAction("Index");
        }

        // Düzenleme Sayfası
        [HttpGet]
        public IActionResult hastadüzenle(int id)
        {
            var hasta = _context.Hastalar.Find(id);

            if (hasta == null)
            {
                TempData["Uyarı Mesajı"] = "Hasta bulunamadı!";
                return RedirectToAction("Index");
            }

            return View(hasta);
        }

        // Düzenleme İşlemi
        [HttpPost]
        public IActionResult hastadüzenle(Hasta hasta)
        {
            var mevcutHasta = _context.Hastalar.Find(hasta.Id);

            if (mevcutHasta == null)
            {
                TempData["Uyarı Mesajı"] = "Hasta bulunamadı!";
                return RedirectToAction("Index");
            }

            if (string.IsNullOrWhiteSpace(hasta.AdSoyad))
            {
                TempData["Uyarı Mesajı"] = "Ad Soyad boş bırakılamaz!";
                return View(hasta);
            }

            if (string.IsNullOrWhiteSpace(hasta.TCKimlikNo) || hasta.TCKimlikNo.Length != 11)
            {
                TempData["Uyarı Mesajı"] = "TC Kimlik No 11 haneli olmalıdır!";
                return View(hasta);
            }

            if (hasta.Yas < 15)
            {
                TempData["Uyarı Mesajı"] = "Hasta yaşı en az 15 olmalıdır!";
                return View(hasta);
            }

            string temizlenenAd = hasta.AdSoyad.Trim();

            bool baskaİsimVarMi = _context.Hastalar
                .AsEnumerable()
                .Any(h => string.Equals(h.AdSoyad.Trim(), temizlenenAd, StringComparison.CurrentCultureIgnoreCase)
                     && h.Id != hasta.Id);

            if (baskaİsimVarMi)
            {
                TempData["Uyarı Mesajı"] = "Bu isimde başka bir hasta kaydı zaten var!";
                return View(hasta);
            }

            if (_context.Hastalar.Any(h => h.TCKimlikNo == hasta.TCKimlikNo && h.Id != hasta.Id))
            {
                TempData["Uyarı Mesajı"] = "Bu TC Kimlik numarası başka bir hastaya ait!";
                return View(hasta);
            }

            mevcutHasta.AdSoyad = hasta.AdSoyad;
            mevcutHasta.TCKimlikNo = hasta.TCKimlikNo;
            mevcutHasta.Yas = hasta.Yas;

            _context.SaveChanges();

            TempData["Uyarı Mesajı"] = "✔ Başarıyla Güncellendi";
            return RedirectToAction("Index");
        }

        // Hasta Sil
        [HttpPost]
        public IActionResult HastaSil(int id)
        {
            var hasta = _context.Hastalar.Find(id);

            if (hasta != null)
            {
                _context.Hastalar.Remove(hasta);
                _context.SaveChanges();

                TempData["Uyarı Mesajı"] = "✔ Kayıt başarıyla silindi.";
            }

            return RedirectToAction("Index");
        }
    }
}