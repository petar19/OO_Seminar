using OO_Seminar.DomainModel;
using OO_Seminar.DomainModel.Repositories;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar.Controller
{
    public class MealAddController
    {
        private IMealAddView _view;
        private Meal _meal;

        private List<IngredientListItem> mealIngredientListItems;

        private IMealRepository _mealRepository;

        private List<string> ingredientsSuggestions;

        private bool imageChanged;


        public MealAddController(IMealAddView view, IMealRepository mealRepository)
        {
            Init(view, mealRepository);

        }

        public MealAddController(IMealAddView view, IMealRepository mealRepository, Meal meal)
        {
            _meal = meal;
            Init(view, mealRepository);
            _view.SetToUpdateMode();
        }

        private void Init(IMealAddView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);
            _view.EnableConfirmBtn(false);
            _mealRepository = mealRepository;
            ingredientsSuggestions = _mealRepository.GetAllIngredients();
            InitializeComboBoxOptions();
            mealIngredientListItems = new List<IngredientListItem>();
            ResetFields();
        }


        private void InitializeComboBoxOptions()
        {
            _view.SetMealTypeOptions(_mealRepository.GetAllMealTypes());
            _view.SetLocationOptions(_mealRepository.GetAllLocations());
            _view.SetDishTypeOptions(_mealRepository.GetAllDishTypes());
            _view.SetPreparationTypeOptions(_mealRepository.GetAllPreparationTypes());

        }


        public void OnMealNameChanged()
        {
            Console.WriteLine($"meal name changed to: {_view.MealName}");
            if (string.IsNullOrWhiteSpace(_view.MealName))
            {
                _view.EnableConfirmBtn(false);
            } else
            {
                _view.EnableConfirmBtn(true);
            }
        }

        public void saveMealBtn()
        {
            var ingredients = mealIngredientListItems.Where(x => !string.IsNullOrWhiteSpace(x.Ingredient)).Select(x => new MealIngredient { Ingredient = x.Ingredient, Importance = x.Importance }).GroupBy(x => x.Ingredient).Select(x => x.First()).ToList(); // first filter out ones with empty string

            Meal meal = new Meal { Name = _view.MealName, Description = _view.Description, MealType = _view.MealType, Timestamp = _view.Timestamp, Rating = _view.Rating, Calories = _view.Calories, Price = _view.Price, DishType = _view.DishType, Location = _view.Location, PreparationType = _view.PreparationType, Ingredients = ingredients};

            if (_meal == null) { // ADDING A NEW MEAL
                _mealRepository.AddMeal(meal, _view.Image);
            }
            else // UPDATING A MEAL
            {
                meal.Id = _meal.Id;
                meal.Image = _meal.Image;
                if (imageChanged)
                {
                    _mealRepository.UpdateMeal(meal, _view.Image);
                }
                _mealRepository.UpdateMeal(meal, null);

            }

            _view.Close();
        }

        public void resetBtn()
        {
            ResetFields();
            imageChanged = false;
        }

        private void ResetFields()
        {
            if (_meal == null)
            {
                _view.MealName = "";
                _view.Description = "";
                _view.Timestamp = DateTime.Now;
                _view.Rating = 6;
                _view.Calories = 6;
                _view.Price = 6;
                _view.MealType = "";
                _view.PreparationType = "";
                _view.DishType = "";
                _view.Location = "";
                _view.Image = Properties.Resources.MealArt;

                mealIngredientListItems.Clear();
                _view.SetIngredientListItems(mealIngredientListItems.ToArray());
            }
            else
            {
                _view.MealName = _meal.Name;
                _view.Description = _meal?.Description ?? "";
                _view.Timestamp = _meal.Timestamp;
                _view.Rating = _meal?.Rating ?? 6;
                _view.Calories = _meal?.Calories ?? 6;
                _view.Price = _meal?.Price ?? 6;
                _view.MealType = _meal?.MealType ?? "";
                _view.PreparationType = _meal?.PreparationType ?? "";
                _view.DishType = _meal?.DishType ?? "";
                _view.Location = _meal?.Location ?? "";
                _view.Image = _meal.Image == null ? Properties.Resources.MealArt : DatabaseHelper.GetMealImage(_meal.Image);

                mealIngredientListItems.Clear();

                var currentlyAddedIngredients = _meal.Ingredients.ConvertAll(i => i.Ingredient); // List of strings of meal ingredients
                var possibleIngredients = new List<string>(ingredientsSuggestions); // copy of ingredients suggestions
                possibleIngredients.RemoveAll(i => currentlyAddedIngredients.Contains(i)); // filter out currently added ingredients 
                foreach (var i in _meal.Ingredients)
                {

                    IngredientListItem ili = new IngredientListItem(possibleIngredients);
                    ili.Ingredient = i.Ingredient;
                    ili.Importance = i.Importance;
                    ili.Dock = DockStyle.Top;


                    mealIngredientListItems.Add(ili);
                }
                _view.SetIngredientListItems(mealIngredientListItems.ToArray());

            }
        }

        public void chooseImageBtn()
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Choose meal image";
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _view.Image = new Bitmap(dialog.FileName);
                imageChanged = true;
            }

        }

        public void addIngredientBtn()
        {
            var currentlyAddedIngredients = mealIngredientListItems.ConvertAll(i => i.Ingredient); // List of strings of currently added ingredients
            var possibleIngredients = new List<string>(ingredientsSuggestions); // copy of ingredients suggestions
            possibleIngredients.RemoveAll(i => currentlyAddedIngredients.Contains(i)); // filter out currently added ingredients so suggestions don't repeat

            IngredientListItem ili = new IngredientListItem(possibleIngredients);
            
            ili.Dock = DockStyle.Top;

            mealIngredientListItems.Add(ili);

            //mealIngredientListItems.Reverse();
            _view.SetIngredientListItems(mealIngredientListItems.ToArray());
        }

        public void removeIngredientBtn()
        {
            mealIngredientListItems.RemoveAll(x => x.IsSelected);

            mealIngredientListItems.Reverse();
            _view.SetIngredientListItems(mealIngredientListItems.ToArray());
        }

    }
}
