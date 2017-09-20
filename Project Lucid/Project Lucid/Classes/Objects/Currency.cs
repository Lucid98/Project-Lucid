using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Currency class, cannot be inherited
    /// </summary>
    internal sealed class Currency
    {
        private int metraCredit = 0;
        private int tradeBar = 0;
        private int rareGem = 0;

        /// <summary>
        /// Creates a Currency object that contains information
        /// on multiple types of currency
        /// </summary>
        internal Currency()
        {
            //
        }

        /// <summary>
        /// Gets and sets MetraCredit value (Max value: 2000000000)
        /// </summary>
        internal int MetraCredit
        {
            get { return metraCredit; }
            set
            {
                if(value <= 2000000000)
                {
                    metraCredit = value;
                }
                else
                {
                    metraCredit = 2000000000;
                }
            }
        }

        /// <summary>
        /// Gets and sets TradeBar value (Max value: 1000)
        /// </summary>
        internal int TradeBar
        {
            get { return tradeBar; }
            set
            {
                if(value <= 1000)
                {
                    tradeBar = value;
                }
                else
                {
                    tradeBar = 1000;
                }
            }
        }

        /// <summary>
        /// Gets and sets RareGem value (Max value: 100)
        /// </summary>
        internal int RareGem
        {
            get { return rareGem; }
            set
            {
                if(value <= 100)
                {
                    rareGem = value;
                }
                else
                {
                    rareGem = 100;
                }
            }
        }
    }
}
