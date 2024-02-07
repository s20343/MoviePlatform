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


        public ReviewController(IReviewRepository reviewRepository, IMovieRepository movieRepository)
        {
            _reviewRepository = reviewRepository;
            _movieRepository = movieRepository;
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(string opinion, string grade, int idMovie)
        {
            if (ModelState.IsValid)
            {
                bool isAdded = await _reviewRepository.AddReview(opinion, grade, idMovie, 1);
                if (isAdded)
                {
                    return RedirectToAction("Details", "Movie", new { idMovie });
                } 
            }
            var reviewDto = new ReviewDto { Movie = new Movie { IdMovie = idMovie }, Opinion = opinion, Grade = grade };
            return View("Error", reviewDto);
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

