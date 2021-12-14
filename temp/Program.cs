// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using DL.Models;

Console.WriteLine("Hello, World!");

//User user1 = new User { UserId = 1, Email = "temp4@gmail.com", Name = "Ivan", Surname = "Ivanov", DateOfBirth = new DateTime(2001,4,2),  ContactDetails = "+388888888" };
Price price1 = new Price { Currency = "USD", PriceId = 1, ServiceId = 1, Value = 1000 }; 

var results = new List<ValidationResult>();
var context = new ValidationContext(price1);


if (!Validator.TryValidateObject(price1, context, results, true))
{
    foreach (var error in results)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}
