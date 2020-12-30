using System;
using System.Collections.Generic;
using System.Linq;
using AppDomain;

namespace AppPersistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if(!context.Activities.Any())
            {
                var activities = new List<Activity>()
                {
                    new Activity(){
                        Title="Past Activity 1",
                        Description = "This is the Past Activity 1",
                        Date = DateTime.Now.AddMonths(-1),
                        City="Hyderabad",
                        Venue="Madhapur"
                    },
                    new Activity(){
                        Title="Past Activity 2",
                        Description = "This is the Past Activity 2",
                        Date = DateTime.Now.AddMonths(-3),
                        City="Hyderabad",
                        Venue="Madhapur"
                    },
                    new Activity(){
                        Title="Future Activity 1",
                        Description = "This is the Future Activity 1",
                        Date = DateTime.Now.AddMonths(2),
                        City="Hyderabad",
                        Venue="Secunderabad"
                    },
                    new Activity(){
                        Title="Future Activity 2",
                        Description = "This is the Future Activity 2",
                        Date = DateTime.Now.AddMonths(1),
                        City="Vizag",
                        Venue="Beach Road"
                    },
                    new Activity(){
                        Title="Past Activity 3",
                        Description = "This is the Past Activity 3",
                        Date = DateTime.Now.AddMonths(-1),
                        City="Karnataka",
                        Venue="Bangalore"
                    },
                    new Activity(){
                        Title="Past Activity 4",
                        Description = "This is the Past Activity 4",
                        Date = DateTime.Now.AddMonths(-5),
                        City="Hyderabad",
                        Venue="Madhapur"
                    },
                    new Activity(){
                        Title="Future Activity 3",
                        Description = "This is the Future Activity 3",
                        Date = DateTime.Now.AddMonths(3),
                        City="Vizag",
                        Venue="Beach Road"
                    },
                    new Activity(){
                        Title="Future Activity 4",
                        Description = "This is the Future Activity 4",
                        Date = DateTime.Now.AddMonths(2),
                        City="Hyderabad",
                        Venue="Madhapur"
                    },
                    new Activity(){
                        Title="Future Activity 5",
                        Description = "This is the Future Activity 5",
                        Date = DateTime.Now.AddMonths(4),
                        City="Hyderabad",
                        Venue="Madhapur"
                    },
                    new Activity(){
                        Title="Past Activity 5",
                        Description = "This is the Past Activity 5",
                        Date = DateTime.Now.AddMonths(-1),
                        City="Hyderabad",
                        Venue="Madhapur"
                    }
                };
                context.Activities.AddRange(activities);
                context.SaveChanges();
            }
        }
    }
}