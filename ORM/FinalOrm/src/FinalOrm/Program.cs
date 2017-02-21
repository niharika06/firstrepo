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
                    Name = "Whatsapp",
                    Description = "It is a popular messenger",
                    URL = "http://download/whatsapp.com",
                   
                });
                db.Updates.Add(new Updates {
                    Name = "Version",
                    Description = "There is a version update for this product",
                    Url = "http://update-version.productname.com",
                    ProdId = 1,
                    });
                db.SaveChanges();
                db.Updates.Update(new Updates
                {
                    Id=5,
                    Name = "New Version",
                    Description = "There is a version update for this product",
                    Url = "http://update-version.productname.com",
                    ProdId = 1,
                });
                db.Product.Update(new Product
                {
                    ProdId = 3,
                    Name = "Facebook Messenger",
                    Description = "There is a version update for this product",
                    URL = "http://update-version.facebook/messenger.com",
                    
                });
                db.SaveChanges();
                db.Updates.Remove(new Updates
                {
                    Id = 11,
                    
                    ProdId = 1,
                });
                db.Product.Remove(new Product
                {
                   

                    ProdId = 6,
                });
                db.SaveChanges();
                Console.WriteLine();
                    Console.WriteLine("All users in database");
                    foreach (var user in db.Updates)
                    {
                        Console.WriteLine(" -{0}", user.Url);
                    }
                }
            }


        }
    }
    

