using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Laboratorio.Alexsandro.Models;

namespace Laboratorio.Alexsandro.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Paciente
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscarPacientePorNome(string nome)
        {
            var listaPacientes = new Paciente().GetForName(nome);

            return PartialView("_PacienteList", listaPacientes);
        }
    }
}