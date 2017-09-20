using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_Lucid.Classes.GameDesign;

namespace Project_Lucid
{
    public partial class GameClient : Form
    {
        private Game game;

        public GameClient()
        {
            InitializeComponent();
            Run();
        }

        internal void Run()
        {
            game = new Game(this);
            game.LoadTitleScreen();
            game.LoadTitleMenu(this);
        }
    }
}
