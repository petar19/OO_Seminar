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



        public StatisticsForm()
        {
            InitializeComponent();
            ratings = chartRatings.Series.FindByName("Ratings");
            calories = chartCalories.Series.FindByName("Calories");
            prices = chartPrices.Series.FindByName("Prices");

        }

        public void SetController(StatisticsController controller)
        {
            _controller = controller;
        }

        public void SetRatingsData(Dictionary<int, int> data, double avg)
        {
            foreach(KeyValuePair<int, int> pair in data)
            {
                ratings.Points.AddXY(pair.Key, pair.Value);
            }

            chartRatings.Titles.First().Text = $"Meal ratings, average: {avg}";
        }

        public void SetCaloriesData(Dictionary<int, int> data, double avg)
        {
            foreach (KeyValuePair<int, int> pair in data)
            {
                calories.Points.AddXY(pair.Key, pair.Value);
            }

            chartCalories.Titles.First().Text = $"Meal calories, average: {avg}";
        }

        public void SetPricesData(Dictionary<int, int> data, double avg)
        {
            foreach (KeyValuePair<int, int> pair in data)
            {
                prices.Points.AddXY(pair.Key, pair.Value);
            }

            chartPrices.Titles.First().Text = $"Meal prices, average: {avg}";
        }
    }
}
