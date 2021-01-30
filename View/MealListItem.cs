using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OO_Seminar.DomainModel;
using OO_Seminar.Controller;

namespace OO_Seminar.View
{
    public partial class MealListItem : UserControl
    {
        private IMealListItemController _controller;
        private Meal _meal;

        public MealListItem(IMealListItemController controller, Meal meal)
        {
            InitializeComponent();
            _controller = controller;
            _meal = meal;

            SetFields();
        }

        public MealListItem(Meal meal)
        {
            InitializeComponent();
            _meal = meal;
            DisableButtonsAndTimestamp();

            SetFields();
        }

        private void DisableButtonsAndTimestamp()
        {
            pictureBoxDeleteBtn.Visible = false;
            pictureBoxDeleteBtn.Enabled = false;
            pictureBoxEditBtn.Visible = false;
            pictureBoxEditBtn.Enabled = false;
            pictureBoxDuplicateBtn.Visible = false;
            pictureBoxDuplicateBtn.Enabled = false;
            labelTimestamp.Visible = false;
        }

        private void SetFields()
        {
            Name = _meal.Name;
            Description = _meal.Description;
            MealType = _meal.MealType;
            DishType = _meal.DishType;
            PreparationType = _meal.PreparationType;
            Location = _meal.Location;
            Timestamp = _meal.Timestamp.ToString();
            Rating = _meal.Rating.ToString();
            Calories = _meal.Calories.ToString();
            Price = _meal.Price.ToString();
            Image = _meal.Image == null ? Properties.Resources.MealArt : DatabaseHelper.GetMealImage(_meal.Image);

            SetIngredients(_meal.Ingredients);
        }

        public void SetIngredients(List<MealIngredient> ingredients)
        {
            foreach(MealIngredient i in ingredients.OrderByDescending(i => i.Importance))
            {
                ListViewItem item = new ListViewItem(i.Ingredient);
                item.SubItems.Add(i.Importance.ToString());
                listViewIngredients.Items.Add(item);
            }

        }


        public new string Name { get => labelName.Text; set => labelName.Text = value; }
        public string Description { get => textBoxDescription.Text; set => textBoxDescription.Text = value; }
        public string MealType { get => labelMealType.Text; set => labelMealType.Text = value; }
        public string DishType { get => labelDishType.Text; set => labelDishType.Text = value; }
        public string PreparationType { get => labelPreparationType.Text; set => labelPreparationType.Text = value; }
        public new string Location { get => labelLocation.Text; set => labelLocation.Text = value; }

        public string Timestamp { get => labelTimestamp.Text; set => labelTimestamp.Text = value; }
        public string Rating { get => labelRating.Text; set => labelRating.Text = value; }
        public string Calories { get => labelCalories.Text; set => labelCalories.Text = value; }
        public string Price { get => labelPrice.Text; set => labelPrice.Text = value; }
        public Image Image { get => pictureBoxMealImage.Image; set => pictureBoxMealImage.Image = value; }

        private void pictureBoxEditBtn_Click(object sender, EventArgs e)
        {
            _controller?.EditMeal(_meal);
        }

        private void pictureBoxDeleteBtn_Click(object sender, EventArgs e)
        {
            _controller?.DeleteMeal(_meal);
        }

        private void pictureBoxDuplicate_Click(object sender, EventArgs e)
        {
            _controller?.DuplicateMeal(_meal);
        }
    }
}
