using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Item class
    /// </summary>
    internal class Item
    {
        private String data;

        /// <summary>
        /// Creates an Item object
        /// </summary>
        /// <param name="Data">Specific data string created in Item.txt file</param>
        internal Item(String Data)
        {
            data = Data;
        }

        /// <summary>
        /// Gets the Item ID of Item object
        /// </summary>
        internal String ID
        {
            get { return data.Substring(0, 5); }
        }

        /// <summary>
        /// Gets the Type ID of Item object
        /// </summary>
        internal String TypeID
        {
            get { return data.Substring(7, 2); }
        }

        /// <summary>
        /// Gets the raw Access value of Item object
        /// </summary>
        internal String Access
        {
            get { return data.Substring(10, 15); }
        }

        /// <summary>
        /// Gets the raw Modifier value of Item object
        /// </summary>
        internal String Modifier
        {
            get { return data.Substring(27, 50); }
        }

        /// <summary>
        /// Gets the Name of Item object
        /// </summary>
        internal String Name
        {
            get
            {
                String rawName = data.Substring(79, 30);
                String name = "";
                for(int i = 0; i < rawName.Length; i++)
                {
                    if (rawName.Substring(0, 1) != "_")
                        name = name + rawName.Substring(0, 1);
                    else break;
                } return name;
            }
        }

        /// <summary>
        /// Gets the Description of Item object
        /// </summary>
        internal String Description
        {
            get { return data.Substring(110); }
        }

        /// <summary>
        /// Gets the raw Data of Item object
        /// </summary>
        internal String Data
        {
            get { return data; }
        }
    }
}
