using LiteDB;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar
{
    public class DatabaseHelper
    {
        public static void InsertMeal(Meal meal, Image image)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                if (image != null)
                {
                    string imgId = Guid.NewGuid().ToString();

                    using (var stream = new MemoryStream())
                    {
                        image.Save(stream, image.RawFormat);

                        stream.Position = 0;

                        db.FileStorage.Upload(imgId, imgId, stream);
                    }

                    meal.Image = imgId;
                }

                var col = db.GetCollection<Meal>("meals");

                col.Insert(meal);

                col.EnsureIndex(x => x.Name);
                col.EnsureIndex(x => x.Timestamp);
            }
        }

        public static Image GetMealImage(string imgId)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                using (var stream = new MemoryStream())
                {
                    db.FileStorage.FindById(imgId).CopyTo(stream);
                    return Image.FromStream(stream);
                }
            }
        }

        public static List<Meal> GetAllMeals()
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Meal>("meals");

                var results = col.FindAll().OrderBy(x => x.Timestamp).ToList();

                return results;

            }
        }

        public static void DeleteMeal(Meal meal)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                var col = db.GetCollection<Meal>("meals");

                col.Delete(meal.Id);

                db.FileStorage.Delete(meal.Image);
            }
        }

        public static void UpdateMeal(Meal meal, Image image)
        {
            using (var db = new LiteDatabase(@"MyData.db"))
            {
                if (image != null)
                {
                    db.FileStorage.Delete(meal.Image);

                    string imgId = Guid.NewGuid().ToString();

                    using (var stream = new MemoryStream())
                    {
                        image.Save(stream, image.RawFormat);

                        stream.Position = 0;

                        db.FileStorage.Upload(imgId, imgId, stream);
                    }

                    meal.Image = imgId;
                }

                var col = db.GetCollection<Meal>("meals");

                col.Update(meal);
            }
        }

    }
}
