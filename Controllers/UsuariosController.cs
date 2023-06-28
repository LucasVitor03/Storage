using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Storage_Project.Entidades;

namespace Storage_Project.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly Contexto db;

        public UsuariosController(Contexto contexto)
        {
            db = contexto;
        }

        // GET: UsuariosController
        public ActionResult Index()
        {
            return View( db.USUARIOS.ToList() );
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuarios collection)
        {
            try
            {
                db.USUARIOS.Add(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View( db.USUARIOS.Where(a=> a.Id == id).FirstOrDefault() );
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Usuarios collection)
        {
            try
            {
                db.USUARIOS.Update(collection);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            db.USUARIOS.Remove(db.USUARIOS.Where(a => a.Id == id).FirstOrDefault());
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
