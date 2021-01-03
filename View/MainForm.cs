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
            ListViewItem item = new ListViewItem(meal.Name);
            item.SubItems.Add(meal.MealType);
            item.SubItems.Add(meal.Timestamp.ToString());
            item.SubItems.Add(meal.Rating.ToString());

            listViewMeals.Items.Add(item);

        }

        private void listViewMeals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            listViewMeals.Items.Clear();
        }
    }
}
