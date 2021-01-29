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
    public class MainController : IObserver
    {
        private IMainView _view;
        private IMealRepository _mealRepository;

        public MainController(IMainView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _mealRepository = mealRepository;

            _mealRepository.Attach(this);

            refreshMealList();


        }
        public void Update()
        {
            refreshMealList();
        }

        public void addNewMeal()
        {
            MealAddForm mealAddForm = new MealAddForm();
            MealAddController mealAddController = new MealAddController(mealAddForm, _mealRepository);

            mealAddForm.ShowDialog();
        }


        private void refreshMealList()
        {
            _view.Clear();

            List<Meal> meals = _mealRepository.GetAllMeals();

            Console.WriteLine("refershing meal list");
            
            foreach(Meal meal in meals)
            {
                Console.WriteLine("{0} {1} {2}", meal.Name, meal.Description, meal.Timestamp);
                _view.AddMealToList(meal);
            }
        }

    }
}
