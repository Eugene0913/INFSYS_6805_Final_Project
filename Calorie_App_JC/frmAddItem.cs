using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public partial class frmAddItem : Form
    {
        public frmAddItem()
        {
            InitializeComponent();
            LoadFoodCategories();
        }

        private void LoadFoodCategories()
        {
            DatabaseMethods dbMethods = new DatabaseMethods();


        }
    }
}
