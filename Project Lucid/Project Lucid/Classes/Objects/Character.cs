using Project_Lucid.Classes.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Character class, cannot be inherited
    /// </summary>
    internal sealed class Character
    {
        private String data;
        private Stat baseStat;
        private HealthCondition condition;

        /// <summary>
        /// Creates a Character object, which passes in specific data
        /// string created in Character.txt file
        /// </summary>
        /// <param name="Data">String data obtained using Load.CharacterData(CharacterID) method</param>
        /// <param name="Condition">HealthCondition object</param>
        internal Character(String Data, HealthCondition Condition)
        {
            data = Data;
            condition = Condition;
        }

        /// <summary>
        /// Gets the Charcter ID of Character object
        /// </summary>
        internal String ID
        {
            get { return data.Substring(0, 5); }
        }

        /// <summary>
        /// Gets the ClassType of Character object
        /// </summary>
        internal String ClassType
        {
            get
            {
                String ClassID = data.Substring(6, 5);
                return Load.ClassData(ClassID);
            }
        }

        /// <summary>
        /// Gets the BaseStat of Character object
        /// </summary>
        internal Stat BaseStat
        {
            get
            {
                int CON = int.Parse(data.Substring(15, 4));
                int STR = int.Parse(data.Substring(23, 4));
                int DEX = int.Parse(data.Substring(31, 4));
                int LUK = int.Parse(data.Substring(39, 4));
                int INT = int.Parse(data.Substring(47, 4));
                int WIS = int.Parse(data.Substring(55, 4));
                int AGL = int.Parse(data.Substring(63, 4));
                baseStat = new Stat(CON, STR, DEX, LUK, INT, WIS, AGL);
                return baseStat;
            }
        }

        /// <summary>
        /// Gets the BaseHealth stat of Character object
        /// </summary>
        internal int BaseHealth
        {
            get { return 100 + (baseStat.CON * 2); }
        }

        /// <summary>
        /// Gets the BaseMinAtk stat of Character object
        /// </summary>
        internal int BaseMinAtk
        {
            get { return (int)((baseStat.STR * 0.2) + (baseStat.DEX * 0.5)); }
        }

        /// <summary>
        /// Gets the BaseMaxAtk stat of Character object
        /// </summary>
        internal int BaseMaxAtk
        {
            get { return (int)(baseStat.STR * 1.5); }
        }

        /// <summary>
        /// Gets the BaseMagicAtk stat of Character object
        /// </summary>
        internal int BaseMagicAtk
        {
            get { return (int)(baseStat.INT * 8.5); }
        }

        /// <summary>
        /// Gets the BaseAccuracy stat of Character object
        /// </summary>
        internal int BaseAccuracy
        {
            get { return (int)(baseStat.DEX * 0.05); }
        }

        /// <summary>
        /// Gets the BaseEvasion stat of Character object
        /// </summary>
        internal int BaseEvasion
        {
            get { return (int)(baseStat.AGL * 0.3); }
        }

        /// <summary>
        /// Gets the BaseStamina stat of Character object
        /// </summary>
        internal int BaseStamina
        {
            get { return (int)(100 + (baseStat.WIS * 0.5)); }
        }

        /// <summary>
        /// Gets the BaseCriticalChance stat of Character object
        /// </summary>
        internal int BaseCriticalChance
        {
            get { return (int)(1 + (baseStat.LUK * 0.15)); }
        }

        /// <summary>
        /// Gets the BaseCriticalDamageMultiplier stat of Character object
        /// </summary>
        internal int BaseCriticalDamageMultiplier
        {
            get { return (int)((baseStat.LUK * 0.02) + (baseStat.STR * 0.005) + (baseStat.DEX * 0.001)); }
        }

        /// <summary>
        /// Gets the Name of Character object
        /// </summary>
        internal String Name
        {
            get { return data.Substring(68); }
        }

        /// <summary>
        /// Gets the HealthCondition of Character object
        /// </summary>
        internal HealthCondition Condition
        {
            get { return condition; }
        }
    }
}
