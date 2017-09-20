using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Lucid.Classes.GameDesign
{
    /// <summary>
    /// TitleScreen class, cannot be inherited
    /// </summary>
    internal sealed class TitleScreen
    {
        private Panel titleScreen = new Panel();
        private List<Image> imageList = new List<Image>();
        private Timer timer = new Timer();
        private int index = 0;

        /// <summary>
        /// Creates A TitleScreen object representing a panel
        /// </summary>
        /// <param name="GameClient">Game client</param>
        internal TitleScreen(Form GameClient)
        {
            // Setting the properties of the panel
            titleScreen.Name = "TitleScreen";
            titleScreen.Size = new Size(960, 540);
            titleScreen.Location = new Point(0, 0);
            titleScreen.BackColor = Color.Black;
            GameClient.Controls.Add(titleScreen);

            PictureBox Screen = new PictureBox();
            Screen.Size = new Size(960, 540);
            Screen.BackColor = Color.Black;
            titleScreen.Controls.Add(Screen);

            // Adds the title screen images to an Image list
            imageList.Add(Image.FromFile(@"Images\Title\Home Game Studio Title.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Visual Studio Title.png"));
        }

        /// <summary>
        /// Loads the TitleScreen
        /// </summary>
        internal void Load()
        {
            // Start index of the imagelist
            index = 0;

            // Shows the panel if hidden
            if (!titleScreen.Visible) titleScreen.Visible = true;

            // Setting up the timer
            timer.Tick += Animate;
            timer.Interval = 3000;
            timer.Enabled = true;

            // Starting the timer
            timer.Start();
        }

        /// <summary>
        /// Gets the panel of the TitleScreen
        /// </summary>
        internal Panel Panel
        {
            get { return titleScreen; }
        }

        /// <summary>
        /// Gets the imagelist of the TitleScreen
        /// </summary>
        internal List<Image> ImageList
        {
            get { return imageList; }
        }

        /// <summary>
        /// Sets the bool value of the visibility of the panel object
        /// </summary>
        internal bool Visible
        {
            set { titleScreen.Visible = value; }
        }

        /// <summary>
        /// Tick event for Timer where it changes image every tick
        /// </summary>
        private void Animate(object sender, EventArgs e)
        {
            if (index >= imageList.Count)
            {
                // Stopping the timer
                timer.Stop();

                // Hides the panel
                titleScreen.Visible = false;
            }
            else
            {
                // Changes Image in the PictureBox every tick
                ((PictureBox)titleScreen.Controls[0]).Image = imageList[index];
                index++;
            }
        }
    }
}
