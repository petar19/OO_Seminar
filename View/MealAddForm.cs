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

        public void SetToUpdateMode()
        {
            Text = "Update a meal";
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            _controller.chooseImageBtn();
        }


        public void SetMealTypeOptions(List<string> options)
        {
            comboBoxMealType.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxMealType.DataSource = options;
            comboBoxMealType.SelectedIndex = -1;
        }

        public void SetLocationOptions(List<string> options)
        {
            comboBoxLocation.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxLocation.DataSource = options;
            comboBoxLocation.SelectedIndex = -1;
        }

        public void SetDishTypeOptions(List<string> options)
        {
            comboBoxDishType.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxDishType.DataSource = options;
            comboBoxDishType.SelectedIndex = -1;
        }

        public void SetPreparationTypeOptions(List<string> options)
        {
            comboBoxPreparationType.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxPreparationType.DataSource = options;
            comboBoxPreparationType.SelectedIndex = -1;
        }

        public string MealName { get => comboBoxName.Text; set => comboBoxName.Text = value; }
        public string Description { get => richTextBoxDescription.Text; set => richTextBoxDescription.Text = value; }
        public string MealType { get => comboBoxMealType.Text; set => comboBoxMealType.Text = value; }
        public string DishType { get => comboBoxDishType.Text; set => comboBoxDishType.Text = value; }
        public string PreparationType { get => comboBoxPreparationType.Text; set => comboBoxPreparationType.Text = value; }
        public new string Location { get => comboBoxLocation.Text; set => comboBoxLocation.Text = value; }

        public DateTime Timestamp { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public int Rating { get => trackBarRating.Value; set => trackBarRating.Value = value; }
        public int Calories { get => trackBarCalories.Value; set => trackBarCalories.Value = value; }
        public int Price { get => trackBarPrice.Value; set => trackBarPrice.Value = value; }
        public Image Image { get => pictureBoxMealImage.Image; set => pictureBoxMealImage.Image = value; }

        private void buttonAddIngredient_Click(object sender, EventArgs e)
        {
            _controller.addIngredientBtn();
        }


        public void SetIngredientListItems(IngredientListItem[] ingredientListItems)
        {
            panelIngredientList.Controls.Clear();
            panelIngredientList.Controls.AddRange(ingredientListItems);
        }

        private void buttonRemoveIngredient_Click(object sender, EventArgs e)
        {
            _controller.removeIngredientBtn();
        }

        public void EnableConfirmBtn(bool enabled)
        {
            confirmBtn.Enabled = enabled;
        }

        private void comboBoxName_TextChanged(object sender, EventArgs e)
        {
            _controller.OnMealNameChanged();

        }
    }
}
