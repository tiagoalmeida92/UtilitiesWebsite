using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Utilities_UI.Models;

namespace Utilities_UI.Controllers
{
    public class CopyPasteSharerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /PasteShare/
        public ActionResult Index()
        {
            return View();
        }

        // GET: /PasteShare/View/5
        public ActionResult View(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CopyPaste copyPaste = db.Pastes.Find(id);
            if (copyPaste == null)
            {
                return HttpNotFound();
            }
            return View(copyPaste);
        }

        // POST: /PasteShare/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Content")] CopyPaste copyPaste)
        {
            if (ModelState.IsValid)
            {
                db.Pastes.Add(copyPaste);
                db.SaveChanges();
                return RedirectToAction("View", new{id = copyPaste.Id});
            }

            return View(copyPaste);
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
