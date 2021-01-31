using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel.Repositories
{
    public interface IMealRepository : IObservable
    {
        void AddMeal(Meal meal, Image image);
        void AddMeal(Meal meal);
        void UpdateMeal(Meal meal, Image image);
        void UpdateMeal(Meal meal);
        void DeleteMeal(Meal meal);
        void DuplicateMeal(Meal meal);

        int GetNumberOfMeals();

        List<Meal> GetAllMeals();
        List<Meal> GetLastNMeals(int n);
        List<Meal> GetUniqueByNameMeals();
        List<Meal> GetMealsInTimePeriodAndWithKeywords(DateTime startTime, DateTime endTime, List<string> keywords);
        Meal GetMealById(int Id);


        List<string> GetAllMealTypes();
        List<string> GetAllLocations();
        List<string> GetAllDishTypes();
        List<string> GetAllPreparationTypes();
        List<string> GetAllIngredients();


    }
}
