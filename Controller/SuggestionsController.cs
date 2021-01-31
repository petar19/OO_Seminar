using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.Controller
{
    public class SuggestionsController
    {
        private ISuggestionsView _view;
        private IMealRepository _mealRepository;

        private Suggestions suggestions;

        public SuggestionsController(ISuggestionsView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _mealRepository = mealRepository;

            suggestions = new Suggestions();

            Init();
        }

        private void Init()
        {
            _view.SetComboBoxBasedOn(Enumerable.Range(1, Math.Min(14, _mealRepository.GetNumberOfMeals())).ToList());
            _view.SetComboBoxNumberOfMeals(Enumerable.Range(1, 7).ToList());


        }

        public void Suggest()
        {
            var basedOn = _mealRepository.GetLastNMeals(_view.BasedOn);
            var mealsToChooseFrom = _mealRepository.GetUniqueByNameMeals();

            var suggested = suggestions.GetSuggestedMeals(basedOn, mealsToChooseFrom, _view.NumberOfMeals);

            _view.SetSuggestedMeals(suggested);
        }
    }
}
