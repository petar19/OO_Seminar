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
            _controller.insertMeal();
        }
           
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLOSE BTN CLICKED");

            Close();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("RESET BTN CLICKED");

            _controller.resetView();
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



        public string MealName { get => comboBoxName.Text; set => comboBoxName.Text = value; }
        public string Description { get => richTextBoxDescription.Text; set => richTextBoxDescription.Text = value; }
        public MealType MealType { get => (MealType) Enum.Parse(typeof(MealType), comboBoxMealType.Text); set => comboBoxMealType.Text = value.ToString(); }
        public DateTime Timestamp { get => dateTimePicker.Value; set => dateTimePicker.Value = value; }
        public int Rating { get => trackBarRating.Value; set => trackBarRating.Value = value; }




    }
}
