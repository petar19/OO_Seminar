using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel.Repositories
{
    public interface IMealRepository
    {
        void AddMeal(Meal meal, Image image);
        void AddMeal(Meal meal);
        void UpdateMeal(Meal meal, Image image);
        void UpdateMeal(Meal meal);
        void DeleteMeal(Meal meal);

        List<Meal> GetAllMeals();
        List<Meal> GetMealsOfType(List<string> MealTypes);
        List<Meal> GetMealsOfDishType(List<string> DishTypes);
        List<Meal> GetMealsOfPreparationType(List<string> PreparationTypes);
        List<Meal> GetMealsWithLocation(List<string> Locations);

        List<Meal> GetMealsWithRating(int From, int To);
        List<Meal> GetMealsWithPrice(int From, int To);
        List<Meal> GetMealsWithCalories(int From, int To);
        List<Meal> GetMealsInTimePeriod(DateTime From, DateTime To);

        List<Meal> GetMealsByName(List<string> Tokens);

        Meal GetMealById(int Id);


        List<string> GetAllMealTypes();
        List<string> GetAllLocations();
        List<string> GetAllDishTypes();
        List<string> GetAllPreparationTypes();
        List<string> GetAllIngredients();



    }
}
