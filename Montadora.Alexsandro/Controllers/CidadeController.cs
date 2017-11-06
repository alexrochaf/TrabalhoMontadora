using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Montadora.Alexsandro.Models;
using Montadora.Alexsandro.Repository;

namespace Montadora.Alexsandro.Controllers
{
    public class CidadeController : Controller
    {
        // GET: Cidade
        public ActionResult Index()
        {
            return View(new Cidade().GetAll());
        }

        [HttpPost]
        public ActionResult AddCidade(Cidade cidade)
        {
            new Cidade().Add(cidade);

            return View("Index", new Cidade().GetAll());
        }

        public ActionResult DeletCidade(int id)
        {
            new Cidade().Delet(id);

            return View("Index", new Cidade().GetAll());
        }
    }
}