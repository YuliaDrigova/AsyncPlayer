using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Player
{
    class PlaylistSerialization
    {
        private string FilePath;

        public PlaylistSerialization(string filePath)
        {
            this.FilePath = filePath;
        }

        public void SavePlayListToXml(PlayList playlist)
        {
            using (var writer = new FileStream(FilePath, FileMode.Create))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Track>), new XmlRootAttribute("Track"));
                ser.Serialize(writer, playlist.GetTracks().ToList());
                writer.Close();
            }
        }

        public PlayList ReadPlayListFromXml()
        {
            using (var reader = new StreamReader(FilePath))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(List<Track>), new XmlRootAttribute("Track"));
                return new PlayList((List<Track>)deserializer.Deserialize(reader));
            }

        }
    }
}
