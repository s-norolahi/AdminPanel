using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IReviewRepository
    {
        void AddReview(Review review);
        void RemoveReview(Review review);
        void UpdateReview(Review review);
        Review GetReview(long id);
        ICollection<Review> GetAllReviews();
        //ApplicationUser GetUserForReview(long id);
        Product GetProductForReview(long id);
    }
}
