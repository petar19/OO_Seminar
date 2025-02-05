﻿using LiteDB;
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
        private static string database = "MyData.db";
        public static void InsertMeal(Meal meal, Image image)
        {
            using (var db = new LiteDatabase(@database))
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

        public static void InsertMeal(Meal meal)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection<Meal>("meals");

                col.Insert(meal);

                col.EnsureIndex(x => x.Name);
                col.EnsureIndex(x => x.Timestamp);
            }
        }

        public static Image GetMealImage(string imgId)
        {
            using (var db = new LiteDatabase(@database))
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
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection<Meal>("meals");

                var results = col.FindAll().OrderBy(x => x.Timestamp).ToList();

                return results;

            }
        }

        public static void DeleteMeal(Meal meal)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection<Meal>("meals");

                col.Delete(meal.Id);
            }
        }

        public static void UpdateMeal(Meal meal, Image image)
        {
            using (var db = new LiteDatabase(@database))
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

                col.Update(meal);
            }
        }

        public static void UpdateMeal(Meal meal)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection<Meal>("meals");

                col.Update(meal);
            }
        }

        public static IEnumerable<string> GetAllMealTypes()
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("mealTypes");

                foreach(var doc in col.FindAll())
                {
                    yield return doc["value"].AsString;
                }
            }
        }

        public static void InsertMealType(string mealType)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("mealTypes");

                col.Insert(new BsonDocument { ["value"] = mealType });

            }
        }

        public static IEnumerable<string> GetAllDishTypes()
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("dishTypes");

                foreach (var doc in col.FindAll())
                {
                    yield return doc["value"].AsString;
                }
            }
        }

        public static void InsertDishType(string dishType)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("dishTypes");

                col.Insert(new BsonDocument { ["value"] = dishType });

            }
        }

        public static IEnumerable<string> GetAllLocations()
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("locations");

                foreach (var doc in col.FindAll())
                {
                    yield return doc["value"].AsString;
                }
            }
        }

        public static void InsertLocation(string location)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("locations");

                col.Insert(new BsonDocument { ["value"] = location });

            }
        }

        public static IEnumerable<string> GetAllPreparationTypes()
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("preparationTypes");

                foreach (var doc in col.FindAll())
                {
                    yield return doc["value"].AsString;
                }
            }
        }

        public static void InsertPreparationType(string preparationType)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("preparationTypes");

                col.Insert(new BsonDocument { ["value"] = preparationType });

            }
        }

        public static IEnumerable<string> GetAllIngredients()
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("ingredients");

                foreach (var doc in col.FindAll())
                {
                    yield return doc["value"].AsString;
                }
            }
        }

        public static void InsertIngredient(string ingredient)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("ingredients");

                col.Insert(new BsonDocument { ["value"] = ingredient });
            }
        }

        public static void InsertIngredients(List<string> ingredients)
        {
            using (var db = new LiteDatabase(@database))
            {
                var col = db.GetCollection("ingredients");

                col.InsertBulk(ingredients.ConvertAll(i => new BsonDocument { ["value"] = i }));
            }
        }

    }
}
