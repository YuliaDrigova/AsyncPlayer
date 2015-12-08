using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class WorkWithFolders
    {
        string path;
        public Stopwatch timer = new Stopwatch();

        public WorkWithFolders(string path)
        {
            this.path = path;
        }


        public async Task<PlayList> ReadAllLinesAsync(PlayList list)
        {
            timer.Start();

            await GetFilesFromDirectory(path, list);

            timer.Stop();
            
            return list;
        }

        private Task<PlayList> GetFilesFromDirectory(string path, PlayList list)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            DirectoryInfo[] directories = di.GetDirectories();

            if (directories.Length != 0)
            {
                foreach (var directory in directories)
                {
                    GetFilesFromDirectory(directory.FullName, list);
                }
            }
            return Task.Run(() =>
                {
                    FileInfo[] files = di.GetFiles("*.mp3");

                    if (files.Length != 0)
                    {
                        foreach (var file in files)
                        {
                            Parser parser = new Parser();
                            var tag = TagLib.File.Create(file.FullName);
                            list.Add(new Track() { album = parser.ParseAlbum(tag.Tag.Album), artist = parser.ParseArtist(tag.Tag.FirstPerformer), name = parser.ParseName(tag.Tag.Title), extantion = file.Extension, path = file.FullName, size = Math.Round(file.Length / 1048576.00, 2) });
                        }
                    }
                    return list;
                });
        }
    }
}
