using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Project_Lucid.Audio
{
    /// <summary>
    /// BackgroundAudio class, cannot be inherited
    /// </summary>
    internal sealed class BackgroundAudio1
    {
        private SoundPlayer backgroundAudio = new SoundPlayer();

        /// <summary>
        /// Creates a BackgroundAudio
        /// </summary>
        /// <param name="FilePath">Path to the .wav file</param>
        internal BackgroundAudio1(String FilePath)
        {
            backgroundAudio.SoundLocation = FilePath;
        }

        /// <summary>
        /// Plays the audio once
        /// </summary>
        internal void Play()
        {
            backgroundAudio.Play();
        }

        /// <summary>
        /// Plays the audio in a loop
        /// </summary>
        internal void PlayLoop()
        {
            backgroundAudio.PlayLooping();
        }

        /// <summary>
        /// Stops the audio
        /// </summary>
        internal void Stop()
        {
            backgroundAudio.Stop();
        }
    }
}
