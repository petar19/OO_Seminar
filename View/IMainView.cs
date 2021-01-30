using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.View
{
    public interface IMainView
    {
        void SetController(MainController mainController);
        void AddMealList(List<Meal> meals);
        void Clear();

    }
}
