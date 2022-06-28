
using BusinessLayer.Abstract;
using EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.Models;

namespace PresentationLayer.Controllers
{
    public class BirimController : Controller
    {
        private readonly IBirimService _birimService;

        public BirimController(IBirimService birimService)
        {
            _birimService = birimService;
        }
      
        public IActionResult Index()
        {   var model = _birimService.GetAll();
            return View(model);
        }
        [HttpGet]
        public IActionResult BirimEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BirimEkle(Birim birim)
        {
            if (birim != null)
            {
                _birimService.Add(birim);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult BirimGuncelle(int id)
        {
            var birim = _birimService.GetBirimById(id);
            return View(birim);
        }
        [HttpPost]
        public IActionResult BirimGuncelle(Birim birim)
        {
            _birimService.Update(birim);
            return RedirectToAction("Index");
        }

        public ActionResult BirimSil(int id)
        {
            var birim = _birimService.GetBirimById(id);
            _birimService.Delete(birim);


            return RedirectToAction("Index"); ;
        }
    }
}
