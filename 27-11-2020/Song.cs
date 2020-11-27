using System;
using System.Collections.Generic;
using System.Text;

namespace _27_11_2020
{
    public class Song:IComparable
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public double Duration { get; set; }
        public Genre SongGenre { get; set; }
        public Song(string title, string artist,double duration,Genre songGenre)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            SongGenre = songGenre;
        }
        public Song(string title,string artist)
        {
            Title = title;
            Artist = artist;
            Duration = 0;
            SongGenre = Genre.Other;
        }
        public Song():this("unknown", "unknown"){ }
        public override string ToString()
        {
            return string.Format($"{Artist}{Title}{Duration}{SongGenre}");
        }

        public int CompareTo(object other)
        {
            Song that = (Song)other;
            int returnValue = this.Artist.CompareTo(that.Artist);
            if (returnValue == 0)
            {
                returnValue = this.Title.CompareTo(that.Title);
            }
            return returnValue;
        }
    }
    public enum Genre {  Rock, Pop, Dance, Other}
}
