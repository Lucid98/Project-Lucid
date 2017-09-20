using Project_Lucid.Classes.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Inventory class, cannot be inherited
    /// </summary>
    internal sealed class Inventory
    {
        private Item[] inventory;

        /// <summary>
        /// Inventory object
        /// </summary>
        /// <param name="Size">Size of the inventory</param>
        internal Inventory(int Size)
        {
            if(Size > 0)
            {
                inventory = new Item[Size];
                Item EmptyItem = new Item(Load.ItemData("0000"));
                for(int Index = 0; Index < inventory.Length; Index++)
                {
                    inventory[Index] = EmptyItem;
                }
            }
            else
            {
                throw new Exception("Size cannot be less than 1:" + Size);
            }
        }

        /// <summary>
        /// Returns true and add Item object to Inventory if not full or returns false
        /// and not add Item object to Inventory if full
        /// </summary>
        /// <param name="Item">Item object</param>
        internal bool Add(Item Item)
        {
            for(int Index = 0; Index < inventory.Length; Index++)
            {
                if(!SlotIsEmpty(Index + 1))
                {
                    inventory[Index] = Item;
                    return true;
                }
            } return false;
        }

        /// <summary>
        /// Discards Item object from Inventory at specified Slot
        /// </summary>
        /// <param name="Slot">Slot number</param>
        internal void Discard(int Slot)
        {
            ValidateSlot(Slot);
            inventory[Slot - 1] = new Item(Load.ItemData("0000"));
        }

        /// <summary>
        /// Returns the Item object at the specified slot
        /// </summary>
        /// <param name="Slot">Slot number</param>
        internal Item Use(int Slot)
        {
            ValidateSlot(Slot);
            return inventory[Slot - 1];
        }

        /// <summary>
        /// Returns the size of the Inventory
        /// </summary>
        internal int Size
        {
            get { return inventory.Length; }
        }

        /// <summary>
        /// Returns true if Inventory slot is empty and false if not
        /// </summary>
        /// <param name="Slot">Slot number</param>
        /// <returns></returns>
        private bool SlotIsEmpty(int Slot)
        {
            if (inventory[Slot - 1] == new Item(Load.ItemData("0000")))
            {
                return true;
            } else return false;
        }

        /// <summary>
        /// Validates Slot number
        /// </summary>
        /// <param name="Slot">Slot number</param>
        private void ValidateSlot(int Slot)
        {
            if(Slot < 1 || Slot > inventory.Length)
            {
                throw new Exception("Invalid Slot number: " + Slot);
            }
        }
    }
}
