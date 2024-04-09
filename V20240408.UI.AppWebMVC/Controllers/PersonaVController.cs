using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using V20240408.EntidadesDeNegocio;
using V20240408.LogicaDeNegocio;

namespace V20240408.UI.AppWebMVC.Controllers
{
    public class PersonaVController : Controller
    {
        readonly PersonaBL _personaBL;

        public PersonaVController(PersonaBL personaBL)
        {
            _personaBL = personaBL;
        }
        // GET: PersonaVController
        public async Task <ActionResult> Index(PersonaV personaV)
        {
            var personas = await _personaBL.Buscar(personaV);
            return View(personas);
        }

        // GET: PersonaVController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personaV = await _personaBL.ObtenerPorId(new PersonaV { Id = id });
            return View(personaV);
        }

        // GET: PersonaVController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaVController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaV personaV)
        {
            try
            {
                await _personaBL.Crear(personaV);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaVController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personaV = await _personaBL.ObtenerPorId(new PersonaV { Id = id });
            return View(personaV);
        }

        // POST: PersonaVController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaV personaV)
        {
            try
            {
                await _personaBL.Modificar(personaV);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaVController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personaV = await _personaBL.ObtenerPorId(new PersonaV { Id = id });
            return View(personaV);
        }

        // POST: PersonaVController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaV personaV)
        {
            try
            {
                await _personaBL.Eliminar(personaV);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
