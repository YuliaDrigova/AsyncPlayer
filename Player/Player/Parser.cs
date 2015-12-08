using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class Parser
    {
        public string ParseName(string fileName)
        {
            if (fileName == null)
            {
                fileName = "Unknown composition";
            }
            return fileName;
        }

        public string ParseArtist(string artist)
        {
            if (artist == null)
            {
                artist = "Unknown artist";
            }
            return artist;
        }

        public string ParseAlbum(string album)
        {
            if (album == null)
            {
                album = "Unknown album";
            }
            return album;
        }
    }
}
