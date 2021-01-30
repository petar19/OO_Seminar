using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public interface IMealListItemController
    {
        void EditMeal(Meal meal);
        void DeleteMeal(Meal meal);
        void DuplicateMeal(Meal meal);
    }
}
