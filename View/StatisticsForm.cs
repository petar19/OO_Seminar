using OO_Seminar.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OO_Seminar.View
{
    public partial class StatisticsForm : Form, IStatisticsView
    {
        private StatisticsController _controller;
        private Series ratings;
        private Series calories;
        private Series prices;
        private Series hours;


        private Series locations;
        private Series mealNames;
        private Series preparationTypes;
        private Series ingredients;





        public StatisticsForm()
        {
            InitializeComponent();
            ratings = chartRatings.Series.FindByName("Series1");
            calories = chartCalories.Series.FindByName("Series1");
            prices = chartPrices.Series.FindByName("Series1");
            hours = chartHours.Series.FindByName("Series1");


            locations = chartLocations.Series.FindByName("Series1");
            mealNames = chartMealNames.Series.FindByName("Series1");
            preparationTypes = chartPreparationTypes.Series.FindByName("Series1");
            ingredients = chartIngredients.Series.FindByName("Series1");


        }

        public void SetController(StatisticsController controller)
        {
            _controller = controller;
        }

        public void SetHoursData(Dictionary<int, int> data)
        {
            foreach (KeyValuePair<int, int> pair in data)
            {
                hours.Points.AddXY(pair.Key, pair.Value);
            }

        }

        public void SetRatingsData(Dictionary<int, int> data, double avg)
        {
            foreach(KeyValuePair<int, int> pair in data)
            {
                ratings.Points.AddXY(pair.Key, pair.Value);
            }

            chartRatings.Titles.First().Text = $"Meal ratings, average: {avg.ToString("N2")}";
        }

        public void SetCaloriesData(Dictionary<int, int> data, double avg)
        {
            foreach (KeyValuePair<int, int> pair in data)
            {
                calories.Points.AddXY(pair.Key, pair.Value);
            }

            chartCalories.Titles.First().Text = $"Meal calories, average: {avg.ToString("N2")}";
        }

        public void SetPricesData(Dictionary<int, int> data, double avg)
        {
            foreach (KeyValuePair<int, int> pair in data)
            {
                prices.Points.AddXY(pair.Key, pair.Value);
            }

            chartPrices.Titles.First().Text = $"Meal prices, average: {avg.ToString("N2")}";
        }

        public void SetLocationsData(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> pair in data)
            {
                var dp = new DataPoint();
                dp.SetValueY(pair.Value);
                dp.LegendText = pair.Key;
                dp.Label = pair.Value.ToString();
                locations.Points.Add(dp);
            }
        }

        public void SetMealNamesData(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> pair in data)
            {
                var dp = new DataPoint();
                dp.SetValueY(pair.Value);
                dp.LegendText = pair.Key;
                dp.Label = pair.Value.ToString();
                mealNames.Points.Add(dp);
            }
        }

        public void SetPreparationTypesData(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> pair in data)
            {
                var dp = new DataPoint();
                dp.SetValueY(pair.Value);
                dp.LegendText = pair.Key;
                dp.Label = pair.Value.ToString();
                preparationTypes.Points.Add(dp);
            }
        }

        public void SetIngredientsData(Dictionary<string, int> data)
        {
            foreach (KeyValuePair<string, int> pair in data)
            {
                var dp = new DataPoint();
                dp.SetValueY(pair.Value);
                dp.LegendText = pair.Key;
                dp.Label = pair.Value.ToString();
                ingredients.Points.Add(dp);
            }
        }
    }
}
