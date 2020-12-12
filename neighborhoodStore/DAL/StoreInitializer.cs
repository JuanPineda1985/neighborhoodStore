using neighborhoodStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace neighborhoodStore.DAL
{
    public class StoreInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var Users = new List<User>
            {
                new User {FirstMidName="Yohana", LastName="Vasquez",SalesDate=DateTime.Parse("2020-12-01") },
                new User {FirstMidName="Dayana", LastName="Cossio", SalesDate=DateTime.Parse("2020-12-06") },
                new User {FirstMidName="Juan", LastName="Pineda", SalesDate=DateTime.Parse("2020-12-07") },
            };

            Users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var Products = new List<Product>
            {
                new Product{ProductID=1050,ProductName="Arepas",Price=1500,},
                new Product{ProductID=1010,ProductName="Pan",Price=800,},
                new Product{ProductID=1060,ProductName="Empanada",Price=1,},
            };
            Products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();

            var Sales = new List<Sales>
            {
               new  Sales {UserID=1, ProductID=1050, ClientType=ClientType.A },
               new  Sales {UserID=2, ProductID=1010, ClientType=ClientType.B },
               new  Sales {UserID=3, ProductID=1060, ClientType=ClientType.C },
            };
            Sales.ForEach(s => context.Sales.Add(s));
            context.SaveChanges();
            
        }
    }
}