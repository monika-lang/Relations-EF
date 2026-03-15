using EFP48.Data;
using EFP48.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFP48
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            DataContext _dataContext = new();

            // Include - дозволяє включити пов'зані сутності. В нашому прикладі, разом з категоріями, будуть підвантажуватися
            // продукти відповідно конкретній категорії.
            var query = _dataContext.Categories.Include(c => c.Products.OrderBy(p=>p.Name));
            var categories = query.ToList();
            //foreach (var category in categories) {
            //    Console.WriteLine($"CategoryID: {category.Id}, CategoryName: {category.Name}\n");
            //    if (category.Products is not null)
            //    {
            //        Console.WriteLine("------------------------------------");
            //        foreach (var product in category.Products)
            //        {
            //            Console.WriteLine(product);
            //        }
            //        Console.WriteLine("------------------------------------");
            //    }
            //}

            Console.WriteLine("\n\n");

            foreach (var category in categories)
            {
                Console.WriteLine($"CategoryID: {category.Id}, CategoryName: {category.Name}\n");
                if (category.Products is not null)
                {
                    Console.WriteLine("------------------------------------");
                    foreach (var product in category.Products)
                    {
                        if (product.DeletedAt is not null) Console.WriteLine(product);
                    }
                    Console.WriteLine("------------------------------------");
                }
            }
            Console.WriteLine("\n\n");
            foreach (var category in categories)
            {
                Console.WriteLine($"CategoryID: {category.Id}, CategoryName: {category.Name}, ProductCount: {category.Products.Count}\n");
            }
            Console.WriteLine("\n\n");

            foreach (var category in categories)
            {
                Console.WriteLine($"CategoryID: {category.Id}, CategoryName: {category.Name}\n");

                var product = category.Products.OrderBy(p => p.Price).FirstOrDefault();

                if (product is not null)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(product);
                    Console.WriteLine("------------------------------------\n");
                }
                
            }

            Console.WriteLine("\n\n");

            foreach (var category in categories)
            {
                var average = category.Products.Average(p => p.Price);
                average *= 100;
                int int_average = (int)average;
                average = int_average / 100;

                Console.WriteLine($"CategoryID: {category.Id}, CategoryName: {category.Name}, AveragePrice: {average}\n");
            }
        }
    }
}
