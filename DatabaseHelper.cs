using LiteDB;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar
{
    public class DatabaseHelper
    {
        public static void insertMeal(Meal meal)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Meal>("meals");

                col.Insert(meal);

                col.EnsureIndex(x => x.Name);
                col.EnsureIndex(x => x.Timestamp);
            }
        }

        public static List<Meal> getAllMeals()
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Meal>("meals");

                var results = col.FindAll().OrderBy(x => x.Timestamp).ToList();

                return results;

            }
        }

    }
}
