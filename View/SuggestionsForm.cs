using OO_Seminar.Controller;
using OO_Seminar.DomainModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar.View
{
    public partial class SuggestionsForm : Form, ISuggestionsView
    {
        SuggestionsController _controller;

        public SuggestionsForm()
        {
            InitializeComponent();
        }

        private MealListItem CreateMealListItem(Meal meal)
        {
            var mealListItem = new MealListItem(meal);
            mealListItem.Dock = DockStyle.Top;
            return mealListItem;
        } 

        public void SetSuggestedMeals(List<Meal> meals)
        {
            panelSuggestedMeals.Controls.Clear();

            var items = meals.Select((m, index) => CreateMealListItem(m)).ToArray();

            panelSuggestedMeals.Controls.AddRange(items);
        }

        public void SetController(SuggestionsController controller)
        {
            _controller = controller;
        }

        private void suggestBtn_Click(object sender, EventArgs e)
        {
            _controller.Suggest();
        }

        public void SetComboBoxBasedOn(List<int> options)
        {
            comboBoxBasedOn.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxBasedOn.DataSource = options;
        }

        public void SetComboBoxNumberOfMeals(List<int> options)
        {
            comboBoxNumberOfMeals.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxNumberOfMeals.DataSource = options;
        }

        public int BasedOn{ get => (int)comboBoxBasedOn.SelectedItem; }
        public int NumberOfMeals { get => (int)comboBoxNumberOfMeals.SelectedItem; }


    }
}
