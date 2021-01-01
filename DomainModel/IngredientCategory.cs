using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.DomainModel
{
    class IngredientCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IngredientCategory Parent { get; set; }
    }
}
