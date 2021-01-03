﻿using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.View
{
    public interface IMealAddView
    {
        void SetController(MealAddController mealAddController);
        void Close();

        string MealName { get; set; }
        string Description { get; set; }
        string MealType { get; set; }
        string DishType { get; set; }
        string PreparationType { get; set; }
        string Location { get; set; }


        DateTime Timestamp { get; set; }
        int Rating { get; set; }
        int Calories { get; set; }
        int Price { get; set; }

        Image Image { get; set; }


    }
}
