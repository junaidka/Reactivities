using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if(context.Activities.Any()) return;

            var activities= new List<Activity>
            {
                new Activity
                {
                    Title="Past activity 1",
                    Date=DateTime.UtcNow.AddMonths(-2),
                    Description="Activity 2 months ago",
                    Category="drinks",
                    City="London",
                    Venue="Pub"
                },
                new Activity
                {
                    Title="Past activity 2",
                    Date=DateTime.UtcNow.AddMonths(-1),
                    Description="Activity 1 months ago",
                    Category="culture",
                    City="Paris",
                    Venue="Louvre"
                },
                new Activity
                {
                    Title="Future activity 2",
                    Date=DateTime.UtcNow.AddMonths(1),
                    Description="Activity 2 months in future",
                    Category="Music",
                    City="London",
                    Venue="O2 Arena"
                },
                new Activity
                {
                    Title="Future activity 3",
                    Date=DateTime.UtcNow.AddMonths(3),
                    Description="Activity 3 months in future",
                    Category="drinks",
                    City="London",
                    Venue="Another Pub"
                },
                new Activity
                {
                    Title="Future activity 4",
                    Date=DateTime.UtcNow.AddMonths(4),
                    Description="Activity 4 months in future",
                    Category="Music",
                    City="London",
                    Venue="Roundhouse camden"
                },
                new Activity
                {
                    Title="Future activity 5",
                    Date=DateTime.UtcNow.AddMonths(5),
                    Description="Activity 5 months in future",
                    Category="drinks",
                    City="London",
                    Venue="just another pub"
                },
                new Activity
                {
                    Title="Future activity 6",
                    Date=DateTime.UtcNow.AddMonths(6),
                    Description="Activity 6 months in future",
                    Category="Music",
                    City="London",
                    Venue="Roundhouse camden"
                },
                new Activity
                {
                    Title="Future activity 7",
                    Date=DateTime.UtcNow.AddMonths(7),
                    Description="Activity 7 months in future",
                    Category="Travel",
                    City="London",
                    Venue="Somewhere on thames"
                },
                new Activity
                {
                    Title="Future activity 8",
                    Date=DateTime.UtcNow.AddMonths(8),
                    Description="Activity 8 months in future",
                    Category="film",
                    City="London",
                    Venue="Cinema"
                },
            };
            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}