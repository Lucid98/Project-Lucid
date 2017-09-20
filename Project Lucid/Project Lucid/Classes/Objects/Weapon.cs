using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Lucid.Classes.Loader;

namespace Project_Lucid.Classes.Objects
{
    /// <summary>
    /// Weapon class, cannot be inherited
    /// </summary>
    internal sealed class Weapon : Item
    {
        private int basePower, bonusPower, baseAcc, bonusAcc, cap, bonusCap;
        private int baseCON, baseSTR, baseDEX, baseLUK, baseINT, baseWIS, baseAGL;
        private int bonusCON, bonusSTR, bonusDEX, bonusLUK, bonusINT, bonusWIS, bonusAGL;
        private String weaponType;

        /// <summary>
        /// Creates a Weapon object (inherited from Item object)
        /// </summary>
        /// <param name="Data">Specific data string created in Item.txt file</param>
        internal Weapon(String Data) : base(Data)
        {
            ValidateItemTypeIsWeapon(Load.ItemType(this.TypeID));
            basePower = int.Parse(this.Modifier.Substring(0, 5));
            baseAcc = int.Parse(this.Modifier.Substring(5, 3));
            baseCON = ModifyStat(this.Modifier.Substring(8, 4));
            baseSTR = ModifyStat(this.Modifier.Substring(12, 4));
            baseDEX = ModifyStat(this.Modifier.Substring(16, 4));
            baseLUK = ModifyStat(this.Modifier.Substring(20, 4));
            baseINT = ModifyStat(this.Modifier.Substring(24, 4));
            baseWIS = ModifyStat(this.Modifier.Substring(24, 4));
            baseAGL = ModifyStat(this.Modifier.Substring(28, 4));
            cap = int.Parse(this.Modifier.Substring(32, 4));
            weaponType = Load.WeaponType(this.Modifier.Substring(36, 3));
        }

        /// <summary>
        /// Gets the BasePower of Weapon object
        /// </summary>
        internal int BasePower
        {
            get { return basePower; }
        }

        /// <summary>
        /// Gets and sets the BonusPower of Weapon object
        /// </summary>
        internal int BonusPower
        {
            get { return bonusPower; }
            set { bonusPower = value; }
        }

        /// <summary>
        /// Gets the BaseAccuracy of Weapon object
        /// </summary>
        internal int BaseAccuracy
        {
            get { return baseAcc; }
        }

        /// <summary>
        /// Gets and sets the BonusAccuracy of Weapon object
        /// </summary>
        internal int BonusAccuracy
        {
            get { return bonusAcc; }
            set { bonusAcc = value; }
        }

        /// <summary>
        /// Gets the BaseCON of Weapon object
        /// </summary>
        internal int BaseCON
        {
            get { return baseCON; }
        }

        /// <summary>
        /// Gets and sets the BonusCON of Weapon object
        /// </summary>
        internal int BonusCON
        {
            get { return bonusCON; }
            set { bonusCON = value; }
        }

        /// <summary>
        /// Gets the BaseSTR of Weapon object
        /// </summary>
        internal int BaseSTR
        {
            get { return baseSTR; }
        }

        /// <summary>
        /// Gets and sets the BonusSTR of Weapon object
        /// </summary>
        internal int BonusSTR
        {
            get { return bonusSTR; }
            set { bonusSTR = value; }
        }

        /// <summary>
        /// Gets the BaseDEX of Weapon object
        /// </summary>
        internal int BaseDEX
        {
            get { return baseDEX; }
        }

        /// <summary>
        /// Gets and sets the BonusDEX of Weapon object
        /// </summary>
        internal int BonusDEX
        {
            get { return bonusDEX; }
            set { bonusDEX = value; }
        }

        /// <summary>
        /// Gets the BaseLUK of Weapon object
        /// </summary>
        internal int BaseLUK
        {
            get { return baseLUK; }
        }

        /// <summary>
        /// Gets and sets the BonusLUK of Weapon object
        /// </summary>
        internal int BonusLUK
        {
            get { return bonusLUK; }
            set { bonusLUK = value; }
        }

        /// <summary>
        /// Gets the BaseINT of Weapon object
        /// </summary>
        internal int BaseINT
        {
            get { return baseINT; }
        }

        /// <summary>
        /// Gets and sets the BonusINT of Weapon object
        /// </summary>
        internal int BonusINT
        {
            get { return bonusINT; }
            set { bonusINT = value; }
        }

        /// <summary>
        /// Gets the BaseWIS of Weapon object
        /// </summary>
        internal int BaseWIS
        {
            get { return baseWIS; }
        }

        /// <summary>
        /// Gets and sets the BonusWIS of Weapon object
        /// </summary>
        internal int BonusWIS
        {
            get { return bonusWIS; }
            set { bonusWIS = value; }
        }

        /// <summary>
        /// Gets the BaseAGL of Weapon object
        /// </summary>
        internal int BaseAGL
        {
            get { return baseAGL; }
        }

        /// <summary>
        /// Gets and sets the BonusAGL of Weapon object
        /// </summary>
        internal int BonusAGL
        {
            get { return bonusAGL; }
            set { bonusAGL = value; }
        }

        /// <summary>
        /// Gets the Capacity of Weapon object
        /// </summary>
        internal int Capacity
        {
            get { return cap; }
        }

        /// <summary>
        /// Gets the WeaponType of Weapon object
        /// </summary>
        internal String WeaponType
        {
            get { return weaponType; }
        }

        /// <summary>
        /// Validates if object created is of Item Type: Weapon
        /// </summary>
        /// <param name="ItemType">ItemType</param>
        private static void ValidateItemTypeIsWeapon(String ItemType)
        {
            if(ItemType != "Weapon")
            {
                throw new Exception("Weapon object's data does not match Item Type: Weapon");
            }
        }

        /// <summary>
        /// Modifies raw stat data and returns clean stat data
        /// </summary>
        /// <param name="StatData">StatData</param>
        private static int ModifyStat(String StatData)
        {
            if(int.Parse(StatData.Substring(0, 1)) < 2)
            {
                return int.Parse(StatData.Substring(1, 3));
            }
            else
            {
                return -(int.Parse(StatData.Substring(0, 3)));
            }
        }
    }
}
