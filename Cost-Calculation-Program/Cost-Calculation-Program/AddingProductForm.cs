using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cost_Calculation_Lib;

namespace Cost_Calculation_Program
{
    public partial class AddingProductForm : Form
    {
        public AddingProductForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StorageForm storage = new StorageForm();
            storage.Show();
        }

        private void AddNewProductBtn_Click(object sender, EventArgs e)
        {
            MainProgram program = new MainProgram();

            if (program.existingProduct(ProductNameTextBox.Text))
            {
                Console.WriteLine("already exist");
                this.Hide();
                ErrorFormAlreadyExistProduct alreadyExistProduct = new ErrorFormAlreadyExistProduct();
                alreadyExistProduct.Show();
            }
            else 
            {
                if (program.addingNewProduct(ProductNameTextBox.Text, ProductPriceTextBox.Text))
                {
                    Console.WriteLine("adding");
                    this.Hide();
                    SuccessfulAdding successfulAdding = new SuccessfulAdding();
                    successfulAdding.Show();
                }
            }

        }
    }
}
