using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.View
{
    public interface ISuggestionsView
    {

        void SetSuggestedMeals(List<Meal> meals);
        void SetController(SuggestionsController controller);
        void SetComboBoxBasedOn(List<int> options);
        void SetComboBoxNumberOfMeals(List<int> options);
        
        int BasedOn { get; }
        int NumberOfMeals { get; }

    }
}
