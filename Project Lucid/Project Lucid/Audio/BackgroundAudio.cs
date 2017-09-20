using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;

namespace Project_Lucid.Audio
{
    /// <summary>
    /// BackgroundAudio class, cannot be inherited
    /// </summary>
    internal sealed class BackgroundAudio
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private String filePath;

        /// <summary>
        /// Creates a BackgroundAudio object
        /// </summary>
        /// <param name="FilePath">Path to audio file</param>
        internal BackgroundAudio(String FilePath)
        {
            filePath = FilePath;
        }

        /// <summary>
        /// Plays the audio once
        /// </summary>
        internal void Play()
        {
            player.URL = filePath;
        }

        /// <summary>
        /// Plays the audio in a loop
        /// </summary>
        internal void PlayLoop()
        {
            player.settings.setMode("loop", true);
            player.URL = filePath;
        }

        /// <summary>
        /// Stops the audio
        /// </summary>
        internal void Stop()
        {
            player.controls.stop();
        }
    }
}
