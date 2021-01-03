using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OO_Seminar.View
{
    public partial class IngredientListItem : UserControl
    {
        public bool IsSelected;

        public IngredientListItem(List<string> options)
        {
            InitializeComponent();
            comboBoxIngredientName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxIngredientName.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxIngredientName.DataSource = options;
        }

        private void checkBoxIngredientListItem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIngredientListItem.Checked) IsSelected = true;
            else IsSelected = false;
        }
    }
}
