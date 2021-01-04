using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using OO_Seminar.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar
{
    public partial class MainForm : Form, IMainView
    {
        private MainController _controller;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addMealBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ADD MEAL BTN CLICKED");

            _controller.addNewMeal();
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }


        public void AddMealToList(Meal meal)
        {
            MealListItem item = new MealListItem();

            item.Name = meal.Name;
            item.Description = meal.Description;
            item.MealType = meal.MealType;
            item.DishType = meal.DishType;
            item.PreparationType = meal.PreparationType;
            item.Location = meal.Location;
            item.Timestamp = meal.Timestamp.ToString();
            item.Rating = meal.Rating.ToString();
            item.Calories = meal.Calories.ToString();
            item.Price = meal.Price.ToString();
            item.Image = meal.Image == null ? Properties.Resources.MealArt : DatabaseHelper.GetMealImage(meal.Image);

            item.SetIngredients(meal.Ingredients);

            item.Dock = DockStyle.Top;

            panelMeals.Controls.Add(item);

        }

        public void Clear()
        {
            panelMeals.Controls.Clear();
        }
    }
}
