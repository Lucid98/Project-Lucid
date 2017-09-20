using Project_Lucid.Classes.Loader;
using Project_Lucid.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Constant
{
    /// <summary>
    /// HealthCondition static class, cannot be inherited
    /// </summary>
    internal static class HealthConditionConstant
    {
        /// <summary>
        /// HealthCondition value of 'Healthy'
        /// </summary>
        internal static HealthCondition Healthy
        {
            get { return new HealthCondition(Load.HealthConditionData("00001")); }
        }

        /// <summary>
        /// HealthCondition value of 'Wounded'
        /// </summary>
        internal static HealthCondition Wounded
        {
            get { return new HealthCondition(Load.HealthConditionData("00002")); }
        }

        /// <summary>
        /// HealthCondition value of 'Bleeding'
        /// </summary>
        internal static HealthCondition Bleeding
        {
            get { return new HealthCondition(Load.HealthConditionData("00003")); }
        }

        /// <summary>
        /// HealthCondition value of 'Poisoned'
        /// </summary>
        internal static HealthCondition Poisoned
        {
            get { return new HealthCondition(Load.HealthConditionData("00004")); }
        }

        /// <summary>
        /// HealthCondition value of 'Infected'
        /// </summary>
        internal static HealthCondition Infected
        {
            get { return new HealthCondition(Load.HealthConditionData("00005")); }
        }
    }
}
