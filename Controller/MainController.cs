using OO_Seminar.DomainModel;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public class MainController
    {
        private IMainView _view;
        public MainController(IMainView view)
        {
            _view = view;
            _view.SetController(this);

            refreshMealList();
        }

        public void addNewMeal()
        {
            MealAddForm mealAddForm = new MealAddForm();
            MealAddController mealAddController = new MealAddController(mealAddForm);

            mealAddForm.ShowDialog();
            refreshMealList();
        }

        private void refreshMealList()
        {
            _view.Clear();

            List<Meal> meals = DatabaseHelper.GetAllMeals();

            Console.WriteLine("refershing meal list");
            
            foreach(Meal meal in meals)
            {
                Console.WriteLine("{0} {1} {2}", meal.Name, meal.Description, meal.Timestamp);
                _view.AddMealToList(meal);
            }
        }

    }
}
