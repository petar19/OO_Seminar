using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel
{
    public class MealIngredient
    {
        public Ingredient Ingredient { get; set; }
        public float Importance { get; set; }
    }
}
