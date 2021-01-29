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


        public MealAddController(IMealAddView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _view.Image = Properties.Resources.MealArt;

            _mealRepository = mealRepository;

            mealIngredientListItems = new List<IngredientListItem>();

            ingredientsSuggestions = _mealRepository.GetAllIngredients();

            InitializeComboBoxOptions();
        }

        private void InitializeComboBoxOptions()
        {
            _view.SetMealTypeOptions(_mealRepository.GetAllMealTypes());
            _view.SetLocationOptions(_mealRepository.GetAllLocations());
            _view.SetDishTypeOptions(_mealRepository.GetAllDishTypes());
            _view.SetPreparationTypeOptions(_mealRepository.GetAllPreparationTypes());

        }

        public MealAddController(IMealAddView view, Meal meal)
        {
            _view = view;
            _meal = meal;
        }

        public void mealNameChanged()
        {

        }

        public void saveMealBtn()
        {
            Meal meal = new Meal { Name = _view.MealName, Description = _view.Description, MealType = _view.MealType, Timestamp = _view.Timestamp, Rating = _view.Rating, Calories = _view.Calories, Price = _view.Price, DishType = _view.DishType, Location = _view.Location, PreparationType = _view.PreparationType, Ingredients = mealIngredientListItems.ConvertAll(x => new MealIngredient { Ingredient = x.Ingredient, Importance = x.Importance })};


            _mealRepository.AddMeal(meal, _view.Image);

            _view.Close();
        }

        public void resetBtn()
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
            } else
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
                
                foreach(var i in _meal.Ingredients)
                {
                    IngredientListItem ili = new IngredientListItem(new List<string>()); // TODO ADD SUGGESTIONS BUT FILTER OUT ONES THAT ARE ALREADY IN LIST
                    ili.Ingredient = i.Ingredient;
                    ili.Importance = i.Importance;

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

            mealIngredientListItems.Reverse();
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
