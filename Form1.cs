using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Written by Jordan Hayen
// 11/7/2021
// This is my own work.

namespace InventoryManager
{
    public partial class MainForm : Form
    {
        InventoryManager manager; // An InventoryManager object
        const string LISTBOXHEADER = "Item\t\tStock\t\tPrice"; // A string constant that will contain the header for the InventoryDisplay ListBox. Made with help from Microsoft documentation (2021)
        AddItemForm addItemForm; // An AddItemForm object. The AddItemForm is an additional Form used to collect information from the user when adding a new item to the inventory
        EditItemForm editItemForm; // An EditItemForm object. The EditItemForm is an additional Form used to collect information from the user when editting item in the inventory
        ConfirmSave confirmSave; // A ConfirmSave Form. The ConfirmSave Form is an additional Form used to prompt the user to confirm whether or not they wish to save the inventory

        public MainForm()
        {
            InitializeComponent();
        }

        // This code runs when the form is loaded. It sets the manager field to a new InventoryManager object
        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new InventoryManager();
        }

        // This code runs when the AddItem button is clicked. It opens an AddItemForm that allows the user to input data for a new InventoryItem object
        private void AddItem_Click(object sender, EventArgs e)
        {

            addItemForm = new AddItemForm(); // The addItemForm field is set to a new AddItemForm. Made with help from Microsoft documentation (n.d.)
            addItemForm.Visible = true; // The new AddItemForm is set to be visible
        }

