using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dealer_ASP.Models;
namespace Dealer_ASP.Controllers
{
    public class VehiculoController : Controller
    {
        // GET: Dealer/Index
        public ActionResult Index()
        {
            using(DBModel db = new DBModel())
            {
                return View(db.Vehiculo.ToList());
            }           
        }
   
        // GET: Dealer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dealer/Create
        [HttpPost]
        public ActionResult Create(Vehiculo vehiculo)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModel db = new DBModel())
                {
                    db.Vehiculo.Add(vehiculo);
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");               
            }
            catch
            {
                return View();
            }
        }
    }
}
