using DL.Models;
using System.Collections.Generic;


namespace BL.Services.Interfaces
{
    interface IService
    {
        public List<Service> SearchByTitle(string searchingTitle);
        public List<Service> SearchByPrice(Price minPrice, Price maxPrice);
        public List<Service> SearchByType(ServiceType searchingType);

        public Price GetMinPrice(int Id);
        public double GetAverageRate(int Id);

        public List<Service> SortByReviews();
        public List<Service> SortByPopularity();
        public List<Service> SortByPrices();

        public void AddServiceType(ServiceType serviceType);
        public void AddPrice(Price price);

        public List<Request> SortOfRequestsByPrice();
        public List<Request> SortOfRequestsByDate();

        /*
        Поиск по названию
        Поиск по цене
        Поиск по типу

        Получить минимальную цену
        Получить средний рейтинг отзывов

        Сортировка по отзывам
        Сортировка по популярности
        Сортировка по цене

        Добавление типов услуги
        Добавление цены

        Сортировка заявок по цене
        Сортировка заявок по дате
         */
    }
}
