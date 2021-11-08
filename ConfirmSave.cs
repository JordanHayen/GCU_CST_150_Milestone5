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
    public partial class ConfirmSave : Form
    {
        MainForm mainForm; // A MainForm object that will refer to the application's main window

        // This is a constructor for the ConfirmSave class
        public ConfirmSave()
        {
            InitializeComponent();
            mainForm = (MainForm)ActiveForm; // The mainForm object is set to reference the application's main window
        }

        // This code runs when the Confirm button is clicked. It calls the SaveInventory method of the main window and closes the form
        private void Confirm_Click(object sender, EventArgs e)
        {
            mainForm.SaveInventory(); // The SaveInventory method of the main window is called
            this.Close(); // The form is closed
        }

        // This code runs when the Cancel button is clicked. It closes the form
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
