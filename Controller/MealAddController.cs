using OO_Seminar.DomainModel;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public class MealAddController
    {
        private IMealAddView _view;
        private Meal _meal;

        public MealAddController(IMealAddView view)
        {
            _view = view;
            _view.SetController(this);
        }

        public MealAddController(IMealAddView view, Meal meal)
        {
            _view = view;
            _meal = meal;
        }

        public void mealNameChanged()
        {

        }

        public void resetView()
        {
            // set view params according to meal
        }

    }
}
