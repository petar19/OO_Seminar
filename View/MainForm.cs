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
    }
}
