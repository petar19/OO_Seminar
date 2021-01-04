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

namespace OO_Seminar.View
{
    public partial class MealListItem : UserControl
    {
        public MealListItem()
        {
            InitializeComponent();
        }

        public void SetIngredients(List<MealIngredient> ingredients)
        {
            foreach(MealIngredient i in ingredients)
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
    }
}
