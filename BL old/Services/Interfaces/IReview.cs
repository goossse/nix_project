using DL.Models;
using System.Collections.Generic;

namespace BL.Services.Interfaces
{
    interface IReview
    {
        public List<Review> GetGoodReviews();
        public List<Review> GetNormalReviews();
        public List<Review> GetBadReviews();
        /*
        Получить хорошие отзывы
        Получить средние отзывы
        Получить плохие отзывы

         */
    }
}
