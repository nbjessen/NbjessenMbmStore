using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        //fields
        private List<Track> tracks = new List<Track>();
        //properties
        public List<Track> Tracks {
            get { return tracks; } 
        } 


        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public string ImageFileName { get; set; }

        //constructor
        public MusicCD() 
        {
            
        }
        public MusicCD(int productID, string title, decimal price, string label, string artist, short released, string imageFileName) : base(productID, title, price)
        {
            Artist = artist;
            Label = label;
            Released = released;
            ImageFileName = imageFileName;
        }
        //method
        public void AddTrack(Track track)
        {
            Tracks.Add(track);
        }
        public TimeSpan GetPlayingTime()
        {
            TimeSpan playingTime = new TimeSpan(); 
            foreach (var track in Tracks)
            {
                var length = track.Length;
                playingTime = playingTime.Add(length);
            }
            return playingTime;
        }
    }
}
