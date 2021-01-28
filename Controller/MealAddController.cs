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

        private List<IngredientListItem> ingredients;

        private IMealRepository _mealRepository;


        public MealAddController(IMealAddView view, IMealRepository mealRepository)
        {
            _view = view;
            _view.SetController(this);

            _view.Image = Properties.Resources.MealArt;

            _mealRepository = mealRepository;

            ingredients = new List<IngredientListItem>();

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
            Meal meal = new Meal { Name = _view.MealName, Description = _view.Description, MealType = _view.MealType, Timestamp = _view.Timestamp, Rating = _view.Rating, Calories = _view.Calories, Price = _view.Price, DishType = _view.DishType, Location = _view.Location, PreparationType = _view.PreparationType, Ingredients = ingredients.ConvertAll(x => new MealIngredient { Ingredient = x.Ingredient, Importance = x.Importance })};

            Console.WriteLine("inserting meal: {0} {1} {2} {3} {4} {5} {6}", meal.Id, meal.Name, meal.Description, meal.DishType, meal.Timestamp, meal.Rating, meal.Calories);

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

                ingredients.Clear();
                _view.SetIngredientListItems(ingredients.ToArray());
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

                ingredients.Clear();
                
                foreach(var i in _meal.Ingredients)
                {
                    IngredientListItem ili = new IngredientListItem(new List<string>());
                    ili.Ingredient = i.Ingredient;
                    ili.Importance = i.Importance;

                    ingredients.Add(ili);
                }

                _view.SetIngredientListItems(ingredients.ToArray());
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
            IngredientListItem ili = new IngredientListItem(new List<string>());
            
            ili.Dock = DockStyle.Top;

            ingredients.Add(ili);

            ingredients.Reverse();
            _view.SetIngredientListItems(ingredients.ToArray());
        }

        public void removeIngredientBtn()
        {
            ingredients.RemoveAll(x => x.IsSelected);

            ingredients.Reverse();
            _view.SetIngredientListItems(ingredients.ToArray());
        }

    }
}
