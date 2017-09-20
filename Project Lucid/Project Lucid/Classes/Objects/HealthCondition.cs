using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// HealthCondition class, cannot be inherited
    /// </summary>
    internal sealed class HealthCondition
    {
        private String data;

        /// <summary>
        /// Creates a HealthCondition object, which passes in specific data
        /// string created in HealthCondition.txt file
        /// </summary>
        /// <param name="Data">String data obtained using Load.HealthConditionData(HealthConditionID) method</param>
        internal HealthCondition(String Data)
        {
            data = Data;
        }

        /// <summary>
        /// Gets the Data of HealthCondition object
        /// </summary>
        internal String Data
        {
            get { return data.Substring(6); }
        }
    }
}
