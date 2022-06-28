using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PresentationLayer.Controllers
{
    public class PersonelController : Controller
    {
        private readonly IPersonelService _personelService;
        private readonly IBirimService _birimService;
        public PersonelController(IPersonelService personelService, IBirimService birimService)
        {
            _personelService = personelService;
            _birimService = birimService;
        }
        [HttpGet]
        public IActionResult Index(int? id)
        {
            var liste = (List<Personel>)null;
            if (id == null)
                liste = _personelService.GetAll();
            else
                liste = _personelService.GetAllByBirim((int)id);
            return View(liste);
        }


        [HttpGet]
        public IActionResult PersonelEkle()
        {
            List<SelectListItem> birimListesi = (from x in _birimService.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.BirimAd,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            ViewBag.bl = birimListesi;
            return View();
        }
        [HttpPost]
        public IActionResult PersonelEkle(Personel personel)
        {
            if (personel != null)
            {
                personel.Birim = _birimService.GetBirimById((int)personel.BirimId);
                _personelService.Add(personel);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult PersonelGuncelle(int id)
        {
            List<SelectListItem> birimListesi = (from x in _birimService.GetAll()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.BirimAd,
                                                     Value = x.Id.ToString()
                                                 }).ToList();
            ViewBag.bl = birimListesi;
            var personel = _personelService.GetPersonelById(id);
            return View(personel);
        }
        [HttpPost]
        public IActionResult PersonelGuncelle(Personel personel)
        {
            _personelService.Update(personel);
            return RedirectToAction("Index");
        }

        public IActionResult PersonelSil(int id)
        {
            var personel = _personelService.GetPersonelById(id);
            _personelService.Delete(personel);
            return RedirectToAction("Index");
        }
    }
}
