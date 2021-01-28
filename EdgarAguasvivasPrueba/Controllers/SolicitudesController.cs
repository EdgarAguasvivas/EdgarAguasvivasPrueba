using EdgarAguasvivasPrueba.Data;
using EdgarAguasvivasPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult IndexSolicitudes(int estado = 0)
        {
            ViewBag.Estados = new SelectList(_data.Estados, "Id", "EstadoNombre");
            if (estado != 0) 
            {
                var query = _data.Solicitudes.Include(e => e.Persona).Include(e => e.Estado).Where(e => e.EstadoId == estado).ToList();              
                return View(query);
            }
            else
            {
            var query = _data.Solicitudes.Include(e => e.Persona).Include(e => e.Estado).ToList();
                return View(query);
            }
          
            
           
        }

      

        public IActionResult CreateSolicitud()
        {
            ViewBag.Estados = new SelectList(_data.Estados, "Id", "EstadoNombre");
            ViewBag.Personas = new SelectList( _data.Personas,"Id","Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult CreateSolicitud(Solicitud solicitudModel)
        {
            _data.Solicitudes.Add(solicitudModel);
            _data.SaveChanges();

            return RedirectToAction("IndexSolicitudes");
        }


        public IActionResult EditSolicitud(int? Id)
        {
            ViewBag.Estados = new SelectList(_data.Estados, "Id", "EstadoNombre");
            ViewBag.Personas = new SelectList(_data.Personas, "Id", "Nombre");
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
        public IActionResult DeleteSolicitud(int id)
        {
            var solicitud = _data.Solicitudes.Where(a => a.Id == id).FirstOrDefault();
            _data.Solicitudes.Remove(solicitud);
            _data.SaveChanges();
            return RedirectToAction("IndexSolicitudes");
        }

        public JsonResult filterSolicitudes(int estado)
        {
            var query = _data.Solicitudes.Include(e => e.Persona).Include(e => e.Estado).Where(e => e.EstadoId == estado).ToList();


            return Json(query);
        }
    }
}
