using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Written by Jordan Hayen
// 10/31/2021
// This is my own work.

namespace InventoryManager
{
    class InventoryManager
    {
        public List<InventoryItem> Items { get; private set; } // A List property that will contain the InventoryItem objects for this object

        // A constructor for InventoryManager class
        public InventoryManager()
        {
            Items = new List<InventoryItem>(); // The Items property is initialized as a new List of InventoryItem objects
        }

        // This method allows an InventoryItem to be added to the InventoryManager. This is accomplished by adding the new item to the Items List property
        public void AddItem(InventoryItem item)
        {
            Items.Add(item);
        }

        // This method allows an InventoryItem to be removed from the InventoryManager. This is accomplished by removing the new item from the Items List property
        public void RemoveItem(InventoryItem item)
        {
            Items.Remove(item);
        }

        // This method allows the user to restock an InventoryItem. This is done by specifying the item and the amount to add
        public void RestockItem(InventoryItem item, int amount)
        {
            Items[Items.IndexOf(item)].AddStock(amount);
        }

        // This method generates a list of string objects that contain the data from all InventoryItems in the items List, formatted for display in the Form
        public List<string> Display()
        {
            List<string> result = new List<string>(); // A List of string objects that will eventually be returned

            for (int i = 0; i < Items.Count; i++) // This loop iterates once for every element in the Items List property
            {
                result.Add(Items[i].ItemName + "\t\t" + Items[i].Stock + "\t\t$" + Items[i].Price); // The name, stock and price of the current InventoryItem are added to a formatted string and that string is added to the result List. Made with help from Microsoft doucmentation (2021)
            }

            return result; // The result List is returned
        }

        // This method allows a search of the items in the list to be done. Items can be searched via name, stock or price. This is accomplished by entering a search term that is compared against the name, stock and price of each element in the Items List property using LINQ. If any items are found, the method returns true and the output parameters are set to a List of integers representing the indices in the Items List property where the foun objects are located, as well as a List of InventoryItem objects representing the items found themselves. Made with help from Codecademy (n.d.)
        public bool Search(string searchTerm, out List<int> indecesFound, out List<InventoryItem> itemsFound)
        {
            List<int> indeces = new List<int>(); // A List of integers that will eventually be set as the indecesFound output paameter
            List<InventoryItem> items = new List<InventoryItem>(); // A List of InventoryItem objects that will eventually be set as the itemsFound output parameter

            if (searchTerm == "") // If the searchTerm is an empty string, then a value of false is returned and the output parameters are set to empty lists
            {
                indecesFound = new List<int>();
                itemsFound = new List<InventoryItem>();
                return false;
            }

            // LINQ is used to search the Items List property. The name of each InventoryItem is compared to the searchTerm parameter using the Contains method. All strings are set to lower case to ensure case independency. The result is an object that contains all found objects. Made with help from Codecademy (n.d.)
            var itemNameQuery = from item in this.Items
                                where item.ItemName.ToLower().Contains(searchTerm.ToLower())
                                select item;
            // LINQ is used to search the Items List property. The name of each InventoryItem is compared to the searchTerm parameter using the Contains method. All strings are set to lower case to ensure case independency. The result is an object that contains the indeces of all found objects. Made with help from Codecademy (n.d.)
            var itemNameIndexQuery = from item in this.Items
                                     where item.ItemName.ToLower().Contains(searchTerm.ToLower())
                                     select Items.IndexOf(item);
            items.AddRange(itemNameQuery); // All found objects are added to the items List
            indeces.AddRange(itemNameIndexQuery); // All found indeces are added to the indeces List

            try
            {
                // LINQ is used to search the Items List property. The Stock property of each InventoryItem is compared to the searchTerm parameter by using the ToString method and the Contains method. The result is an object that contains all found objects. Made with help from Codecademy (n.d.)
                var itemStockQuery = from item in this.Items
                                     where item.Stock.ToString().Contains(searchTerm)
                                     select item;
                // LINQ is used to search the Items List property. The Stock property of each InventoryItem is compared to the searchTerm parameter by using the ToString method and the Contains method. The result is an object that contains the indeces of all found objects. Made with help from Codecademy (n.d.)
                var itemStockIndexQuery = from item in this.Items
                                          where item.Stock.ToString().Contains(searchTerm)
                                          select Items.IndexOf(item);
                for (int i = 0; i < itemStockQuery.Count(); i++) // This loop iterates once for every InventoryItem object in the itemStockQuery object
                {
                    if (!items.Contains(itemStockQuery.ElementAt(i))) // If the current InventoryItem is not already present in the items List, it is added to the List. This ensures no duplicate entries
                    {
                        items.Add(itemStockQuery.ElementAt(i));
                    }
                }
                for (int i = 0; i < itemStockIndexQuery.Count(); i++) // This loop iterates once for every integer in the itemStockIndexQuery object
                {
                    if (!indeces.Contains(itemStockIndexQuery.ElementAt(i))) // If the current integer is not already present in the indeces List, it is added to the List. This ensures no duplicate entries
                    {
                        indeces.Add(itemStockIndexQuery.ElementAt(i));
                    }
                }

                // LINQ is used to search the Items List property. The Price property of each InventoryItem is compared to the searchTerm parameter by using the ToString method and the Contains method. The result is an object that contains all found objects. Made with help from Codecademy (n.d.)
                var itemPriceQuery = from item in this.Items
                                     where item.Price.ToString().Contains(searchTerm)
                                     select item;
                // LINQ is used to search the Items List property. The Price property of each InventoryItem is compared to the searchTerm parameter by using the ToString method and the Contains method. The result is an object that contains the indeces of all found objects. Made with help from Codecademy (n.d.)
                var itemPriceIndexQuery = from item in this.Items
                                          where item.Price.ToString().Contains(searchTerm)
                                          select Items.IndexOf(item);
                for (int i = 0; i < itemPriceQuery.Count(); i++) // This loop iterates once for every InventoryItem object in the itemPriceQuery object
                {
                    if (!items.Contains(itemPriceQuery.ElementAt(i))) // If the current InventoryItem is not already present in the items List, it is added to the List. This ensures no duplicate entries
                    {
                        items.Add(itemPriceQuery.ElementAt(i));
                    }
                }
                for (int i = 0; i < itemPriceIndexQuery.Count(); i++) // This loop iterates once for every integer in the itemPriceIndexQuery object
                {
                    if (!indeces.Contains(itemPriceIndexQuery.ElementAt(i))) // If the current integer is not already present in the indeces List, it is added to the List. This ensures no duplicate entries
                    {
                        indeces.Add(itemPriceIndexQuery.ElementAt(i));
                    }
                }
            }
            catch // If an exception is generated by the above code, it may be the result of no items being found by the LINQ statements. In light of this, no exception messages are necessary
            {
                ;
            }

            if (items.Count > 0) // If the items List contains any entries at all then the search was a success. a value of true is returned and the output parameters are set to the corresponding List objects
            {
                indecesFound = indeces;
                itemsFound = items;
                return true;
            }
            else // If the items List does not contain any entries then the search was not a success. A value of false is returned and the output parameters are set to empty List objects
            {
                indecesFound = new List<int>();
                itemsFound = new List<InventoryItem>();
                return false;
            }


        }

    }
}

// References:
// Microsoft. (2021, September 15). Character Escapes in Regular Expressions. https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-escapes-in-regular-expressions
// Codecademy. (n.d.). Learn C#: Lists and LINQ. https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-lists-and-linq/cheatsheet
