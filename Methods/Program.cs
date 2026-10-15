using System;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            var player = new MusicPlayer("Imagine - John Lennon", 50);

            player.Play(); 
            player.ChangeVolume(70); 
            player.Pause();

            player.ChangeSong("Bohemian Rhapsody - Queen");
            player.Play();
        }
    }
}