        //  This code runs when an item is selected in the InventoryDisplay ListBox. If the selected item is not the heder, then the button for removing an item is displayed, along with the button and TextBoxes used to edit an item
        private void InventoryDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InventoryDisplay.SelectedIndex > 0) // If an item is selected that is not the header, then the button for removing an item is displayed, along with the button and TextBoxes used to edit an item
            {
                RemoveSelected.Visible = true; // The button for removing a selected item is set to be visible
                EditSelected.Visible = true; // The button for editting a selected item is set to be visible
                AddStockButton.Visible = true; // The button for adding to an item's stock is set to be visible 
                AddStockTextBox.Visible = true; // The textbox for adding to an item's stock is set to be visible
            }
            else
            {
                RemoveSelected.Visible = false; // The button for removing a selected item is set to be invisible
                EditSelected.Visible = false; // The button for editting a selected item is set to be invisible
                AddStockButton.Visible = false; // The button for adding to an item's stock is set to be invisible
                AddStockTextBox.Visible = false; // The textbox for adding to an item's stock is set to be invisible
            }
        }

        // This code runs when the RemoveSelected button is clicked. It removes the selected item from the manager object and updates the InventoryDisplay listbox
        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = InventoryDisplay.SelectedIndex; // An integer variable that stores the selected index of the InventoryDisplay object at the start of the method
            manager.RemoveItem(manager.Items[InventoryDisplay.SelectedIndex - 1]); // The item selected is removed from the manager object
            InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared
            InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
            InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
            InventoryDisplay.SelectedIndex = selectedIndex - 1; // The selected index of the InventoryDisplay listbox is set to the selectedIndex variable minus one
            if (selectedIndex - 1 == 0) // If the selectedIndex variable minus one equals zero, then the item in the InventoryDisplay listbox is deselected
            {
                InventoryDisplay.SelectedIndex = -1;
            }
        }

        // This code runs when the EditSelected button is clicked. It opens an EditItemForm that allows the user to input data to edit an exisiting InventoryItem object
        private void EditSelected_Click(object sender, EventArgs e)
        {
            try
            {
                editItemForm = new EditItemForm(manager.Items[InventoryDisplay.SelectedIndex - 1].ItemName, manager.Items[InventoryDisplay.SelectedIndex - 1].Stock, manager.Items[InventoryDisplay.SelectedIndex - 1].Price); // The editItemForm object is set to a new EditItemForm with information from the selected item in the display as a parameter. Made with help from Microsoft documentation (n.d.)
                editItemForm.Visible = true; // The new EditItemForm is set to be visible
            }
            catch (Exception ex) // If any errors occur when parsing data from the textboxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }

        }

        // This code runs when the AddStockButton is clicked. It adds the data entered in the textbox to the selected InventoryItem's stock
        private void AddStockButton_Click(object sender, EventArgs e)
        {
            try
            {
                manager.RestockItem(manager.Items[InventoryDisplay.SelectedIndex - 1], int.Parse(AddStockTextBox.Text)); // The manager object's RestockItem method is called with the selected InventoryItem and the data from the textbox as parameters
                InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared
                InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
                AddStockTextBox.Text = ""; // Clears the text of the AddStockTextBox
            }
            catch (Exception ex) // If any errors occur when parsing data from the textboxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the text of the SearchBar textbox is changed. The manager object's Search method is called with the data entered in the textbox as a parameter and the results are displayed in the SearchResult listbox
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            List<int> indeces = new List<int>(); // A List of integers that will contain the output of the Search method
            List<InventoryItem> items = new List<InventoryItem>(); // A List of InventoryItem objects that will contain the output of the Search method

            SearchResults.Items.Clear(); // The SearchResults listbox is cleared

            manager.Search(SearchBar.Text, out indeces, out items); // The manager object's Search method is called with the text of the SearchBar textbox, the indeces List, and the items List as parameters
            SearchResults.Items.AddRange((from item in items select item.ItemName).ToArray<string>()); // LINQ is used to add the names of the found items to the SearchResults listbox. Made with help from Codecademy (n.d.)
        }

        // This code runs when an item is selected in the SearchResults listbox. It selects the corresponding item in the InventoryDisplay listbox
        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < manager.Items.Count; i++) // This loop iterates for every item in the manager object
            {
                if (manager.Items[i].ItemName == (string)SearchResults.SelectedItem) // If the current ItemName property of the current item is equal to the SelectItem of the SearchResults listbox, the SelectedIndex of the InventoryDisplay listbox is set to the index of the item in the manager object plus one
                {
                    InventoryDisplay.SelectedIndex = manager.Items.IndexOf(manager.Items[i]) + 1;
                }
            }

        }

        // This method generates a text file that contains the data for all items in the inventory manager
        public void SaveInventory()
        {
            
            StreamWriter streamWriter; // A StreamWriter object that will allow data to be written to a text file

            try
            {
                streamWriter = File.CreateText("savedata.txt"); // The StreamWriter is set to a new text file called savedata.txt
                for (int i = 0; i < manager.Items.Count; i++) // This loop runs for every item in the manager object's Items List
                {
                    streamWriter.WriteLine(manager.Items[i].ItemName + " " + manager.Items[i].Stock.ToString() + " " + manager.Items[i].Price.ToString()); // A formatted string containing the current item's name, stock, and price is written to the savedata.txt file
                }
                streamWriter.Close(); // The text file is closed
                MessageBox.Show("Save successful"); // A message is shown stating that the save was successful
            }
            catch (Exception ex) // If the process of opening or editting the file causes an exception, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        // This method reads a text file for inventory item information adds that information to the inventory display
        public void LoadSavedInventory()
        {
            StreamReader streamReader; // A StreamReader object that will be used to read data from the file savedata.txt

            try
            {
                streamReader = File.OpenText("savedata.txt"); // The StreamReader is set to read the contents of savedata.txt

                while(!streamReader.EndOfStream) // This loop runs for every line of savedata.txt. Each line is added to the manager object using the ProcessItemFromFile method
                {
                    manager.AddItem(ProcessItemFromFile(streamReader.ReadLine()));
                }

                streamReader.Close(); // The text file is closed
                InventoryDisplay.Items.Clear(); // Clears the InventoryDisplay ListBox
                InventoryDisplay.Items.Add(LISTBOXHEADER); // Adds the LISTBOXHEADER string to the InventoryDisplay ListBox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
                MessageBox.Show("Load successful"); // A message is shown stating that the Load was successful


            }
            catch(Exception ex) // If the process of opening or reading the file causes an exception, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This method takes information from a line of the savedate.txt file and returns an InventoryItem object that contains that information
        private InventoryItem ProcessItemFromFile(string fileLine)
        {
            string[] itemInformation; // An array of string objects that will contain the information needed to instantiate an InventoryItem object as taken from the parameter
            InventoryItem result; // An InventoryItem object that will eventually be returned

            itemInformation = new string[3]; // The itemInformation array is initialized with a length of three
            for(int i = 0, j = 0; i < fileLine.Length; i++) // This loop will run for every character in the parameter. If the current character is not a spcae, it is added to the current index of the itemInformation array. If the current character is a space, the iterator variable used to keep track of the current index of the itemInformation array is increased by one
            {
                if (fileLine[i] != ' ') // If the current character is not a space, it is added to the current index of the itemInformation array
                {
                    itemInformation[j] += fileLine[i];
                }
                else // If the current character is a space, the iterator variable used to keep track of the current index of the itemInformation array is increased by one
                {
                    j++;
                }
            }

            result = new InventoryItem(itemInformation[0], int.Parse(itemInformation[1]), double.Parse(itemInformation[2])); // The result object is instantiated using information from the itemInformation array
            return result; // The result object is returned
        }

        // This code runs when the RemoveAllItem button is clicked. It removes all InventoryItems from the manager object
        private void RemoveAllItem_Click(object sender, EventArgs e)
        {
            while(manager.Items.Count > 0) // This loop runs until there are no items left in the manager object. It removes the first item in the manager's Items List
            {
                manager.RemoveItem(manager.Items[0]);
            }
            InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared
            InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
            InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
        }

        // This method takes information from the addItemForm field and uses that information to add a new InventoryItem to the manager object. This method is public so that it can be called from the AddItemForm class
        public void AddItemToInventory()
        {
            try
            {
                manager.AddItem(new InventoryItem(addItemForm.ItemName, addItemForm.Stock, addItemForm.Price)); // Processes data from the TextBoxes for the new item's name, price and stock and uses that information to create a new InventoryItem, then add that InventoryItem to the manager object
                InventoryDisplay.Items.Clear(); // Clears the InventoryDisplay ListBox
                InventoryDisplay.Items.Add(LISTBOXHEADER); // Adds the LISTBOXHEADER string to the InventoryDisplay ListBox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
            }
            catch (Exception ex) // If any errors occur when parsing data from the TextBoxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }

        }

        // This method takes information from the editItemForm field and uses that information to edit an InventoryItem in the manager object. This method is public so that it can be called from the EditItemForm class
        public void EditInventoryItem()
        {
            manager.Items[InventoryDisplay.SelectedIndex - 1].ItemName = editItemForm.ItemName; // The name of the selected InventoryItem is set to the data entered in the textbox
            manager.Items[InventoryDisplay.SelectedIndex - 1].Stock = editItemForm.Stock; // The stock of the selected InventoryItem is set to the data entered in the textbox
            manager.Items[InventoryDisplay.SelectedIndex - 1].Price = editItemForm.Price;  // The price of the selected InventoryItem is set to the data entered in the textbox
            InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared
            InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
            InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox

            RemoveSelected.Visible = false; // The button for removing a selected item is set to be invisible
            EditSelected.Visible = false; // The button for editting a selected item is set to be invisible
            AddStockButton.Visible = false; // The button for adding to an item's stock is set to be invisible
            AddStockTextBox.Visible = false; // The textbox for adding to an item's stock is set to be invisible
        }

        // This code runs when the Save button is clicked. It opens a ConfirmSave Form that allows a user to save the current inventory
        private void Save_Click(object sender, EventArgs e)
        {
            confirmSave = new ConfirmSave(); // The confirmSave field is set to a new ConfirmSave Form. Made with help from Microsoft documentation (n.d.)
            confirmSave.Visible = true; // The ConfirmSave form is set to be visible
        }

        // This code runs when the LoadInventory method is clicked. It calls the LoadSavedInventory method
        private void LoadInventory_Click(object sender, EventArgs e)
        {
            LoadSavedInventory();
        }
    }

}

// References:
// Codecademy. (n.d.). Learn C#: Lists and LINQ. https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-lists-and-linq/cheatsheet
// Microsoft. (n.d.). Form.Load Event. https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.load?view=windowsdesktop-5.0
// Microsoft. (2021, September 15). Character Escapes in Regular Expressions. https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-escapes-in-regular-expressions