using Project_Lucid.Classes.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Lucid.Data.Player
{
    /// <summary>
    /// Save data for the game
    /// </summary>
    internal static class GlobalData
    {
        /// <summary>
        /// Current Character object
        /// </summary>
        internal static Character CurrentCharacter = null;

        /// <summary>
        /// List containing all characters the user has unlocked
        /// </summary>
        internal static List<Character> CharacterSet = null;

        /// <summary>
        /// Progress
        /// </summary>
        internal static int Progress = 0;

        /// <summary>
        /// Inventory object
        /// </summary>
        internal static Inventory Inventory = null;

        /// <summary>
        /// StorageChest object
        /// </summary>
        internal static StorageChest StorageChest = null;
    }
}
