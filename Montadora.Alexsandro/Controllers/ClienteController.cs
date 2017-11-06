using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Montadora.Alexsandro.Models;

namespace Montadora.Alexsandro.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View(new Cliente().GetAll());
        }
    }
}