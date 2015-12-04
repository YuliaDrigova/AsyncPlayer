using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
   public class PlayList : ICollection<Track>
    {
        protected ICollection<Track> tracks;

        public PlayList() 
        {
            tracks = new List<Track>();
        }

        public PlayList(ICollection<Track> tracks)
        {
            this.tracks = tracks;
        }

        public IEnumerable<Track> GetTracks()
        {
            return tracks.AsEnumerable();
        }

        public void Add(Track item)
        {
            tracks.Add(item);
        }

        public void Clear()
        {
            tracks.Clear();
        }

        public bool Contains(Track item)
        {
            return tracks.Contains(item);
        }

        public void CopyTo(Track[] array, int arrayIndex)
        {
            tracks.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return tracks.Count(); }
        }

        public bool IsReadOnly
        {
            get { return tracks.IsReadOnly; }
        }

        public bool Remove(Track item)
        {
            return tracks.Remove(item);
        }

        public IEnumerator<Track> GetEnumerator()
        {
            return tracks.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return tracks.GetEnumerator();
        }

        
    }
}
