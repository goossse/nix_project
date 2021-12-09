// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using DL.Models;

Console.WriteLine("Hello, World!");

User user1 = new User { UserId = 1, Email = "temp4gmail.com", Name = "Ivan", ContactDetails = "+388888888" };

var results = new List<ValidationResult>();
var context = new ValidationContext(user1);

if (!Validator.TryValidateObject(user1, context, results, true))
{
    foreach (var error in results)
    {
        Console.WriteLine(error.ErrorMessage);
    }
}
