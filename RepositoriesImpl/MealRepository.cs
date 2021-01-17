using OO_Seminar.DomainModel;
using OO_Seminar.DomainModel.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.RepositoriesImpl
{
    class MealRepository : IMealRepository
    {
        List<Meal> meals;

        private static MealRepository _instance;

        private MealRepository()
        {
            meals = DatabaseHelper.GetAllMeals();
        }

        public static MealRepository getInstance()
        {
            return _instance ?? (_instance = new MealRepository());
        }


        public void AddMeal(Meal meal, Image image)
        {

            meals.Add(meal);
            DatabaseHelper.InsertMeal(meal, image);
        }

        public void AddMeal(Meal meal)
        {
            var image = Properties.Resources.MealArt;
            AddMeal(meal, image);
        }

        public void DeleteMeal(Meal meal)
        {
            meals.Remove(meal);
            DatabaseHelper.DeleteMeal(meal);

        }

        public List<Meal> GetAllMeals()
        {
            return meals;
        }

        public Meal GetMealById(int Id)
        {
            return meals.Find(m => m.Id == Id);
        }

        public List<Meal> GetMealsByName(List<string> Tokens)
        {
            return meals.FindAll(m => Tokens.Any(m.Name.Contains));
        }

        public List<Meal> GetMealsInTimePeriod(DateTime From, DateTime To)
        {
            return meals.FindAll(m => m.Timestamp.CompareTo(From) >= 0 && m.Timestamp.CompareTo(To) <= 0);
        }

        public List<Meal> GetMealsOfDishType(List<string> DishTypes)
        {
            return meals.FindAll(m => DishTypes.Contains(m.DishType));
        }

        public List<Meal> GetMealsOfPreparationType(List<string> PreparationTypes)
        {
            return meals.FindAll(m => PreparationTypes.Contains(m.PreparationType));
        }

        public List<Meal> GetMealsOfType(List<string> MealTypes)
        {
            return meals.FindAll(m => MealTypes.Contains(m.MealType));
        }
        public List<Meal> GetMealsWithLocation(List<string> Locations)
        {
            return meals.FindAll(m => Locations.Contains(m.Location));
        }

        public List<Meal> GetMealsWithCalories(int From, int To)
        {
            return meals.FindAll(m => m.Calories >= From && m.Calories <= To);
        }


        public List<Meal> GetMealsWithPrice(int From, int To)
        {
            return meals.FindAll(m => m.Price >= From && m.Price <= To);
        }

        public List<Meal> GetMealsWithRating(int From, int To)
        {
            return meals.FindAll(m => m.Rating >= From && m.Rating <= To);
        }

        public void UpdateMeal(Meal meal, Image image)
        {
            DatabaseHelper.UpdateMeal(meal, image);
        }

        public void UpdateMeal(Meal meal)
        {
            DatabaseHelper.UpdateMeal(meal, null);

        }
    }
}
