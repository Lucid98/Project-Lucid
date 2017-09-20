using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Classes.Loader
{
    /// <summary>
    /// Load static class, cannot be inherited
    /// </summary>
    internal static class Load
    {
        /// <summary>
        /// Loads the string data for specified ItemID
        /// </summary>
        /// <param name="ItemID">ItemID</param>
        internal static String ItemData(String ItemID)
        {
            ValidateItemID(ItemID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/Item.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(ItemID == CurrentLine.Substring(0, 5))
                    {
                        return CurrentLine;
                    }
                } throw new Exception("ItemID does not exist: " + ItemID);
            }
        }

        /// <summary>
        /// Loads the string data for the specified CharacterID
        /// </summary>
        /// <param name="CharacterID">CharacterID</param>
        internal static String CharacterData(String CharacterID)
        {
            ValidateCharacterID(CharacterID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/Character.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(CharacterID == CurrentLine.Substring(0, 5))
                    {
                        return CurrentLine;
                    }
                } throw new Exception("CharacterID does not exist: " + CharacterID);
            }
        }

        /// <summary>
        /// Loads the string data for the specified ClassID
        /// </summary>
        /// <param name="ClassID">ClassID</param>
        internal static String ClassData(String ClassID)
        {
            ValidateClassID(ClassID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/Class.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(ClassID == CurrentLine.Substring(0, 5))
                    {
                        return CurrentLine;
                    }
                } throw new Exception("ClassID does not exist: " + ClassID);
            }
        }

        /// <summary>
        /// Loads the string data for the specified HealthConditionID
        /// </summary>
        /// <param name="HealthConditionID">HealthConditionID</param>
        internal static String HealthConditionData(String HealthConditionID)
        {
            ValidateHealthConditionID(HealthConditionID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/HealthCondition.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(HealthConditionID == CurrentLine.Substring(0, 5))
                    {
                        return CurrentLine;
                    }
                } throw new Exception("HealthConditionID does not exist: " + HealthConditionID);
            }
        }

        /// <summary>
        /// Loads the ItemType name for the specified ItemTypeID
        /// </summary>
        /// <param name="ItemTypeID">ItemTypeID</param>
        internal static String ItemType(String ItemTypeID)
        {
            ValidateItemTypeID(ItemTypeID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/ItemType.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(ItemTypeID == CurrentLine.Substring(0, 2))
                    {
                        return CurrentLine.Substring(3);
                    }
                } throw new Exception("ItemTypeID does not exist: " + ItemTypeID);
            }
        }

        /// <summary>
        /// Loads the WeaponType name for the specified WeaponTypeID
        /// </summary>
        /// <param name="WeaponTypeID">WeaponTypeID</param>
        internal static String WeaponType(String WeaponTypeID)
        {
            ValidateWeaponTypeID(WeaponTypeID);
            using(StreamReader Reader = new StreamReader("../Data/Raw/WeaponType.txt"))
            {
                String CurrentLine;
                while((CurrentLine = Reader.ReadLine()) != null)
                {
                    if(WeaponTypeID == CurrentLine.Substring(0, 2))
                    {
                        return CurrentLine.Substring(3);
                    }
                } throw new Exception("WeaponTypeID does not exist: " + WeaponTypeID);
            }
        }

        /// <summary>
        /// Validates ItemID
        /// </summary>
        /// <param name="ItemID">Item ID</param>
        private static void ValidateItemID(String ItemID)
        {
            if(ItemID.Length != 5)
            {
                throw new Exception("ItemID is not 5 digits: " + ItemID);
            }
        }

        /// <summary>
        /// Validates CharacterID
        /// </summary>
        /// <param name="CharacterID">Character ID</param>
        private static void ValidateCharacterID(String CharacterID)
        {
            if(CharacterID.Length != 5)
            {
                throw new Exception("CharacterID is not 5 digits: " + CharacterID);
            }
        }

        /// <summary>
        /// Validates ClassID
        /// </summary>
        /// <param name="ClassID">Class ID</param>
        private static void ValidateClassID(String ClassID)
        {
            if(ClassID.Length != 5)
            {
                throw new Exception("ClassID is not 5 digits: " + ClassID);
            }
        }

        /// <summary>
        /// Validates HealthConditionID
        /// </summary>
        /// <param name="HealthConditionID">HealthCondition ID</param>
        private static void ValidateHealthConditionID(String HealthConditionID)
        {
            if(HealthConditionID.Length != 5)
            {
                throw new Exception("HealthConditionID is not 5 digits: " + HealthConditionID);
            }
        }

        /// <summary>
        /// Validates ItemTypeID
        /// </summary>
        /// <param name="ItemTypeID">ItemType ID</param>
        private static void ValidateItemTypeID(String ItemTypeID)
        {
            if(ItemTypeID.Length != 2)
            {
                throw new Exception("ItemTypeID is not 2 digits: " + ItemTypeID);
            }
        }

        /// <summary>
        /// Validates WeaponTypeID
        /// </summary>
        /// <param name="WeaponTypeID">WeaponType ID</param>
        private static void ValidateWeaponTypeID(String WeaponTypeID)
        {
            if(WeaponTypeID.Length != 2)
            {
                throw new Exception("WeaponTypeID is not 2 digits: " + WeaponTypeID);
            }
        }
    }
}
