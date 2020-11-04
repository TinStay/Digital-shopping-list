using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_playlist
{
    public partial class Form1 : Form
    {
        // Shopping lists
        List<string> products = new List<string>();
        List<double> prices = new List<double>();
        List<int> timesAdded = new List<int>();
        List<string> productTypes = new List<string>();

        // Commonly purchased lists
        List<string> commonProducts = new List<string>();
        List<double> commonPrices = new List<double>();
        List<int> commonTimesAdded = new List<int>();
        List<string> commonProductTypes = new List<string>();

        // Discounted products
        List<string> discountedProducts = new List<string>();
        List<int> discountedPercentages = new List<int>();

        // Update shown products in the list box
        private void updateShownProducts()
        {
            // Clear list box
            lbShownProducts.Items.Clear();

            if (products.Count > 0)
            {

                string filterType = cbType.SelectedItem.ToString();

                // Combobox filter
                switch (cbView.SelectedItem)
                {
                    case "All products":
                        // Fill list box
                        for (int i = 0; i < products.Count; i++)
                        {
                            // Filter by product type
                            if(productTypes[i] == filterType)
                            {
                                lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                            }else if(filterType == "All types")
                            {
                                lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                            }                            
                        }

                        // If there are no products with the current filters
                        if(lbShownProducts.Items.Count == 0)
                        {
                            lbShownProducts.Items.Add($"No products for the selected filters.");
                        }

                        break;

                    case "Cheapest":
                        double cheapestPrice = prices.Min();

                        // Loop through all products
                        for (int i = 0; i < products.Count; i++)
                        {
                            // If a product is with the cheapest price, add it to the cheapest list
                            if(prices[i] == cheapestPrice)
                            {
                                // Filter by product type
                                if (productTypes[i] == filterType)
                                {
                                    lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                                }
                                else if (filterType == "All types")
                                {
                                    lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                                }
                            }
                        }

                        // If there are no products with the current filters
                        if (lbShownProducts.Items.Count == 0)
                        {
                            lbShownProducts.Items.Add($"No products for the selected filters.");
                        }

                        break;

                    case "Most expensive":
                        double mostExpPrice = prices.Max();

                        // Loop through all products
                        for (int i = 0; i < products.Count; i++)
                        {
                            // If a product is with the cheapest price, add it to the cheapest list
                            if (prices[i] == mostExpPrice)
                            {
                                // Filter by product type
                                if (productTypes[i] == filterType)
                                {
                                    lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                                }
                                else if (filterType == "All types")
                                {
                                    lbShownProducts.Items.Add($"{products[i]}({productTypes[i]}) - {timesAdded[i]} x ${prices[i]} ");
                                }
                            }
                        }

                        // If there are no products with the current filters
                        if (lbShownProducts.Items.Count == 0)
                        {
                            lbShownProducts.Items.Add($"No products for the selected filters.");
                        }

                        break;

                    case "Discounted":
                        // Clear list box
                        lbShownProducts.Items.Clear();

                        for (int i = 0; i < discountedProducts.Count; i++)
                        {
                            //int index = products.IndexOf(discountedProducts);


                            lbShownProducts.Items.Add($"{discountedProducts[i]} - {discountedPercentages[i]}% ");

                        }
                        break;


                    default:
                        break;
                }

                // Update total price 
                updateTotalPrice();
                


            }

        }

        private void updateCommonList()
        {
            // Clear list box
            lbCommonProducts.Items.Clear();

            for (int i = 0; i < commonProducts.Count; i++)
            {
                // Get the index of the product from the product list
                //int index = coproducts.IndexOf(commonProducts[i]);

                lbCommonProducts.Items.Add($"{commonProducts[i]}({commonProductTypes[i]}) - {commonTimesAdded[i]} x ${commonPrices[i]} ");

            }
        }


        public Form1()
        {
            InitializeComponent();

            // Set default combo boxes values
            cbView.SelectedItem = "All products";
            cbType.SelectedItem = "All types";
            lbCommonProducts.Items.Add("No products added.");
        }

        
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Check if form is correctly filled
            if (tbNameAdd.Text != "" && tbPriceAdd.Text != "" && (rbFruit.Checked || rbMeat.Checked || rbVegetable.Checked || rbDairy.Checked))
            {
                // Declare variables for the new product
                string productName = tbNameAdd.Text.Trim(); // Trim() removes spaces from beginning and end of the string
                double productPrice = Convert.ToDouble(tbPriceAdd.Text.Trim());
                int productTimesAdded = Convert.ToInt32(nudAmount.Value);
                string newProductType;

                if (rbFruit.Checked)
                {
                    newProductType = "fruit";
                }else if (rbMeat.Checked)
                {
                    newProductType = "meat";
                }
                else if (rbVegetable.Checked)
                {
                    newProductType = "vegetable";
                }
                else
                {
                    newProductType = "dairy";
                }

                // Add to shopping list
                if (chbAddToShoppingList.Checked) {
                    // Add duplicate products
                    if (products.Contains(productName))
                    {
                        // Find the index of the existing product
                        int indexOfProduct = products.IndexOf(productName);

                        // Check if the new product has the same price
                        if (prices[indexOfProduct] != productPrice)
                        {
                            // This means we have the same product but with a different price.
                            // I would assume that the new product is from a different brand
                            // and add it separately
                            products.Add(productName);
                            prices.Add(productPrice);
                            timesAdded.Add(productTimesAdded);
                            productTypes.Add(newProductType);

                        }
                        else
                        {
                            // Update timesAdded for the existing product
                            timesAdded[indexOfProduct] += productTimesAdded;
                        }



                    }
                    else
                    {
                        // Add the new variables to their relative list
                        products.Add(productName);
                        prices.Add(productPrice);
                        timesAdded.Add(productTimesAdded);
                        productTypes.Add(newProductType);


                    }
                }
                


                // Add product to common products
                if (chbAddToCommonList.Checked)
                {
                    // Add duplicate products to common list
                    if (commonProducts.Contains(productName))
                    {
                        // Find the index of the existing product
                        int indexOfProduct = commonProducts.IndexOf(productName);

                        // Check if the new product has the same price
                        if (commonPrices[indexOfProduct] != productPrice)
                        {
                            // This means we have the same product but with a different price.
                            // I would assume that the new product is from a different brand
                            // and add it separately
                            commonProducts.Add(productName);
                            commonPrices.Add(productPrice);
                            commonTimesAdded.Add(productTimesAdded);
                            commonProductTypes.Add(newProductType);

                        }
                        else
                        {
                            // Update timesAdded for the existing product
                            commonTimesAdded[indexOfProduct] += productTimesAdded;
                        }



                    }
                    else
                    {
                        // Add product to common products
                        commonProducts.Add(productName);
                        commonPrices.Add(productPrice);
                        commonTimesAdded.Add(productTimesAdded);
                        commonProductTypes.Add(newProductType);


                    }
                }

                if (chbAddToDiscounted.Checked) {  
                

                    if (tbDiscount.Text != "")
                    {
                        int discount = Convert.ToInt32(tbDiscount.Text);

                        // Add product to discounted products
                        discountedProducts.Add(productName);
                        discountedPercentages.Add(discount);
                        

                    }
                    else
                    {
                        MessageBox.Show("Please enter discount percentage.");
                    }
                }

                


                // Update the list box with the new products
                updateShownProducts();

                // Update commonly purchased products list
                updateCommonList();


                // Clear text inputs from form 
                tbNameAdd.Text = "";
                tbPriceAdd.Text = "";
                tbDiscount.Text = "";

                //Clear radioboxes
                rbFruit.Checked = false;
                rbVegetable.Checked = false;
                rbMeat.Checked = false;
                rbDairy.Checked = false;

                // Clear checkboxes
                chbAddToShoppingList.Checked = false;
                chbAddToCommonList.Checked = false;
                chbAddToDiscounted.Checked = false;

                // Clear amount field
                nudAmount.Value = 0;

            }
            else
            {
                // Display error if both fields are empty
                MessageBox.Show("You should fill all fields in order to add a product to your list!");
            }

           

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (chbRemoveFromShoppingList.Checked != false || chbRemoveFromCommonList.Checked != false)
            {
                string productToBeRemoved = tbNameRemove.Text.Trim(); // Trim() removes spaces from beginning and end of the string
                int indexOfProduct = products.IndexOf(productToBeRemoved);
                int indexOfCommonProduct = commonProducts.IndexOf(productToBeRemoved);

                // Remove from the shopping list
                if (chbRemoveFromShoppingList.Checked)
                {
                    if (products.Contains(productToBeRemoved))
                    {

                        if (timesAdded[indexOfProduct] > 1)
                        {
                            // Decrease the number of times this item was added
                            timesAdded[indexOfProduct] -= 1;
                        }
                        else if (timesAdded[indexOfProduct] <= 1)
                        {
                            // Remove with index
                            products.RemoveAt(indexOfProduct);
                            prices.RemoveAt(indexOfProduct);
                            timesAdded.RemoveAt(indexOfProduct);
                        }

                        

                        // Clear text input from text box
                        tbNameRemove.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Product not found in your shopping cart.");
                    }


                }


                // Remove from the common list
                if (chbRemoveFromCommonList.Checked)
                {
                    if (commonProducts.Contains(productToBeRemoved))
                    {

                        if (commonTimesAdded[indexOfCommonProduct] > 1)
                        {
                            // Decrease the number of times this item was added
                            commonTimesAdded[indexOfCommonProduct] -= 1;
                        }
                        else if (commonTimesAdded[indexOfCommonProduct] <= 1)
                        {
                            // Remove with index
                            commonProducts.RemoveAt(indexOfCommonProduct);
                            commonPrices.RemoveAt(indexOfCommonProduct);
                            commonTimesAdded.RemoveAt(indexOfCommonProduct);
                        }

                        

                        // Clear text input from text box
                        tbNameRemove.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Product not found in your shopping cart.");
                    }
                }

                

                //Update total price
                updateTotalPrice();

            }
            else if(chbRemoveFromShoppingList.Checked == false && chbRemoveFromCommonList.Checked == false)
            {
                MessageBox.Show("Please select which list you want to remove the item from.");
            }

            // Update shopping list box
            updateShownProducts();

            // Update common list box
            updateCommonList();
        }

        // Update list everytime combobox selected value changes
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateShownProducts();
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateShownProducts();
        }

        private void btnSelectCommon_Click(object sender, EventArgs e)
        {
            // Clear shopping list
            products.Clear();
            prices.Clear();
            timesAdded.Clear();
            productTypes.Clear();

            for (int i = 0; i < commonProducts.Count; i++)
            {
              
                // Push common products to shopping list
                products.Add(commonProducts[i]);
                prices.Add(commonPrices[i]);
                timesAdded.Add(commonTimesAdded[i]);
                productTypes.Add(commonProductTypes[i]);
            }

            updateShownProducts();
            
        }

        // Update total price
        double totalPrice;

        private void updateTotalPrice()
        {
            
            for (int i = 0; i < discountedProducts.Count; i++)
            {

                if (products.Contains(discountedProducts[i]))
                {
                    int indexProduct = products.IndexOf(discountedProducts[i]);

                    // If the product we have put in our shopping list is discounted
                    double discountedPrice = prices[indexProduct] * (discountedPercentages[i] / 100);
                    totalPrice += discountedPrice;
                }
                else
                {
                    totalPrice += prices[i];
                }

            }

            // Update total price label
            lblTotalPrice.Text = $"Total price: ${totalPrice}";
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbAddToDiscounted_CheckedChanged(object sender, EventArgs e)
        {
           
            
        }

        private void chbAddToDiscounted_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chbAddToDiscounted.Checked)
            {
                // Show percentage field
                tbDiscount.ReadOnly = false;
            }
            else
            {
                // Hide percentage field
                tbDiscount.ReadOnly = true;
            }
        }
    }


}

