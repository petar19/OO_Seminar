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

        public DateTime StartTime { get => dateTimePickerStartTime.Value; set => dateTimePickerStartTime.Value = value; }
        public DateTime EndTime { get => dateTimePickerEndTime.Value; set => dateTimePickerEndTime.Value = value; }
        public string Keywords { get => richTextBoxKeywords.Text; set => richTextBoxKeywords.Text = value; }

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

            _controller.AddNewMeal();
        }

        public void SetController(MainController controller)
        {
            _controller = controller;
        }


        private MealListItem CreateMealListItem(Meal meal)
        {
            MealListItem item = new MealListItem(_controller, meal);

            item.Dock = DockStyle.Top;

            return item;
        }

        public void Clear()
        {
            panelMeals.Controls.Clear();
        }

        public void AddMealList(List<Meal> meals)
        {
            var items = meals.Select((m, index) => CreateMealListItem(m)).ToArray();

            panelMeals.Controls.AddRange(items);
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            _controller.OpenStatistics();
        }

        private void buttonSuggestions_Click(object sender, EventArgs e)
        {
            _controller.OpenSuggestions();
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            _controller.Filter();
        }

        private void removeFiltersBtn_Click(object sender, EventArgs e)
        {
            _controller.RemoveFilters();
        }

        public void SetSuggestionsAndStatisticsButtons(bool enabled)
        {
            buttonStats.Enabled = enabled;
            buttonSuggestions.Enabled = enabled;
        }
    }
}
