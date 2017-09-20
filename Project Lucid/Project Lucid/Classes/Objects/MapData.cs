using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// MapData class, cannot be inherited
    /// </summary>
    internal sealed class MapData
    {
        private String name;
        private int xdim, ydim;
        private int[,] map;

        /// <summary>
        /// Creates a MapData object that contains raw data of the map
        /// </summary>
        /// <param name="FilePath">FilePath to the text file of the map data</param>
        internal MapData(String FilePath)
        {
            using(StreamReader Reader = new StreamReader(""))
            {
                String CurrentLine = Reader.ReadLine();

                // Extracts and store name
                name = ExtractName(CurrentLine);

                CurrentLine = Reader.ReadLine();
                xdim = int.Parse(CurrentLine.Substring(19, 2));
                CurrentLine = Reader.ReadLine();
                ydim = int.Parse(CurrentLine.Substring(23, 2));

                for(int Index = 0; Index < ydim; Index++)
                {
                    //
                }

                while ((CurrentLine = Reader.ReadLine()) != null)
                {
                    //
                }
            }
        }

        /// <summary>
        /// Gets the Name of MapData object
        /// </summary>
        internal String Name
        {
            get { return name; }
        }

        /// <summary>
        /// Gets the Xdim of MapData object
        /// </summary>
        internal int Xdim
        {
            get { return xdim; }
        }

        /// <summary>
        /// Gets the Ydim of MapData object
        /// </summary>
        internal int Ydim
        {
            get { return ydim; }
        }

        /// <summary>
        /// Extracts the Name from the Data string
        /// </summary>
        /// <param name="Data">First line in the map data file</param>
        private String ExtractName(String Data)
        {
            String Name = "";
            for (int Index = 0; Index < Data.Length; Index++)
            {
                if(Data.Substring(Index, 1) != "_")
                {
                    Name = Data.Substring(Index, 1);
                }
                else
                {
                    break;
                }
            } return Name;
        }
    }
}
