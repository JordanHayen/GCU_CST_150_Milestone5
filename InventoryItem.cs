using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Jordan Hayen
// 10/17/2021
// This is my own work.

namespace InventoryManager
{
    // A definition for the InventoryItem class
    class InventoryItem
    {

        // Defines the properties for the fields of the InventoryItem class. Made with help from Codecademy (n.d.)
        public string ItemName { get; set; } // Defines a string property called ItemName that can be accessed and modified outside of the class
        public int Stock { get; set; } // Defines an integer property called Stock that can be accessed outside of the class but that can only be directly modified within the class
        public double Price { get; set; } // Defines a double property called Price that can be accessed and modified outside of the class
        public bool HasBeenRemoved { get; private set; } // Defines a boolean property called HasBeenRemoved that can be accessed outside of the class but that can only be directly modified within the class
        public static int TotalStock { get; private set; } // Defines a static integer property called TotalStock that can be accessed outside of the class but that can only be directly modified within the class
        public static int TotalItems { get; private set; } // Defines a static integer property called TotalItems that can be accessed outside of the class but that can only be directly modified within the class

        // This is a constructor for the InventoryItem class. It takes in three paramaters: a string that will be set to the ItemNAme property, an integer, that will be set to the Stock property, and a double, that will be set to the Price property. It also sets the HasBeenRemoved variable to false, adds the stock parameter to the static TotalStock property, and increments the TotalItems property
        public InventoryItem(string itemName, int stock, double price)
        {
            this.ItemName = itemName; // Sets the ItemName property to the itemName parameter
            this.Stock = stock; // Sets the Stock property to the stock parameter
            this.Price = price; // Sets the Price property to the price parameter
            this.HasBeenRemoved = false; // Sets the HasBeenRemoved property to false

            TotalStock += stock; // Adds the stock parameter to the TotalStock property
            TotalItems++; // Increases the TotalItems property by 1
        }

        // This method removes the InventoryItem. Doing this sets the HasBeenRemoved property to true, subtracts 1 from the TotalItems property, and subtracts the stock of the item from the TotalStock property.
        public void Remove()
        {
            this.HasBeenRemoved = true; // Sets the HasBeenRemovedProperty to true
            TotalItems--; // Subtracts 1 from the TotalItems property
            TotalStock -= this.Stock; // Subtracts this item's stock from the TotalStock property
        }

        // This method allows the Stock property to be modified by an external program. This is accomplished by inputting an amount to add to the Stock. This amount is added to the Stock property as well as the static TotalStock property. The reason that I have decided to allow the Stock property to be modified in this way as opposed to defining a modifier method within the property is to make it easier to modify the TotalStock property. This method can only be used if HasBeenRemoved is equal to false, that is, the method cannot be used once the item has been removed.
        public void AddStock(int amount)
        {
            if (!this.HasBeenRemoved)
            {
                this.Stock += amount; // Adds the parameter to the Stock property
                TotalStock += amount; // Adds the parameter to the TotalStock property
            }
        }

        // This method allows the Stock property to be modified by an external program. This is accomplished by inputting an amount to subtract from the Stock. This amount is suubtracted from the Stock property as well as the static TotalStock property. The reason that I have decided to allow the Stock property to be modified in this way as opposed to defining a modifier method within the property is to make it easier to modify the TotalStock property. This method can only be used if HasBeenRemoved is equal to false, that is, the method cannot be used once the item has been removed.
        public void SubtractStock(int amount)
        {
            if (!this.HasBeenRemoved)
            {
                this.Stock -= amount; // Adds the parameter to the Stock property
                TotalStock -= amount; // Adds the parameter to the TotalStock property
            }
        }
    }
}

// References:
// Codecademy. (n.d.). Learn C#: Classes and Objects. https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-classes/cheatsheet
