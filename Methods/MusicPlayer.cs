using System;

namespace Methods
{
    public class MusicPlayer
    {
        public string CurrentSong;
        public bool IsPlaying;
        public int Volume;

        public MusicPlayer(string song, int volume)
        {
            this.CurrentSong = song;
            this.Volume = volume;
            this.IsPlaying = false;
        }

        public void Play()
        {
            this.IsPlaying = true;
            Console.WriteLine("Now playing: " + this.CurrentSong);
        }

        public void Pause()
        {
            this.IsPlaying = false;
            Console.WriteLine("Playback paused.");
        }

        public void ChangeVolume(int newVolume)
        {
            this.Volume = newVolume;
            Console.WriteLine("Volume set to " + this.Volume);
        }

        public void ChangeSong(string newSong)
        {
            this.CurrentSong = newSong;
            Console.WriteLine("Song changed to: " + this.CurrentSong);
        }
    }
}
