using System;
using System.Collections.Generic;

namespace _27_11_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Song s1 = new Song("ED SHEERAN", "BEAUTIFUL PEOPLE", 3.15, Genre.Pop);
            Song s2 = new Song("REGARD", "RIDE IT", 3.37, Genre.Dance);
            Song s3 = new Song("TONES & I", "DANCE MONKEY", 4.20, Genre.Dance);
            Song s4 = new Song("POST MALONE", "CIRCLES", 3.25, Genre.Pop);
            Song s5 = new Song("ED SHEERAN", "SOUTH OF THE BORDER", 4.26, Genre.Other);
            List<Song> playlist = new List<Song>();
            playlist.Add(s1);
            playlist.Add(s2);
            playlist.Add(s3);
            playlist.Add(s4);
            playlist.Add(s5);
            Display(playlist);
            playlist.Sort();
            Display(playlist);
            Shuffle(playlist);
            Display(playlist);

        }
        private static void Display(List<Song> playlist)
        {
            Console.WriteLine("\n{0}{1,24}{2,23}{3,23}", "Artist:", "Title:", "Duration:", "Music Genre:");
            foreach (Song song in playlist)
            {
                Console.WriteLine($"{song.Artist, -25}{song.Title, -20}{song.Duration, -20}{song.SongGenre, -20}");
            }
        }
        private static void Shuffle(List<Song> playlist)
        {
            Random rng = new Random();
            int numberOfSongs = playlist.Count;
            while(numberOfSongs > 1)
            {
                numberOfSongs--;
                int randomNumber = rng.Next(numberOfSongs+1);
                Song song = playlist[randomNumber];
                playlist[randomNumber] = playlist[numberOfSongs];
                playlist[numberOfSongs] = song;
            }
        }
    }
}
