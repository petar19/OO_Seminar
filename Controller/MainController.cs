using OO_Seminar.DomainModel;
using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar.Controller
{
    public class MainController : IObserver, IMealListItemController
    {
        private IMainView _view;
        private IMealRepository _mealRepository;

        private List<string> searchKeywords;
        private DateTime startTime;
        private DateTime endTime;


        public MainController(IMainView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _mealRepository = mealRepository;

            _mealRepository.Attach(this);

            searchKeywords = new List<string>();

            RemoveFilters();

        }
        public void Update()
        {
            RefreshMealList();
        }

        public void AddNewMeal()
        {
            MealAddForm mealAddForm = new MealAddForm();
            MealAddController mealAddController = new MealAddController(mealAddForm, _mealRepository);

            mealAddForm.ShowDialog();
        }


        private void RefreshMealList()
        {
            _view.Clear();

            if (_mealRepository.GetNumberOfMeals() == 0)
            {
                _view.SetSuggestionsAndStatisticsButtons(false);
                return;
            }

            _view.SetSuggestionsAndStatisticsButtons(true);
            List<Meal> meals = _mealRepository.GetMealsInTimePeriodAndWithKeywords(startTime, endTime, searchKeywords);

            Console.WriteLine($"first meal id: {meals[2].Id}");

            _view.AddMealList(meals);
        }

        public void EditMeal(Meal meal)
        {
            MealAddForm mealAddForm = new MealAddForm();
            MealAddController mealAddController = new MealAddController(mealAddForm, _mealRepository, meal);

            mealAddForm.ShowDialog();
        }

        public void DeleteMeal(Meal meal)
        {
            _mealRepository.DeleteMeal(meal);
        }


        public void DuplicateMeal(Meal meal)
        {
            _mealRepository.DuplicateMeal(meal);
        }

        public void OpenStatistics()
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            StatisticsController statisticsController = new StatisticsController(statisticsForm, _mealRepository);

            statisticsForm.ShowDialog();

        }

        public void OpenSuggestions()
        {
            SuggestionsForm suggestionsForm = new SuggestionsForm();
            SuggestionsController suggestionsController = new SuggestionsController(suggestionsForm, _mealRepository);

            suggestionsForm.ShowDialog();
        }

        public void Filter()
        {
            startTime = _view.StartTime;
            endTime = _view.EndTime;
            searchKeywords = _view.Keywords.Split(new string[] { ",", "\r", "\n", " "}, StringSplitOptions.RemoveEmptyEntries).Select(s => s.ToLowerInvariant()).ToList();

            RefreshMealList();

        }

        public void RemoveFilters()
        {
            searchKeywords.Clear();
            startTime = DateTime.Now.AddMonths(-1);
            endTime = DateTime.Now.AddDays(1);
            _view.StartTime = startTime;
            _view.EndTime = endTime;
            _view.Keywords = "";

            RefreshMealList();
        }


    }
}
