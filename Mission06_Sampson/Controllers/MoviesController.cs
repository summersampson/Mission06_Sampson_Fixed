using Microsoft.AspNetCore.Mvc;
using Mission06_LastName.Models;

namespace Mission06_LastName.Controllers
{
    // this page is adding in the controller info so i can get the movies from the form page to the database
    public class MoviesController : Controller
    {
        private readonly MovieDbContext _context;

        public MoviesController(MovieDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList");
            }
            return View(movie);
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }
    }
}
