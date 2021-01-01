using OO_Seminar.Controller;
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

        }
    }
}
