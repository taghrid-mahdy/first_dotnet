
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using code.Models;

namespace code.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var Movie = new Movie(){ Name = "shrek" };
            return Content(Movie.Name);
        }
    }
}
