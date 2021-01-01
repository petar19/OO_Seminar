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
        }

        public void addNewMeal()
        {
            MealAddForm mealAddForm = new MealAddForm();
            MealAddController mealAddController = new MealAddController(mealAddForm);

            mealAddForm.Show();
        }

    }
}
