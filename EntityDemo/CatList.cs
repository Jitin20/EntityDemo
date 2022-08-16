using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using EntityDemo.Models;
using Microsoft.EntityFrameworkCore;
namespace EntityDemo
    
{
  class CatList
    {
        static void Main()
        {
            NorthwindContext context = new NorthwindContext();
            var data = from cat in context.Categories.Include("Products") select cat;
            foreach(var cat in data)
            {
                Console.WriteLine($"{cat.CategoryId}---{cat.CategoryName}---{cat.Description}");
                foreach(var prod in cat.Products)
                {
                    Console.WriteLine($"{prod.ProductName}---{prod.UnitPrice}");
                }
                Console.WriteLine("***************");
            }
        }
    }
}
