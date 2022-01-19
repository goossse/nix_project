using System.Collections.Generic;
using DL.Models;

namespace BL.Services.Interfaces
{
    interface IRequest
    {
        public List<Condition> GetConditions(int Id);
        public void AddCondition(Condition condition);
        public void AddPrice(Price price);
        /*
         Просмотреть условия
         Добавить условия
         Добавить цену
         */
    }
}
