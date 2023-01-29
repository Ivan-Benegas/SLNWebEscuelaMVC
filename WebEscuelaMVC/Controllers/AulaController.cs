using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {

        private readonly DBEscuelaMVCContext context;

        public AulaController(DBEscuelaMVCContext context)
        {
            this.context = context;
        }


        //GET aula
        //GET aula/index
        [HttpGet]
        public IActionResult Index()
        {
            List<Aula> medicos = context.Aulas.ToList();

            return View(medicos);
        }


        //GET aula/register
        [HttpGet]
        public IActionResult Create()
        {
            Aula aula = new Aula();

            return View("register", aula);
        }


        //POST aula/register
        [HttpPost]
        public IActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(aula);
            }
        }


        // GET aula/delete/1
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("delete", aula);
            }

        }


        //POST aula/delete/1
        /*[ActionName("delete")]
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
                return RedirectToAction("index");
            }
        }*/


        //GET aula/detalle/1
        [HttpGet]
        public IActionResult Details(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("detalle", aula);
            }

        }


        //GET aula/edit/1
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("edit", aula);
            }
        }


        //POST aula/edit/1
        /*[HttpPost]
        [ActionName("edit")]
        public IActionResult EditConfirmed(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Entry(aula).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else
            {
                return View(aula);
            }
        }*/

    }
}
