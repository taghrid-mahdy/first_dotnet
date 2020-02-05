using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using code.Models;
using code.ViewModels;

namespace code.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie(){ Name = "shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name= "customer 1"},
                new Customer { Name= "customer 2"}
            };

            var viewModel = new MovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult edit(int id)
        {
            return Content("the id is " + id);
        }

        public ActionResult index(int? page, string sortby)
        {
            if( !page.HasValue)
                page = 1;
            if( string.IsNullOrWhiteSpace(sortby))
                sortby = "Name";
            return Content(string.Format("pageIndex is ={0} and is sorted by {1}", page,sortby));
        }
    }
}
