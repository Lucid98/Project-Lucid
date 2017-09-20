using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Stat class, cannot be inherited
    /// </summary>
    internal sealed class Stat
    {
        private int con, str, dex, luk, intl, wis, agl;

        /// <summary>
        /// Creates a Stat object that holds stat information
        /// </summary>
        internal Stat(int CON, int STR, int DEX, int LUK, int INT, int WIS, int AGL)
        {
            con = CON;
            str = STR;
            dex = DEX;
            luk = LUK;
            intl = INT;
            wis = WIS;
            agl = AGL;
        }

        /// <summary>
        /// Gets the CON value of the Stat object
        /// </summary>
        internal int CON
        {
            get { return con; }
        }

        /// <summary>
        /// Gets the STR value of the Stat object
        /// </summary>
        internal int STR
        {
            get { return str; }
        }

        /// <summary>
        /// Gets the DEX value of the Stat object
        /// </summary>
        internal int DEX
        {
            get { return dex; }
        }

        /// <summary>
        /// Gets the LUK value of the Stat object
        /// </summary>
        internal int LUK
        {
            get { return luk; }
        }

        /// <summary>
        /// Gets the INT value of the Stat object
        /// </summary>
        internal int INT
        {
            get { return intl; }
        }

        /// <summary>
        /// Gets the WIS value of the Stat object
        /// </summary>
        internal int WIS
        {
            get { return wis; }
        }

        /// <summary>
        /// Gets the AGL value of the Stat object
        /// </summary>
        internal int AGL
        {
            get { return agl; }
        }
    }
}
