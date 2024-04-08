using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V20240408.EntidadesDeNegocio;
using V20240408.AccesoADatos;
using V20240408.LogicaDeNegocio;

namespace V20240408.UI.AppWebMVC.Controllers
{
    public class PersonaVController : Controller
    {
        // GET: PersonaVController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PersonaVController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonaVController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaVController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaVController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonaVController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaVController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PersonaVController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
