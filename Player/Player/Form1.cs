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
    public partial class Form1 : Form
    {
        PlayList list;
        Audio au;
        Audio chosen;

        public Form1()
        {
            InitializeComponent();
            bnPlay.Image = Image.FromFile("D:\\University\\1\\Player\\img\\play.png");
            bnStop.Image = Image.FromFile("D:\\University\\1\\Player\\img\\stop.jpg");
            bnPause.Image = Image.FromFile("D:\\University\\1\\Player\\img\\pause.png");
            list = new PlayList();
        }


        private async void bnAdd_Click(object sender, EventArgs e)
        {
            WorkWithFolders stream = new WorkWithFolders(@"E:\Music");
            await stream.ReadAllLinesAsync(list);
            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = list.GetTracks();           
            MessageBox.Show(stream.timer.ElapsedMilliseconds.ToString());
            dgvPlaylist.Columns[3].HeaderCell.Value = dgvPlaylist.Columns[3].HeaderCell.Value + "(MB)";
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

        private void bnDelete_Click(object sender, EventArgs e)
        {
            list.Remove(list.GetTracks().ElementAt(dgvPlaylist.CurrentRow.Index));
            dgvPlaylist.DataSource = null;
            dgvPlaylist.DataSource = list.GetTracks();
        }
    }
}
