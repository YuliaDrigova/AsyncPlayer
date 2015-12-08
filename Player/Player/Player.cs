using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.AudioVideoPlayback;

namespace Player
{
    public partial class Player : Form
    {
        PlayList list;
        Audio au;
        Audio chosen;

        public Player()
        {
            InitializeComponent();
            bnPlay.Image = Image.FromFile("D:\\University\\1\\Player\\img\\play.png");
            bnStop.Image = Image.FromFile("D:\\University\\1\\Player\\img\\stop.jpg");
            bnPause.Image = Image.FromFile("D:\\University\\1\\Player\\img\\pause.png");
            list = new PlayList();
        }

        private void bnPlay_Click(object sender, EventArgs e)
        {
            if (au == null)
            {
                au = chosen;
            }

            else if (au != chosen)
            {

                au.Stop();
                au = chosen;
            }

            au.Play();

            var file = TagLib.File.Create(list.GetTracks().ElementAt(dgvPlaylist.CurrentRow.Index).path);
            if (file.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pbAlbum.Image = Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(214, 214, null, IntPtr.Zero);
            }
            
        }

        private void bnStop_Click(object sender, EventArgs e)
        {
            au.Stop();
        }

        private void bnPause_Click(object sender, EventArgs e)
        {
            au.Pause();
        }

        private void dgvPlaylist_Click(object sender, EventArgs e)
        {
            chosen = new Audio(list.GetTracks().ElementAt(dgvPlaylist.CurrentRow.Index).path);
        }

        private void dgvPlaylist_DoubleClick(object sender, EventArgs e)
        {
            bnPlay_Click(this, e);
        }

        private async void tsmAdd_Click(object sender, EventArgs e)
        {
            WorkWithFolders stream = new WorkWithFolders(@"E:\Music");
            await stream.ReadAllLinesAsync(list);

            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = list.GetTracks();
            dgvPlaylist.Columns[3].HeaderCell.Value = dgvPlaylist.Columns[3].HeaderCell.Value + "(MB)";
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            list.Remove(list.GetTracks().ElementAt(dgvPlaylist.CurrentRow.Index));
            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = list.GetTracks();
        }
    }
}
