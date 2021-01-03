using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel
{
    public class Meal
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string MealType { get; set; }
        public string DishType { get; set; }
        public string MealLocation { get; set; }
        public string PreparationType { get; set; }

        public DateTime Timestamp { get; set; }

        public List<MealIngredient> Ingredients { get; set; }

        public int Price { get; set; }
        public int Calories { get; set; }
        public int Rating { get; set; }

        public string Image{ get; set; }




    }
}
