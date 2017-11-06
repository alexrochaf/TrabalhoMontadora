using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio.Alexsandro.Enum;
using Laboratorio.Alexsandro.Models;

namespace Laboratorio.Alexsandro.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Index()
        {
            return View(new Cidade().GetAll());
        }

        //public ActionResult ListaPorFiltro(EEstado estado)
        //{

        //}

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Cidade cidade)
        {
            cidade.Save();
            return View();
        }

        public ActionResult Alterar(int id)
        {
            return View(new Cidade().GetById(id));
        }

        [HttpPost]
        public ActionResult Alterar(Cidade cidade)
        {
            cidade.Save();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(new Cidade().GetById(id));
        }

        [HttpPost]
        public ActionResult Delete(Cidade cidade)
        {
            cidade.Delete(cidade.Id);
            return RedirectToAction("Index");
        }
    }
}