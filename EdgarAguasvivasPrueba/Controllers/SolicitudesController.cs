using EdgarAguasvivasPrueba.Data;
using EdgarAguasvivasPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdgarAguasvivasPrueba.Controllers
{
    public class SolicitudesController : Controller
    {
        private DataContext _data;

        public SolicitudesController(DataContext datacontext)
        {
            _data = datacontext;
        }
        public IActionResult IndexSolicitudes()
        {
            return View(_data.Solicitudes.ToList());
        }

        public IActionResult CreateSolicitud()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSolicitud(Solicitud solicitudModel)
        {
            _data.Add(solicitudModel);
            _data.SaveChanges();

            return RedirectToAction("IndexSolicitudes");
        }


        public IActionResult EditSolicitud(int? Id)
        {
            return View(_data.Solicitudes.Where(e => e.Id == Id).FirstOrDefault());
        } 
        
        [HttpPost]
        public IActionResult EditSolicitud(Solicitud solicitudModel)
        {
            _data.Solicitudes.Update(solicitudModel);
            _data.SaveChanges();

            return RedirectToAction("IndexSolicitudes");
        }

        [HttpPost]
        public IActionResult EliminarSolicitud(int id)
        {
            var solicitud = _data.Solicitudes.Where(a => a.Id == id).FirstOrDefault();
            _data.Solicitudes.Remove(solicitud);
            _data.SaveChanges();
            return RedirectToAction("IndexSolicitudes");
        }
    }
}
