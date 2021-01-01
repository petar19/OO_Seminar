using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        internal IngredientCategory IngredientCategory { get; set; }
    }
}
