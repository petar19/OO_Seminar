using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar
{
    class Statistics
    {
        private readonly string DEFAULT_LOCATION = "Nepoznato";
        private readonly string DEFAULT_PREPARATION_TYPE = "Nepoznato";

        public Dictionary<int, int> Hours { get; private set; }

        public Dictionary<int, int> Ratings { get; private set; }
        public double RatingSum { get; private set; }
        public double AvgRating { get => RatingSum / NumMeals; }

        public Dictionary<int, int> Calories { get; private set; }
        public double CaloriesSum { get; private set; }
        public double AvgCalories { get => CaloriesSum / NumMeals; }

        public Dictionary<int, int> Prices { get; private set; }
        public double PriceSum { get; private set; }
        public double AvgPrice { get => PriceSum / NumMeals; }

        public Dictionary<string, int> Locations { get; private set; }
        public Dictionary<string, int> PreparationTypes { get; private set; }
        public Dictionary<string, int> MealNames { get; private set; }
        public Dictionary<string, int> Ingredients { get; private set; }
        public int NumMeals { get; private set; }


        public Statistics()
        {
            Ratings = new Dictionary<int, int>();
            Calories = new Dictionary<int, int>();
            Prices = new Dictionary<int, int>();
            Hours = new Dictionary<int, int>();


            Locations = new Dictionary<string, int>();
            PreparationTypes = new Dictionary<string, int>();

            MealNames = new Dictionary<string, int>();
            Ingredients = new Dictionary<string, int>();
        }

        public void AddStatsForMeal(Meal meal)
        {
            NumMeals++;

            Hours[meal.Timestamp.Hour] = Hours.TryGetValue(meal.Timestamp.Hour, out var v0) ? ++v0 : 1;

            Ratings[meal.Rating] = Ratings.TryGetValue(meal.Rating, out var v1) ? ++v1 : 1;
            Calories[meal.Calories] = Calories.TryGetValue(meal.Calories, out var v2) ? ++v2 : 1;
            Prices[meal.Price] = Prices.TryGetValue(meal.Price, out var v3) ? ++v3 : 1;

            RatingSum += meal.Rating;
            CaloriesSum += meal.Calories;
            PriceSum += meal.Price;


            if (meal.Location != null) Locations[meal.Location] = Locations.TryGetValue(meal.Location, out var v4) ? ++v4 : 1;
            else Locations[DEFAULT_LOCATION] = Locations.TryGetValue(DEFAULT_LOCATION, out var v4) ? ++v4 : 1;

            if (meal.PreparationType != null) PreparationTypes[meal.PreparationType] = PreparationTypes.TryGetValue(meal.PreparationType, out var v5) ? ++v5 : 1;
            else PreparationTypes[DEFAULT_PREPARATION_TYPE] = PreparationTypes.TryGetValue(DEFAULT_PREPARATION_TYPE, out var v4) ? ++v4 : 1;

            MealNames[meal.Name] = MealNames.TryGetValue(meal.Name, out var v6) ? ++v6 : 1;

            foreach(var i in meal.Ingredients)
            {
                Ingredients[i.Ingredient] = Ingredients.TryGetValue(i.Ingredient, out var v7) ? ++v7 : 1;
            }

            Console.WriteLine($"meal {meal.Name}, {meal.Timestamp} added");
            Console.WriteLine(this);

        }

        public void AddStatsForMeals(List<Meal> meals)
        {
            foreach(var m in meals)
            {
                AddStatsForMeal(m);
            }
        }

        public override string ToString()
        {
            string output = "";

            output += $"Statistics, {NumMeals} meals added\n\nRatings:\n";

            foreach(KeyValuePair<int,int> pair in Ratings)
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nHours:\n";

            foreach (KeyValuePair<int, int> pair in Hours)
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nCalories:\n";

            foreach (KeyValuePair<int, int> pair in Calories)
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nPrices:\n";

            foreach (KeyValuePair<int, int> pair in Prices)
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nLocations:\n";

            foreach (KeyValuePair<string, int> pair in Locations.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nPreparation types:\n";

            foreach (KeyValuePair<string, int> pair in PreparationTypes.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nMeal names:\n";

            foreach (KeyValuePair<string, int> pair in MealNames.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            output += "\nIngredients:\n";

            foreach (KeyValuePair<string, int> pair in Ingredients.OrderByDescending(p => p.Value).ThenBy(p => p.Key))
            {
                output += $"{pair.Key}:{pair.Value}\n";
            }

            return output;

        }



    }
}
