using Candy_Vending_Machine.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Candy_Vending_Machine.Controllers;
    // CandyController.cs (Controller)
using Microsoft.AspNetCore.Mvc;

public class CandyController : Controller
{
    public IActionResult Index()
    {
        // Create a list of Candy objects
        var candies = new List<Candy>
        {
            new Candy { Name = "Chocolate Bar", Weight = 50, Price = 1.50M },
            new Candy { Name = "Gummy Bears", Weight = 100, Price = 2.00M },
            new Candy { Name = "Lollipop", Weight = 30, Price = 0.75M },
            // Add more candies as needed
        };

        // Pass the list of candies to the view
        return View(candies);
    }

    public IActionResult Dispense(string candyName)
    {
        // You can add logic here to handle the dispensing process
        var message = $"Dispensing {candyName}...";
        return Content(message);
    }
}