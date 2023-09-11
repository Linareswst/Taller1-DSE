using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LL191567Taller1.Models;

namespace LL191567Taller1.Controllers
{
    public class EmpleadosController : Controller
    {
        private EmpleadoDBContext db = new EmpleadoDBContext();

        // GET: Empleados
        public ActionResult Index(string buscarNombre, string buscarApellido, string codigoEmpleado)
        {
            var CodigoLst = new List<string>();
            var CodigoQry = from c in db.Empleados orderby c.Codigo select c.Codigo;

            CodigoLst.AddRange(CodigoQry.Distinct());
            ViewBag.codigoEmpleado = new SelectList(CodigoLst);

            var empleados = from e in db.Empleados select e;

            if(!String.IsNullOrEmpty(buscarNombre))
            {
                empleados = empleados.Where(s => s.Nombres.Contains(buscarNombre));
            }
            if (!String.IsNullOrEmpty(buscarApellido))
            {
                empleados = empleados.Where(a => a.Apellidos.Contains(buscarApellido));
            }
            if (!string.IsNullOrEmpty(codigoEmpleado))
            {
                empleados = empleados.Where(c => c.Codigo == codigoEmpleado);
            }
            
            return View(empleados);
        }

        // GET: Empleados/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // GET: Empleados/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleados/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Codigo,Nombres,Apellidos,FechaNacimiento,Direccion,Telefono,Cargo,SueldoBase,AñosLaborados,Bono")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Empleados.Add(empleado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empleado);
        }

        // GET: Empleados/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleados/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Codigo,Nombres,Apellidos,FechaNacimiento,Direccion,Telefono,Cargo,SueldoBase,AñosLaborados,Bono")] Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        // GET: Empleados/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empleado empleado = db.Empleados.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            return View(empleado);
        }

        // POST: Empleados/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Empleado empleado = db.Empleados.Find(id);
            db.Empleados.Remove(empleado);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
