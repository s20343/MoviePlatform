using Microsoft.AspNetCore.Mvc;
using MoviePlatform.Service;

namespace MoviePlatform.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IReviewRepository _reviewRepository;
  
        public MovieController(IMovieRepository movieRepository, IReviewRepository reviewRepository)
        {
            _movieRepository = movieRepository;
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _movieRepository.GetMoviesAsync();
            return View(movies);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int idMovie)
        {
            var (movie, averageRating) = await _movieRepository.GetMovieWithReviewsAsync(idMovie);
            ViewBag.AverageRating = averageRating;

            return View(movie);
        }
    }
}
