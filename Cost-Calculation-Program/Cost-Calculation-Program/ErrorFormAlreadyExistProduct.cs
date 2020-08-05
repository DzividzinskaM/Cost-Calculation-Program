using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cost_Calculation_Program
{
    public partial class ErrorFormAlreadyExistProduct : Form
    {
        public ErrorFormAlreadyExistProduct()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddingProductForm addingProductForm = new AddingProductForm();
            addingProductForm.Show();
        }
    }
}
