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
    /// PlayMenu class, cannot be inherited
    /// </summary>
    internal sealed class PlayMenu
    {
        private Panel playMenu = new Panel();
        private BackgroundAudio selectControlSound = new BackgroundAudio(@"Audio\Main Menu\Title Menu Select.mp3");
        private BackgroundAudio clickControlSound = new BackgroundAudio(@"Audio\Main Menu\Title Menu Click.mp3");

        /// <summary>
        /// Creates a PlayMenu object representing a panel
        /// </summary>
        /// <param name="TitleMenu">TitleMenu object</param>
        internal PlayMenu(TitleMenu TitleMenu)
        {
            // Setting the properties of the panel
            playMenu.Name = "PlayMenu";
            playMenu.Parent = TitleMenu.Panel;
            playMenu.Size = new Size(960, 540);
            playMenu.Location = new Point(0, 0);
            playMenu.BackColor = Color.Black;
            TitleMenu.Panel.Controls.Add(playMenu);
            TitleMenu.Panel.Controls["PlayMenu"].BringToFront();

            PictureBox Background = new PictureBox();
            Background.Name = "Background";
            Background.Size = new Size(960, 540);
            Background.BackColor = Color.Transparent;
            Background.Image = Image.FromFile(@"Images\Title\Play Menu Background.png");
            playMenu.Controls.Add(Background);
        }

        /// <summary>
        /// Loads the controls of Play Menu
        /// </summary>
        internal void Load()
        {
            Button LoadGame = new Button();
            LoadGame.Name = "LoadGame";
            LoadGame.Text = "Load Game";
            LoadGame.Parent = playMenu.Controls["Background"];
            LoadGame.ForeColor = Color.Blue;
            LoadGame.Font = new Font("Arial", 10, FontStyle.Bold);
            LoadGame.TextAlign = ContentAlignment.MiddleLeft;
            LoadGame.FlatStyle = FlatStyle.Flat;
            LoadGame.Height = 27;
            LoadGame.Width = 895;
            LoadGame.BackColor = Color.LightGray;
            LoadGame.Location = new Point(30, 30);
            LoadGame.MouseEnter += HoverInLoadGameControl;
            LoadGame.MouseLeave += HoverOutLoadGameControl;
            (playMenu.Controls["Background"]).Controls.Add(LoadGame);
            (playMenu.Controls["Background"]).Controls["LoadGame"].BringToFront();

            Button NewGame = new Button();
            NewGame.Name = "NewGame";
            NewGame.Text = "New Game";
            NewGame.Parent = playMenu.Controls["Background"];
            NewGame.ForeColor = Color.Blue;
            NewGame.Font = new Font("Arial", 10, FontStyle.Bold);
            NewGame.TextAlign = ContentAlignment.MiddleLeft;
            NewGame.FlatStyle = FlatStyle.Flat;
            NewGame.Height = 27;
            NewGame.Width = 895;
            NewGame.BackColor = Color.LightGray;
            NewGame.Location = new Point(30, 65);
            NewGame.MouseEnter += HoverInNewGameControl;
            NewGame.MouseLeave += HoverOutNewGameControl;
            (playMenu.Controls["Background"]).Controls.Add(NewGame);
            (playMenu.Controls["Background"]).Controls["NewGame"].BringToFront();

            Button Back = new Button();
            Back.Name = "Back";
            Back.Text = "Back";
            Back.Parent = playMenu.Controls["Background"];
            Back.ForeColor = Color.Blue;
            Back.Font = new Font("Arial", 10, FontStyle.Bold);
            Back.TextAlign = ContentAlignment.MiddleLeft;
            Back.FlatStyle = FlatStyle.Flat;
            Back.Height = 27;
            Back.Width = 895;
            Back.BackColor = Color.LightGray;
            Back.Location = new Point(30, 100);
            Back.MouseEnter += HoverInBackControl;
            Back.MouseLeave += HoverOutBackControl;
            Back.Click += ClickBackControl;
            (playMenu.Controls["Background"]).Controls.Add(Back);
            (playMenu.Controls["Background"]).Controls["Back"].BringToFront();
        }

        /// <summary>
        /// Gets the panel of the PlayMenu
        /// </summary>
        internal Panel Panel
        {
            get { return playMenu; }
        }

        /// <summary>
        /// This event is called when the mouse hovers into the LoadGame control
        /// </summary>
        private void HoverInLoadGameControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["LoadGame"].ForeColor = Color.DarkRed;
            (playMenu.Controls["Background"]).Controls["LoadGame"].Location = new Point(32, 30);
            selectControlSound.Play();
        }

        /// <summary>
        /// This event is called when the mouse hovers out of the LoadGame control
        /// </summary>
        private void HoverOutLoadGameControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["LoadGame"].ForeColor = Color.Blue;
            (playMenu.Controls["Background"]).Controls["LoadGame"].Location = new Point(30, 30);
        }

        /// <summary>
        /// This event is called when the mouse hovers into the NewGame control
        /// </summary>
        private void HoverInNewGameControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["NewGame"].ForeColor = Color.DarkRed;
            (playMenu.Controls["Background"]).Controls["NewGame"].Location = new Point(32, 65);
            selectControlSound.Play();
        }

        /// <summary>
        /// This event is called when the mouse hovers out of the NewGame control
        /// </summary>
        private void HoverOutNewGameControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["NewGame"].ForeColor = Color.Blue;
            (playMenu.Controls["Background"]).Controls["NewGame"].Location = new Point(30, 65);
        }

        /// <summary>
        /// This event is called when the mouse hovers into the Back control
        /// </summary>
        private void HoverInBackControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["Back"].ForeColor = Color.DarkRed;
            (playMenu.Controls["Background"]).Controls["Back"].Location = new Point(32, 100);
            selectControlSound.Play();
        }

        /// <summary>
        /// This event is called when the mouse hovers out of the Back control
        /// </summary>
        private void HoverOutBackControl(object sender, EventArgs e)
        {
            (playMenu.Controls["Background"]).Controls["Back"].ForeColor = Color.Blue;
            (playMenu.Controls["Background"]).Controls["Back"].Location = new Point(30, 100);
        }

        /// <summary>
        /// This event is called when the mouse clicks on the Back control
        /// </summary>
        private void ClickBackControl(object sender, EventArgs e)
        {
            playMenu.Visible = false;
            clickControlSound.Play();
        }
    }
}
