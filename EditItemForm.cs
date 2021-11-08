using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Written by Jordan Hayen
// 11/7/2021
// This is my own work.

namespace InventoryManager
{
    public partial class EditItemForm : Form
    {
        MainForm mainForm; // A MainForm object that will refer to the application's main window

        public string ItemName { get; private set; } // A string property that will contain the ItemName entered by the user
        public int Stock { get; private set; } // An integer property that will contain the Stock entered by the user
        public double Price { get; private set; } // A double property that will contain the Price entered by the user

        // A constructor for the EditItemForm object. This constructor takes in a string, integer and price argument to act as the default values for the textboxes when the Form opens
        public EditItemForm(string itemName, int stock, double price)
        {
            InitializeComponent();
            mainForm = (MainForm)ActiveForm; // The mainForm object is set to reference the application's main window
            // The textboxes are populated with the parameters of the constructor
            ItemNameEditorTextBox.Text = itemName;
            ItemStockEditorTextBox.Text = stock.ToString();
            ItemPriceEditorTextBox.Text = price.ToString();
        }

        // This code runs when the EditItem button is clicked. It processes data from the textboxes into a string, integer, and double, sets the properties of the object to the result, calls the EditInventoryItem method of the main window, and closes the form
        private void EditItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Information from the textboxes is processed into a string, integer, and double and the corresponding properties are set to the results
                ItemName = ItemNameEditorTextBox.Text;
                Stock = int.Parse(ItemStockEditorTextBox.Text);
                Price = double.Parse(ItemPriceEditorTextBox.Text);

                mainForm.EditInventoryItem(); // The EditInventoryItem method of the main window is called
                this.Close(); // The form is closed
            }
            catch (Exception ex) // If any exceptions occur when processing the information from the textboxes, an error message is shown
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method runs when the Cancel button is clicked. It closes the form
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
