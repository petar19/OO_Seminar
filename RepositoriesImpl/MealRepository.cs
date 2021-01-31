using OO_Seminar.DomainModel;
using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.DomainModel.Exceptions;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.RepositoriesImpl
{
    public class MealRepository : IMealRepository
    {
        List<Meal> meals;

        HashSet<string> mealTypes;
        HashSet<string> locations;
        HashSet<string> dishTypes;
        HashSet<string> preparationTypes;
        HashSet<string> ingredients;

        List<IObserver> observers;



        private static MealRepository _instance;


        private MealRepository(bool useDB)
        {
            if (useDB)
            {
                meals = DatabaseHelper.GetAllMeals();
                mealTypes = DatabaseHelper.GetAllMealTypes().ToHashSet();
                locations = DatabaseHelper.GetAllLocations().ToHashSet();
                dishTypes = DatabaseHelper.GetAllDishTypes().ToHashSet();
                preparationTypes = DatabaseHelper.GetAllPreparationTypes().ToHashSet();
                ingredients = DatabaseHelper.GetAllIngredients().ToHashSet();
            }
            else
            {
                meals = new List<Meal>();

                mealTypes = new HashSet<string>();
                locations = new HashSet<string>();
                dishTypes = new HashSet<string>();
                preparationTypes = new HashSet<string>();
                ingredients = new HashSet<string>();
            }

            observers = new List<IObserver>();
        }


        public static MealRepository getInstance(bool useDB)
        {
            return _instance ?? (useDB ? _instance = new MealRepository(true) : _instance = new MealRepository(false));
        }


        private void checkDuplicateIngredients(Meal meal)
        {
            HashSet<string> ingredients = new HashSet<string>();
            
            foreach(var i in meal.Ingredients)
            {
                if (ingredients.Contains(i.Ingredient)) throw new DuplicateIngredientsException();
                else ingredients.Add(i.Ingredient);
            }
        }


        public int GetNumberOfMeals()
        {
            return meals.Count;
        }

        public void AddMeal(Meal meal)
        {
            var image = Properties.Resources.MealArt;
            AddMeal(meal, image);
        }

        public void AddMeal(Meal meal, Image image)
        {
            Console.WriteLine($"adding a meal {meal.Name}");

            checkDuplicateIngredients(meal);

            meals.Add(meal);
            DatabaseHelper.InsertMeal(meal, image);
            UpdateSuggestions(meal);
            Notify();

        }

        private void UpdateSuggestions(Meal meal)
        {
            if (!mealTypes.Contains(meal.MealType))
            {
                DatabaseHelper.InsertMealType(meal.MealType);
                mealTypes.Add(meal.MealType);
            }

            if (!locations.Contains(meal.Location))
            {
                DatabaseHelper.InsertLocation(meal.Location);
                locations.Add(meal.Location);
            }

            if (!dishTypes.Contains(meal.DishType))
            {
                DatabaseHelper.InsertDishType(meal.DishType);
                dishTypes.Add(meal.DishType);
            }

            if (!preparationTypes.Contains(meal.PreparationType))
            {
                DatabaseHelper.InsertPreparationType(meal.PreparationType);
                preparationTypes.Add(meal.PreparationType);
            }

            List<string> newIngredients = new List<string>();

            foreach(var mealIngredient in meal.Ingredients)
            {
                if (!ingredients.Contains(mealIngredient.Ingredient))
                {
                    newIngredients.Add(mealIngredient.Ingredient);
                }
            }

            if (newIngredients.Count > 0)
            {
                ingredients.UnionWith(newIngredients);
                DatabaseHelper.InsertIngredients(newIngredients);
            }
        }

        

        public void DeleteMeal(Meal meal)
        {
            meals.Remove(meal);
            DatabaseHelper.DeleteMeal(meal);
            Notify();

        }


        public void DuplicateMeal(Meal meal)
        {
            checkDuplicateIngredients(meal);

            Meal newMeal = new Meal
            {
                Name = meal.Name,
                Calories = meal.Calories,
                Description = meal.Description,
                DishType = meal.DishType,
                Ingredients = meal.Ingredients,
                Location = meal.Location,
                MealType = meal.MealType,
                PreparationType = meal.PreparationType,
                Price = meal.Price,
                Rating = meal.Rating,
                Timestamp = DateTime.Now,
                Image = meal.Image
            };

            meals.Add(newMeal);
            DatabaseHelper.InsertMeal(newMeal);
            Notify();
        }

        public List<Meal> GetAllMeals()
        {
            return meals.OrderBy(m => m.Timestamp).ToList();
        }

        public List<string> GetAllMealTypes()
        {
            return mealTypes.ToList();
        }

        public List<string> GetAllLocations()
        {
            return locations.ToList();
        }

        public List<string> GetAllDishTypes()
        {
            return dishTypes.ToList();
        }

        public List<string> GetAllPreparationTypes()
        {
            return preparationTypes.ToList();
        }

        public List<string> GetAllIngredients()
        {
            return ingredients.ToList();
        }

        public Meal GetMealById(int Id)
        {
            return meals.Find(m => m.Id == Id);
        }


        public void UpdateMeal(Meal meal, Image image)
        {
            Console.WriteLine($"updating a meal {meal.Name}");
            checkDuplicateIngredients(meal);

            var i = meals.FindIndex(m => m.Id == meal.Id);
            if (i != -1)
            {
                meals[i] = meal;
                DatabaseHelper.UpdateMeal(meal, image);
                UpdateSuggestions(meal);
                Notify();
            }
            
        }

        public void UpdateMeal(Meal meal)
        {
            UpdateMeal(meal, null);
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var o in observers)
            {
                o.Update();
            }
        }

        public List<Meal> GetLastNMeals(int n)
        {
            return meals.OrderByDescending(m => m.Timestamp).Take(n).ToList();
        }

        public List<Meal> GetUniqueByNameMeals()
        {
            return meals.GroupBy(m => m.Name).Select(m => m.Last()).ToList();
        }

        public List<Meal> GetMealsInTimePeriodAndWithKeywords(DateTime startTime, DateTime endTime, List<string> keywords)
        {
            return meals.FindAll(m => m.Timestamp.CompareTo(startTime) >= 0 && m.Timestamp.CompareTo(endTime) <= 0 && (keywords.Count == 0 || keywords.Any(m.Name.ToLowerInvariant().Contains))).OrderBy(m => m.Timestamp).ToList(); ;

        }
    }
}
