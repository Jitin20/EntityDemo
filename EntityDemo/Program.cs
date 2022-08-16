using System;
using EntityDemo.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EntityDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
                NorthwindContext context = new NorthwindContext();
            //var data = from prod in context.Products.Include("Category") select prod;
            var data = context.Products.Include("Category").ToList();
            foreach(var prod in data)
            {
                Console.WriteLine($"{prod.ProductId}---{prod.ProductName}---{prod.UnitPrice}---{prod.Category.CategoryName}");
            }
        }
    }
}
