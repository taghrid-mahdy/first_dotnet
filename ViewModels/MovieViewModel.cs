using System.Collections.Generic;
using code.Models;

namespace code.ViewModels
{
    public class MovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers{ get; set; }

    }
}