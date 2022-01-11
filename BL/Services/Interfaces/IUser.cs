using DL.Models;
using System.Collections.Generic;

namespace BL.Services.Interfaces
{
    interface IUser
    {
        public User GetProfile(int Id);
        public List<Service> GetMyServices(int Id);
        public List<Review> GetMyReviews(int Id);
        public List<Request> GetMyRequests(int Id);
        public List<ServiceType> GetMyTypesOfServices(int Id);

    /*
    Просмотр данных профиля
    Получить список всех своих услуг
    Получить список всех своих отзывов
    Получить список всех своих заявок
    Получить типы услуг, которые оказывает
     */
    }
}
