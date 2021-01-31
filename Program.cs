using OO_Seminar.Controller;
using OO_Seminar.RepositoriesImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MealRepository mealRepository = MealRepository.getInstance(true);

            MainForm mainForm = new MainForm();
            MainController mainController = new MainController(mainForm, mealRepository);

            mainForm.ShowDialog();
        }
    }
}
