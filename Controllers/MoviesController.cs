using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using code.Models;
using code.ViewModels;

namespace code.Controllers
{
    public class MoviesController : Controller
    {
        private Movie movie = new Movie(){ Name = "shrek"};
        private List<Customer> customers = new List<Customer>
        {
            new Customer {Name = "marry" , Id = 0},
            new Customer {Name = "john" , Id = 1}
        };


        public ActionResult Random()
        {

            var viewModel = new MovieViewModel
            {
                Movie = this.movie,
                Customers = this.customers
            };

            return View(viewModel);
        }

        public ActionResult customerContent(int Id)
        {
            return Content(this.customers[Id].Name);
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
