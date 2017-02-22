using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalOrm
{
 
        public class Program
        {
            public static void Main(string[] args)
            {
                using (var db = new Model())
                {
                    db.Database.Migrate();
                db.Product.Add(new Product
                {
                    Name = "Hike",
                    Description = "Meesenger",
                    URL = "http://www.hike.com",

                });
                var addProduct = db.SaveChanges();
                Console.WriteLine("item added in updates", addProduct);
                 db.Updates.Add(new Updates {
                     Name = "Version",
                     Description = "hello",
                     Url = "http://www.orkut.com",
                     ProdId =12, 
                     });
                var addUpdate= db.SaveChanges();
                 Console.WriteLine("item added in updates", addUpdate);
               db.Updates.Update(new Updates
                 {
                     Id=20,
                     Name = "New Version",
                     Description = "There is a version update for this product",
                     Url = "http://update-version.productname.com",
                     ProdId = 14
                 });
                 var updateUpdates = db.SaveChanges();
                 Console.WriteLine("item updated in updates", updateUpdates);
                db.Product.Update(new Product
                    {
                        ProdId = 3,
                        Name = "Facebook Messenger",
                        Description = "Most popular social networking site",
                        URL = "http://www.facebook/messenger.com",

                    });
                    var updateProduct = db.SaveChanges();
                    Console.WriteLine("item updated in updates", updateProduct);            

                   db.Updates.Remove(new Updates
                    {
                        Id = 21,

                        ProdId = 14,
                    });
                    var removeUpdates = db.SaveChanges();
                    Console.WriteLine("item updated in updates", removeUpdates);
                db.Product.Remove(new Product
                 {
                     ProdId = 16,
                 });
                 var removeProduct = db.SaveChanges();
                 Console.WriteLine("item updated in updates", removeProduct);
                 
                Console.WriteLine("All users in database");
                    foreach (var user in db.Updates)
                    {
                        Console.WriteLine(" -{0}", user.Url);
                    }
                }
            }


        }
    }
    

