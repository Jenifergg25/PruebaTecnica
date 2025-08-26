using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            ML.Login login = new ML.Login();
            return View(login);
        }
        [HttpPost]
        public ActionResult Login(ML.Login login)
        {
            ML.Result result = BL.Login.LoginUsuario(login);
            if (result.Correct)
            {
                return RedirectToAction("Clientes");
            }

            return RedirectToAction("Login");
        }
        [HttpGet]
        public ActionResult Clientes()
        {
            ML.Result result = BL.Clientes.GetAll();
            ML.Cliente cliente = new ML.Cliente();
            if (result.Correct)
            {
                cliente.Clientes = result.Objects;
            }
            return View(cliente);
        }
        [HttpGet]
        public ActionResult Add()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Add(ML.Cliente cliente)
        {
            //ML.Result result =
            return View();
        }
    }
}