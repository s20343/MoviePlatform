using Microsoft.EntityFrameworkCore;
using MoviePlatform.Dtos;
using MoviePlatform.Models;
using System.Collections.ObjectModel;

namespace MoviePlatform.Service
{
    public interface IReviewRepository
    {
        public IReadOnlyCollection<Review> GetReviews();
        public IReadOnlyCollection<Review> GetReviewsOfUser(int idUser);
        public Task<List<Review>> GetReviewsOfMovieAsync(int idMovie);
        public Review GetReview(int idReview);
        public void UpdateReview(Review review);
        public void DeleteReview(int reviewId);
        public void Save();
        public Task<bool> AddReview(string opinion, string grade, int idMovie, int idUser);
    }
    public class ReviewRepository : IReviewRepository
    {
        IUserRepository _userRepository;
        MoviePlatformDbContext Context { get; set; }
        public ReviewRepository(MoviePlatformDbContext context, IUserRepository userRepository)
        {
            Context = context;
            _userRepository = userRepository;
        }

        public IReadOnlyCollection<Review> GetReviews()
        {
            return new ReadOnlyCollection<Review>(Context.Reviews.ToList());
        }

        public IReadOnlyCollection<Review> GetReviewsOfUser(int idUser)
        {
            return new ReadOnlyCollection<Review>(Context.Reviews.Where(r => r.IdUser == idUser).ToList());
        }
        public async Task<List<Review>> GetReviewsOfMovieAsync(int idMovie)
        {
            var Reviews = await Context.Reviews.Where(r => r.IdMovie == idMovie).ToListAsync();
            foreach(var review in Reviews)
            {
                review.User = await _userRepository.GetUserAsync(review.IdUser);
            }
            return Reviews;
        }

        public Review GetReview(int idReview)
        {
            if (!Validate(idReview))
            {
                return new Review();
            }
            return Context.Reviews.First(x => x.IdReview == idReview);
        }
        
        public async Task<bool> AddReview(string opinion, string grade, int idMovie, int idUser)
        {
            var movieExists = await Context.Movies.AnyAsync(m => m.IdMovie == idMovie);
            var userExists = await Context.Users.AnyAsync(u => u.IdUser == 1); 
            if (!movieExists || !userExists)
            {
                Console.WriteLine("Given user or movie doesn't exist");
                return false;
            }

            if (string.IsNullOrEmpty(opinion) || opinion.Length < 3)
            {
                Console.WriteLine("Opinion is too short. Minimum length of 3 characters is required.");
                return false;
            }

            using (var dbContextTransaction = await Context.Database.BeginTransactionAsync())
            {
                try
                {
                    Grade myEnum = (Grade)Enum.Parse(typeof(Grade), grade);
                    var review = new Review { Text = opinion, Grade = myEnum, IdUser = 1, IdMovie = idMovie, CreationDate = DateTime.UtcNow };
                    await Context.Reviews.AddAsync(review);
                    await Context.SaveChangesAsync();

                    await dbContextTransaction.CommitAsync();
                    return true;
                }
                catch (Exception ex)
                {
                    await dbContextTransaction.RollbackAsync();
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }
        }


        public void UpdateReview(Review review)
        {
            if (!Validate(review.IdReview))
            {
                return;
            }
            Review newReview = Context.Reviews.First(r => r.IdReview == review.IdReview);

            newReview.Text = review.Text;
            newReview.Grade = review.Grade;
            newReview.CreationDate = review.CreationDate;
            Save();
        }

        public void DeleteReview(int reviewId)
        {
            if (!Validate(reviewId))
            {
                return;
            }
            Context.Reviews.Remove(Context.Reviews.First(r => r.IdReview == reviewId));
            Save();
        }

        public bool Validate(int idReview)
        {
            if (!Context.Reviews.Any(x => x.IdReview == idReview))
            {
                Console.WriteLine("Given review doesn't exist");
                return false;
            }
            return true;
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
