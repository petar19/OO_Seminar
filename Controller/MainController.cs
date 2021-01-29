using OO_Seminar.DomainModel;
using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public class MainController : IObserver, IMealListItemController
    {
        private IMainView _view;
        private IMealRepository _mealRepository;

        public MainController(IMainView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _mealRepository = mealRepository;

            _mealRepository.Attach(this);

            RefreshMealList();


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

            List<Meal> meals = _mealRepository.GetAllMeals().OrderBy(m => m.Timestamp).ToList();

            Console.WriteLine("refreshing meal list");

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
    }
}
