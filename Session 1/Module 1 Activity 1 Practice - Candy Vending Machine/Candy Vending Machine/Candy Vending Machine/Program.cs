// Candy.cs (Model)
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Reflection;
using System;

public class Candy
{
    public string Name { get; set; }
    public int Weight { get; set; } // in grams
    public decimal Price { get; set; }

    // Additional properties or methods can be added as needed
}



// Views/Candy/Index.cshtml (View)
