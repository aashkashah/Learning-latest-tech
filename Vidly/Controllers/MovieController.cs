using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>()
            {
                new Customer()
                {
                    Name = "Customer 1",
                    Id = 1
                },
                new Customer()
                {
                    Name = "Customer 2",
                    Id = 2
                }
            };

            var randomMovieVM = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            
            return View(randomMovieVM);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            return Content(String.Format("pageIndex={0}, SortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ByReleasedate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}