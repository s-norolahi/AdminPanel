using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReviewRepository: IReviewRepository
    {


        public void AddReview(Review review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
        }

        public void RemoveReview(Review review)
        {
            context.Reviews.Remove(review);
            context.SaveChanges();
        }

        public void UpdateReview(Review review)
        {
            context.Reviews.Update(review);
            context.SaveChanges();
        }

        public Review GetReview(long id)
        {
            return context.Reviews.Find(id);
        }

        public ICollection<Review> GetAllReviews()
        {
            return context.Reviews.ToList();
        }

        public ApplicationUser GetUserForReview(long id)
        {
            return (ApplicationUser)context.Users.Find(
                context.Reviews.Find(id)?.ApplicationUserID
            );
        }

        public Product GetProductForReview(long id)
        {
            return context.Products.Find(
                context.Reviews.Find(id)?.Product
            );
        }
    }
}
