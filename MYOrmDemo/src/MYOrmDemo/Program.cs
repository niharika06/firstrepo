using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MYOrmDemo
{
    public class ModelContext 
    {
        public static void Main(string[] args)
        {
            using (var db= new Model())
            {
                db.Database.Migrate();
                db.Updates.add(new Updates { Url = "http://user.msdn.com/adonet" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database,count");

                Console.WriteLine();
                Console.WriteLine("All users in database");
               foreach(var user in db.Updates) {
                    Console.WriteLine(" -{0}", user.Url);
                }
            }
        }

       
    }
}
