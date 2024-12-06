using StudentHousing.ObjectClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousing.Forms
{
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
            UpdateListBox();
        }
        private void UpdateListBox()
        {
            lbShoppingList.Items.Clear();
            List<Product> shoppingList = ShoppingList.GetProducts();
            foreach (Product product in shoppingList)
            {
                lbShoppingList.Items.Add(product.ToString());

            }
            decimal totalSum = shoppingList.Sum(product => product.Price * product.Amount);
            lblTotalPrice.Text = $"Total sum of all items: {totalSum.ToString()}";
        }


        private void btnAddItem_Click(object sender, EventArgs e)
        {

            string productName = tbItemName.Text;
            decimal productPrice = Convert.ToDecimal(tbItemPrice.Text);
            int productAmount = Convert.ToInt32(numUDAmount.Text);
            string userId = "1234";
            if (productName != "")
            {
                Product newProduct = new Product(userId, productName, productPrice, productAmount);
                ShoppingList.AddProduct(newProduct);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Please fill all the fields!");
            }

        }
    }
}
