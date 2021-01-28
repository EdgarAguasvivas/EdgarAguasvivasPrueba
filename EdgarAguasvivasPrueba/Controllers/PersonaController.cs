using EdgarAguasvivasPrueba.Data;
using EdgarAguasvivasPrueba.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EdgarAguasvivasPrueba.Controllers
{
    public class PersonaController : Controller
    {
        private DataContext _data;

        public PersonaController(DataContext datacontext)
        {
            _data = datacontext;
        }
        public IActionResult IndexPersonas()
        {
            return View(_data.Personas.ToList());
        }

        public IActionResult CreatePersona()
        {
            ViewBag.Estados = new SelectList(_data.Estados, "Id", "EstadoNombre");
            ViewBag.Personas = new SelectList(_data.Personas, "Id", "Nombre");
            return View();
        }

        [HttpPost]
        public IActionResult CreatePersona(Persona personaModel)
        {
            _data.Personas.Add(personaModel);
            _data.SaveChanges();

            return RedirectToAction("IndexPersonas");
        }


        public IActionResult EditPersona(int? Id)
        {
            return View(_data.Personas.Where(e => e.Id == Id).FirstOrDefault());
        }

        [HttpPost]
        public IActionResult EditPersona(Persona personaModel)
        {
            _data.Personas.Update(personaModel);
            _data.SaveChanges();

            return RedirectToAction("IndexPersonas");
        }

        [HttpPost]
        public IActionResult DeletePersona(int id)
        {
            var persona = _data.Personas.Where(a => a.Id == id).FirstOrDefault();
            _data.Personas.Remove(persona);
            _data.SaveChanges();
            return RedirectToAction("IndexPersonas");
        }
    }
}
