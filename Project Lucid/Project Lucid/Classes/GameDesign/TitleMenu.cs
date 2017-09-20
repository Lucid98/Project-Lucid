using Project_Lucid.Audio;
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
    /// TitleMenu class, cannot be inherited
    /// </summary>
    internal sealed class TitleMenu
    {
        private Panel titleMenu = new Panel();
        private PlayMenu playMenu;
        private List<Image> imageList = new List<Image>();
        private BackgroundAudio backgroundAudio = new BackgroundAudio(@"Audio\Main Menu\Main Menu Theme.mp3");
        private BackgroundAudio selectControlSound = new BackgroundAudio(@"Audio\Main Menu\Title Menu Select.mp3");
        private BackgroundAudio clickControlSound = new BackgroundAudio(@"Audio\Main Menu\Title Menu Click.mp3");
        private Timer titleTimer = new Timer();
        private Timer backgroundChangeTimer = new Timer();
        private Timer loadTitleMenuTimer = new Timer();
        private int index = 0;
        private bool titleLoaded = false;

        /// <summary>
        /// Creates a TitleMenu object representing a panel
        /// </summary>
        /// <param name="GameClient">Game client</param>
        internal TitleMenu(Form GameClient)
        {
            // Setting the properties of the panel
            titleMenu.Name = "TitleMenu";
            titleMenu.Size = new Size(960, 540);
            titleMenu.Location = new Point(0, 0);
            titleMenu.BackColor = Color.Transparent;
            GameClient.Controls.Add(titleMenu);

            PictureBox Background = new PictureBox();
            Background.Name = "Background";
            Background.Size = new Size(960, 540);
            Background.BackColor = Color.Transparent;
            titleMenu.Controls.Add(Background);

            // Adds the title load/menu images to an Image list
            imageList.Add(Image.FromFile(@"Images\Title\White Screen.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Title Menu Background 1.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Title Menu Background 2.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Title Menu Background 3.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Title Menu Background 4.png"));
            imageList.Add(Image.FromFile(@"Images\Title\Title Menu Background 5.png"));
        }

        /// <summary>
        /// Loads the TitleMenu
        /// </summary>
        /// <param name="GameClient">Game Client</param>
        internal void Load(Form GameClient)
        {
            // Start index of the imagelist
            index = 0;

            // Shows the panel if hidden
            if (!titleMenu.Visible) titleMenu.Visible = true;

            // Setting up the timer for the title load
            titleTimer.Tick += AnimateTitle;
            titleTimer.Interval = 3000;
            titleTimer.Enabled = true;

            backgroundChangeTimer.Tick += AnimateBackgroundImage;
            backgroundChangeTimer.Interval = 250;
            backgroundChangeTimer.Enabled = true;

            loadTitleMenuTimer.Tick += LoadTitleMenuControls;
            loadTitleMenuTimer.Interval = 1000;
            loadTitleMenuTimer.Enabled = true;

            // Starting the timers
            titleTimer.Start();
            backgroundChangeTimer.Start();
            loadTitleMenuTimer.Start();
        }

        /// <summary>
        /// Gets the panel of the TitleMenu
        /// </summary>
        internal Panel Panel
        {
            get { return titleMenu; }
        }

        /// <summary>
        /// Tick event for Timer where it changes image every tick for the title load
        /// </summary>
        private void AnimateTitle(object sender, EventArgs e)
        {
            if(index >= 2)
            {
                titleLoaded = true;

                // Stopping the timer for the title load
                titleTimer.Stop();
            }
            else
            {
                // Changes Image in the PictureBox every tick
                ((PictureBox)titleMenu.Controls["Background"]).Image = imageList[index];
                index++;
            }
        }

        /// <summary>
        /// Tick event for Timer where it changes image every tick for the background
        /// change in the title menu
        /// </summary>
        private void AnimateBackgroundImage(object sender, EventArgs e)
        {
            if (titleLoaded)
            {
                if (index < imageList.Count)
                {
                    ((PictureBox)titleMenu.Controls["Background"]).Image = imageList[index];
                    index++;
                }
                else
                {
                    index = 1;
                    ((PictureBox)titleMenu.Controls["Background"]).Image = imageList[index];
                    index++;
                }
            }
        }

        /// <summary>
        /// Load the controls of Title Menu
        /// </summary>
        private void LoadTitleMenuControls(object sender, EventArgs e)
        {
            if (titleLoaded)
            {
                Label Play = new Label();
                Play.Name = "Play";
                Play.Text = "PLAY";
                Play.Parent = titleMenu.Controls["Background"];
                Play.ForeColor = Color.DarkBlue;
                Play.Font = new Font("Arial", 30, FontStyle.Bold);
                Play.Height = 48;
                Play.Width = 120;
                Play.BackColor = Color.Transparent;
                Play.Location = new Point(150, 210);
                Play.MouseEnter += HoverInPlayControl;
                Play.MouseLeave += HoverOutPlayControl;
                Play.Click += ClickPlayControl;
                (titleMenu.Controls["Background"]).Controls.Add(Play);
                (titleMenu.Controls["Background"]).Controls["Play"].BringToFront();

                Label Credits = new Label();
                Credits.Name = "Credits";
                Credits.Text = "CREDITS";
                Credits.Parent = titleMenu.Controls["Background"];
                Credits.ForeColor = Color.DarkBlue;
                Credits.Font = new Font("Arial", 30, FontStyle.Bold);
                Credits.Height = 48;
                Credits.Width = 200;
                Credits.BackColor = Color.Transparent;
                Credits.Location = new Point(150, 270);
                Credits.MouseEnter += HoverInCreditsControl;
                Credits.MouseLeave += HoverOutCreditsControl;
                (titleMenu.Controls["Background"]).Controls.Add(Credits);
                (titleMenu.Controls["Background"]).Controls["Credits"].BringToFront();

                Label Quit = new Label();
                Quit.Name = "Quit";
                Quit.Text = "QUIT";
                Quit.Parent = titleMenu.Controls["Background"];
                Quit.ForeColor = Color.DarkBlue;
                Quit.Font = new Font("Arial", 30, FontStyle.Bold);
                Quit.Height = 48;
                Quit.Width = 120;
                Quit.BackColor = Color.Transparent;
                Quit.Location = new Point(150, 330);
                Quit.MouseEnter += HoverInQuitControl;
                Quit.MouseLeave += HoverOutQuitControl;
                Quit.Click += ClickQuitControl;
                (titleMenu.Controls["Background"]).Controls.Add(Quit);
                (titleMenu.Controls["Background"]).Controls["Quit"].BringToFront();

                Label Version = new Label();
                Version.Name = "Version";
                Version.Text = "Prototype 1";
                Version.Parent = titleMenu.Controls["Background"];
                Version.ForeColor = Color.Yellow;
                Version.Font = new Font("Arial", 15, FontStyle.Bold);
                Version.Height = 25;
                Version.Width = 120;
                Version.BackColor = Color.Blue;
                Version.Location = new Point(0, 515);
                (titleMenu.Controls["Background"]).Controls.Add(Version);
                (titleMenu.Controls["Background"]).Controls["Version"].BringToFront();

                backgroundAudio.PlayLoop();
                loadTitleMenuTimer.Stop();
            }
        }

        /// <summary>
        /// Turns the color of the Play control to Red when mouse hover in
        /// </summary>
        private void HoverInPlayControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Play"].ForeColor = Color.Red;
            (titleMenu.Controls["Background"]).Controls["Play"].Location = new Point(155, 210);
            selectControlSound.Play();
        }

        /// <summary>
        /// Turns the color of the Play control to DarkBlue when mouse hover out
        /// </summary>
        private void HoverOutPlayControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Play"].ForeColor = Color.DarkBlue;
            (titleMenu.Controls["Background"]).Controls["Play"].Location = new Point(150, 210);
        }

        /// <summary>
        /// Loads the Play Menu when the Play control is clicked
        /// </summary>
        private void ClickPlayControl(object sender, EventArgs e)
        {
            clickControlSound.Play();
            if (titleMenu.Contains(titleMenu.Controls["PlayMenu"]))
            {
                titleMenu.Controls["PlayMenu"].Visible = true;
            }
            else
            {
                playMenu = new PlayMenu(this);
                playMenu.Load();
            }
        }

        /// <summary>
        /// Turns the color of the Credits control to Red when mouse hover in
        /// </summary>
        private void HoverInCreditsControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Credits"].ForeColor = Color.Red;
            (titleMenu.Controls["Background"]).Controls["Credits"].Location = new Point(155, 270);
            selectControlSound.Play();
        }

        /// <summary>
        /// Turns the color of the Credits control to DarkBlue when mouse hover out
        /// </summary>
        private void HoverOutCreditsControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Credits"].ForeColor = Color.DarkBlue;
            (titleMenu.Controls["Background"]).Controls["Credits"].Location = new Point(150, 270);
        }

        /// <summary>
        /// Turns the color of the Quit control to Red when mouse hover in
        /// </summary>
        private void HoverInQuitControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Quit"].ForeColor = Color.Red;
            (titleMenu.Controls["Background"]).Controls["Quit"].Location = new Point(155, 330);
            selectControlSound.Play();
        }

        /// <summary>
        /// Turns the color of the Quit control to DarkBlue when mouse hover out
        /// </summary>
        private void HoverOutQuitControl(object sender, EventArgs e)
        {
            (titleMenu.Controls["Background"]).Controls["Quit"].ForeColor = Color.DarkBlue;
            (titleMenu.Controls["Background"]).Controls["Quit"].Location = new Point(150, 330);
        }

        /// <summary>
        /// Exits the application when the Quit control is clicked
        /// </summary>
        private void ClickQuitControl(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
