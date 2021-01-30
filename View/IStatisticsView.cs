using OO_Seminar.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Seminar.View
{
    public interface IStatisticsView
    {
        void SetController(StatisticsController controller);
        void SetHoursData(Dictionary<int, int> data);
        void SetRatingsData(Dictionary<int, int> data, double avg);
        void SetCaloriesData(Dictionary<int, int> data, double avg);
        void SetPricesData(Dictionary<int, int> data, double avg);
        void SetLocationsData(Dictionary<string, int> data);
        void SetMealNamesData(Dictionary<string, int> data);
        void SetPreparationTypesData(Dictionary<string, int> data);
        void SetIngredientsData(Dictionary<string, int> data);




    }
}
