using Microsoft.AspNetCore.Mvc;
using mission6_Cooper.Models;
using System.Diagnostics;

namespace mission6_Cooper.Controllers
{
    public class HomeController : Controller
    {
        private MovieListContext _context;
        public HomeController(MovieListContext movieListContext)
        {
            _context = movieListContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        //Post for when the movie is added
        [HttpPost]
        public IActionResult Form(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            //show confirmation window and pass movie details
            return View("Confirmation", newMovie);
        }
    }
}
