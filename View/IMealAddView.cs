using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.View
{
    public interface IMealAddView
    {
        void SetController(MealAddController mealAddController);
        void Close();

        string MealName { get; }
        string Description { get; }
        MealType MealType { get; }
        DateTime Timestamp { get; }
        int Rating { get; }

    }
}
