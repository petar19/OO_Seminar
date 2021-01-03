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
    public partial class MealAddForm : Form, IMealAddView
    {
        private MealAddController _controller;
        public MealAddForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _controller.saveMealBtn();
        }
           
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLOSE BTN CLICKED");

            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RESET BTN CLICKED");

            _controller.resetBtn();
        }

        public void SetController(MealAddController controller)
        {
            _controller = controller;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mealNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _controller.mealNameChanged();
        }
        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            _controller.chooseImageBtn();
        }

        public string MealName { get => comboBoxName.Text; set => comboBoxName.Text = value; }
        public string Description { get => richTextBoxDescription.Text; set => richTextBoxDescription.Text = value; }
        public string MealType { get => comboBoxMealType.Text; set => comboBoxMealType.Text = value; }
        public string DishType { get => comboBoxDishType.Text; set => comboBoxDishType.Text = value; }
        public string PreparationType { get => comboBoxPreparationType.Text; set => comboBoxPreparationType.Text = value; }
        public string Location { get => comboBoxLocation.Text; set => comboBoxLocation.Text = value; }

        public DateTime Timestamp { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public int Rating { get => trackBarRating.Value; set => trackBarRating.Value = value; }
        public int Calories { get => trackBarCalories.Value; set => trackBarCalories.Value = value; }
        public int Price { get => trackBarPrice.Value; set => trackBarPrice.Value = value; }
        public Image Image { get => pictureBoxMealImage.Image; set => pictureBoxMealImage.Image = value; }

    }
}
