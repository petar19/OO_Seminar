using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.View;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public class StatisticsController
    {
        private IStatisticsView _view;
        private IMealRepository _mealRepository;

        private Statistics statistics;

        public StatisticsController(IStatisticsView view, IMealRepository mealRepository)
        {
            _view = view;
            _mealRepository = mealRepository;
            _view.SetController(this);

            statistics = new Statistics();
            statistics.AddStatsForMeals(_mealRepository.GetAllMeals());

            Init();


        }

        private void Init()
        {
            _view.SetRatingsData(statistics.Ratings, statistics.AvgRating);
            _view.SetCaloriesData(statistics.Calories, statistics.AvgCalories);
            _view.SetPricesData(statistics.Prices, statistics.AvgPrice);
            _view.SetHoursData(statistics.Hours);


            _view.SetLocationsData(statistics.Locations);
            _view.SetMealNamesData(statistics.MealNames);
            _view.SetPreparationTypesData(statistics.PreparationTypes);
            _view.SetIngredientsData(statistics.Ingredients);



        }


    }
}
