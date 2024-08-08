using Microsoft.AspNetCore.Mvc;
using MoviesMvc.Models;
using MoviesMvc.Services;
using System.Diagnostics;

namespace MoviesMvc.Controllers;

public class MoviesController(MovieService movieService) : Controller
{
    private readonly MovieService _movieService = movieService;

    public IActionResult Index()
    {
        return View(_movieService.ListAllMovies());
    }

    public IActionResult FancyMovieList()
    {
        var movies =  _movieService.ListAllMovies();
        return View(movies);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
