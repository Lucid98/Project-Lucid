using Project_Lucid.Classes.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// StorageChest class, cannot be inherited
    /// </summary>
    internal sealed class StorageChest
    {
        private Item[] storageChest;

        internal StorageChest(int Size)
        {
            if(Size > 0)
            {
                storageChest = new Item[Size];
                Item EmptyItem = new Item(Load.ItemData("0000"));
                for (int Index = 0; Index < storageChest.Length; Index++)
                {
                    storageChest[Index] = EmptyItem;
                }
            }
            else
            {
                throw new Exception("Size cannot be less than 1:" + Size);
            }
        }

        /// <summary>
        /// Returns true and add Item object to StorageChest if not full or returns false
        /// and not add Item object to StorageChest if full
        /// </summary>
        /// <param name="Item">Item object</param>
        internal bool Deposit(Item Item)
        {
            for(int Index = 0; Index < storageChest.Length; Index++)
            {
                if(!SlotIsEmpty(Index + 1))
                {
                    storageChest[Index] = Item;
                    return true;
                }
            } return false;
        }

        /// <summary>
        /// Returns true and withdraws Item object to Inventory if not full or return false
        /// and not withdraw Item object to Inventory if there is no live Item object
        /// </summary>
        /// <param name="Slot">Slot number</param>
        /// <param name="Inventory">Inventory object that the Item object will be withdrawn to</param>
        internal bool Withdraw(int Slot, Inventory Inventory)
        {
            ValidateSlot(Slot);
            if(storageChest[Slot - 1] != new Item(Load.ItemData("0000")))
            {
                Inventory.Add(storageChest[Slot - 1] = new Item(Load.ItemData("0000")));
                storageChest[Slot - 1] = new Item(Load.ItemData("0000"));
                return true;
            }
            else
            {
                return false;
            }
        }

        internal int Size
        {
            get { return storageChest.Length; }
        }

        /// <summary>
        /// Returns true if StorageChest slot is empty and false if not
        /// </summary>
        /// <param name="Slot">Slot number</param>
        /// <returns></returns>
        private bool SlotIsEmpty(int Slot)
        {
            if (storageChest[Slot - 1] == new Item(Load.ItemData("0000")))
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Validates Slot number
        /// </summary>
        /// <param name="Slot">Slot number</param>
        private void ValidateSlot(int Slot)
        {
            if (Slot < 1 || Slot > storageChest.Length)
            {
                throw new Exception("Invalid Slot number: " + Slot);
            }
        }
    }
}
