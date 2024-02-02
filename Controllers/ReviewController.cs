using Microsoft.AspNetCore.Mvc;
using MoviePlatform.Dtos;
using MoviePlatform.Models;
using MoviePlatform.Service;

namespace MoviePlatform.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMovieRepository _movieRepository;
        //private static Movie _movie;

        public ReviewController(IReviewRepository reviewRepository, IMovieRepository movieRepository)
        {
            _reviewRepository = reviewRepository;
            _movieRepository = movieRepository;
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(string opinion, string grade, int idMovie)
        {
            var movie = await _movieRepository.GetMovieAsync(idMovie);
            ReviewDto review = new ReviewDto { Movie = movie, Grade = grade, Opinion = opinion };
            if (ModelState.IsValid)
            {
                bool isAdded = await _reviewRepository.AddReview(review);
                if (isAdded)
                {
                    return RedirectToAction("Details", "Movie", new { idMovie });
                } 
            }
            return View("Error", review);
        }
  
        [HttpGet]
        public async Task<IActionResult> SubmitForm(int idMovie)
        {
            var movie = await _movieRepository.GetMovieAsync(idMovie);
            var review = new ReviewDto { Movie = movie };
            return View(review);
        }
    }
}

