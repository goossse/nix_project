// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using DL.Models;
using DL.Entity_Framework;
using Microsoft.EntityFrameworkCore;



using (ApplicationContext db = new ApplicationContext())
{

    // создаем два объекта User
    User user1 = new User { Email = "temp4@gmail.com", Name = "Ivan", Surname = "Ivanov", DateOfBirth = new DateTime(2001, 4, 2), ContactDetails = "+388888888" };
    User user2 = new User { Email = "temp44@gmail.com", Name = "Petr", Surname = "Ivanov", DateOfBirth = new DateTime(2001, 4, 4), ContactDetails = "+300000000" };


    // добавляем их в бд
    db.Users.AddRange(user1, user2);
    db.SaveChanges();
}
// получение данных
using (ApplicationContext db = new ApplicationContext())
{
    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Users list:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name} {u.Email} {u.Surname} {u.DateOfBirth} {u.ContactDetails} ");
    }
}
