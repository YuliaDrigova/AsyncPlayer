using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Track
    {
        public string artist { get; set; }
        public string name { get; set; }
        public string album { get; set; }
        public string extantion { get; set; }
        public string path { get; set; }
        public double size { get; set; }

        public Track(string artist, string album, double size, string name, string extantion, string path)
        {
            this.artist = artist;
            this.album = album;
            this.size = size;
            this.name = name;
            this.extantion = extantion;
            this.path = path;
        }

        public Track(){}

    }    
}
