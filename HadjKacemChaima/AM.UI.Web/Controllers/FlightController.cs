using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.Web.Controllers
{
    public class FlightController : Controller
    {
        IServiceFlight sf;
        IServicePlane sp;
        public FlightController(IServiceFlight serviceFlight ,IServicePlane servicePlane)
        {
            this.sf = serviceFlight;
            this.sp = servicePlane;
                
        }

        // GET: FlightController
        public ActionResult Index(string Destination , string Departure) // lezem b nafs esm eli mawjouda f name mtaa input eli f formulaire 
        {
            //1ère methode 

            //if(Destination == null)
            //{
            //    var flights = sf.GetAll();
            //    // View () taayet lel vue o tabaath des methodes lel vue zedaa expl: View(flights)
            //    return View(flights);
            //}
            //else
            //{
            //    //where : recherche bel destination
            //    var flights = sf.GetAll().Where(f=> f.Destination.Contains(Destination));
            //    return View(flights);
            //}

            //2ème methode
            var flights = sf.GetAll();
            if (Destination != null && Departure != null)
            {
                flights = flights.Where(f => f.Destination.Contains(Destination) && f.Departure.Contains(Departure));
            }
            else if (Destination != null)
            {
                flights = flights.Where(f => f.Destination.Contains(Destination));
            }
            else if (Departure != null)
            {
                flights = flights.Where(f => f.Destination.Contains(Departure));
            }
            return View(flights);

        }

        // GET: FlightController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FlightController/Create
        public ActionResult Create()
        {
            //<option> obj1 </option> .... <option value=1> plane1 </option> donc besh yabaath l id + nom 
            //2ème paramètre atheka veleur à sélectioner et 3ème paramètre à afficher
            ViewBag.planes = new SelectList( sp.GetAll(),"PlaneId","Information");
            return View();
        }

        // POST: FlightController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Flight collection)
        {
            try
            {
                //insertion dans le code
                sf.Add(collection);
                //pour enregistrer dans la BD
                sf.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FlightController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FlightController/Edit/5
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

        // GET: FlightController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FlightController/Delete/5
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
