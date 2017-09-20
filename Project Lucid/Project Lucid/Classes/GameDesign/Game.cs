using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Lucid.Classes.GameDesign
{
    /// <summary>
    /// Game class, cannot be inherited
    /// </summary>
    internal sealed class Game
    {
        private TitleScreen titleScreen;
        private TitleMenu titleMenu;
        //private GameScreen gameScreen = new GameScreen();

        /// <summary>
        /// Create a Game object
        /// </summary>
        internal Game(Form GameClient)
        {
            titleScreen = new TitleScreen(GameClient);
            GameClient.Controls.Add(titleScreen.Panel);

            titleMenu = new TitleMenu(GameClient);
            GameClient.Controls.Add(titleMenu.Panel);
        }

        /// <summary>
        /// Loads the TitleScreen
        /// </summary>
        internal void LoadTitleScreen()
        {
            titleScreen.Load();
        }

        /// <summary>
        /// Loads the TitleMenu
        /// </summary>
        /// <param name="GameClient">Game Client</param>
        internal void LoadTitleMenu(Form GameClient)
        {
            titleMenu.Load(GameClient);
        }
    }
}
