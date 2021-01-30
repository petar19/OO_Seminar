using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar
{
    public class Suggestions
    {
        private readonly double nameWeight = 0.5;
        private readonly double ingredientsNumberWeight = 0.10;
        private readonly double ingredientsImportanceWeight = 0.15;
        private readonly double mealTypeWeight = 0.04;
        private readonly double dishTypeWeight = 0.02;
        private readonly double preparationTypeWeight = 0.09;
        private readonly double caloriesWeight = 0.04;
        private readonly double priceWeight = 0.03;
        private readonly double ratingWeight = 0.02;

        private readonly double suggestionPositionWeight = 0.15;
        private readonly double suggestionSimilarityWeight = 0.85;


        private Meal SuggestNextMeal(List<Meal> basedOn, List<Meal> mealsToChooseFrom)
        {
            Console.WriteLine("\nsuggesting next meal based on:");
            foreach (var m in basedOn) Console.WriteLine($"{m.Name}, {m.Timestamp}");
            Console.WriteLine("from:");
            foreach (var m in mealsToChooseFrom) Console.WriteLine($"{m.Name}, {m.Timestamp}");
            Console.WriteLine();

            int n = basedOn.Count;

            Dictionary<Meal, double> mealScores = new Dictionary<Meal, double>();



            for(int i = 0; i < n; i++)
            {
                foreach(var m in mealsToChooseFrom)
                {
                    double similarity = CalculateMealSimilarity(m, basedOn[i]);

                    double score = (suggestionPositionWeight * (i / n) + suggestionSimilarityWeight) * similarity;

                    Console.WriteLine($"{m.Name} compared to {basedOn[i].Name} scores {score}, similarity: {similarity}, position similarity: {i / n}");

                    mealScores[m] = mealScores.TryGetValue(m, out var currentScore) ? currentScore + score : score;

                    Console.WriteLine($"current score: {mealScores[m]}");
                }
            }

            return mealScores.OrderBy(m => m.Value).First().Key;

        }

        public List<Meal> GetSuggestedMeals(List<Meal> basedOn, List<Meal> mealsToChooseFrom, int howMany)
        {
            var suggestions = new List<Meal>();

            while (suggestions.Count < howMany)
            {
                var next = SuggestNextMeal(basedOn.Concat(suggestions).ToList(), mealsToChooseFrom);
                suggestions.Add(next);
            }
            suggestions.Reverse();

            return suggestions;
        }

        private double CalculateMealSimilarity(Meal m1, Meal m2)
        {
            Console.WriteLine($"\ncomparing meals {m1.Name} and {m2.Name}");

            double similarity = 0.0;

            var meal1Words = m1.Name.Split(' ').Select(s => s.ToLowerInvariant()).ToHashSet();
            var meal2Words = m2.Name.Split(' ').Select(s => s.ToLowerInvariant()).ToHashSet();
            var numberOfRepeatingWordsInName = meal1Words.Intersect(meal2Words).Count();
            double nameSimilarity =  (2 * numberOfRepeatingWordsInName / (meal1Words.Count + meal2Words.Count)); // repeatingWords / avgNumWords in meal names
            similarity += nameWeight * nameSimilarity;
            Console.WriteLine("name similarity:" + nameSimilarity);


            var mealTypeSimilarity = 0;
            if (m1.MealType != null && m2.MealType != null && m1.MealType.Equals(m2.MealType)) mealTypeSimilarity = 1; // if both are set and equal => 1, else => 0
            similarity += mealTypeWeight * mealTypeSimilarity;

            var dishTypeSimilarity = 0;
            if (m1.DishType != null && m2.DishType != null && m1.DishType.Equals(m2.DishType)) dishTypeSimilarity = 1;
            similarity += dishTypeWeight * dishTypeSimilarity;

            var preparationTypeSimilarity = 0;
            if (m1.PreparationType != null && m2.PreparationType != null && m1.PreparationType.Equals(m2.PreparationType)) preparationTypeSimilarity = 1;
            similarity += preparationTypeWeight * preparationTypeSimilarity;

            Console.WriteLine($"meal type similarity:{mealTypeSimilarity}, dish type similarity: {dishTypeSimilarity}, preparationTypeSimilarity:{preparationTypeSimilarity}");


            double caloriesSimilarity = 1 - 0.1 * Math.Abs(m1.Calories - m2.Calories); // weight * (1 - abs(diff)/10) => example: 5 and 7 => 1 - 2/10 = 0.8; 5 and 9 => 0.6
            similarity += caloriesWeight * caloriesSimilarity;
            double priceSimilarity = 1 - 0.1 * Math.Abs(m1.Price - m2.Price);
            similarity += priceWeight * priceSimilarity;
            double ratingSimilarity = 1 - 0.1 * Math.Abs(m1.Rating - m2.Rating);
            similarity += ratingWeight * ratingSimilarity;

            Console.WriteLine($"calories similarity:{caloriesSimilarity}, price similarity: {priceSimilarity}, rating similarity:{ratingSimilarity}");


            if (m1.Ingredients.Count != 0 && m2.Ingredients.Count != 0) // if one of the meals has no ingredients just skip this part
            {
                var meal1IngredientsDict = m1.Ingredients.ToDictionary(i => i.Ingredient, i => i.Importance); // {ingredient: importance}
                var meal2IngredientsDict = m2.Ingredients.ToDictionary(i => i.Ingredient, i => i.Importance);

                var repeatingIngredients = meal1IngredientsDict.Keys.ToHashSet().Intersect(meal2IngredientsDict.Keys.ToHashSet()); // ingredients that repeat in both meals

                //similar to comparing meal names, numRepeatingIngredients / avgNumIngredients
                double ingredientsNumberSimilarity = 2 * repeatingIngredients.Count() / (meal1IngredientsDict.Count + meal2IngredientsDict.Count);
                similarity += ingredientsNumberWeight * ingredientsNumberSimilarity;

                double ingredientsImportanceSimilarity = 0.0;
                foreach(var i in repeatingIngredients) // calculating sum of importance similiarities
                {
                    double ingredientSimilarity = 1 - 0.1 * Math.Abs(meal1IngredientsDict[i] - meal2IngredientsDict[i]);
                    Console.WriteLine($"ingredient {i} with imporances {meal1IngredientsDict[i]} and {meal2IngredientsDict[i]} has similarity: {ingredientSimilarity}");
                    ingredientsImportanceSimilarity += ingredientSimilarity;
                }

                if (repeatingIngredients.Count() > 0) ingredientsImportanceSimilarity /= repeatingIngredients.Count();
                similarity += ingredientsImportanceWeight * ingredientsImportanceSimilarity;

                Console.WriteLine($"ingredients number similarity:{ingredientsNumberSimilarity}, ingredient importance similarity: {ingredientsImportanceSimilarity} ");
            } else
            {
                Console.WriteLine("meals have no common ingredients");
            }

            Console.WriteLine($"calculated similarity: {similarity}\n");


            return similarity;
        }

    }
}
