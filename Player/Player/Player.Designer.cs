namespace Player
{
    partial class Player
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnPlay = new System.Windows.Forms.Button();
            this.bnStop = new System.Windows.Forms.Button();
            this.bnPause = new System.Windows.Forms.Button();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnPlay
            // 
            this.bnPlay.Location = new System.Drawing.Point(443, 27);
            this.bnPlay.Name = "bnPlay";
            this.bnPlay.Size = new System.Drawing.Size(51, 51);
            this.bnPlay.TabIndex = 3;
            this.bnPlay.UseVisualStyleBackColor = true;
            this.bnPlay.Click += new System.EventHandler(this.bnPlay_Click);
            // 
            // bnStop
            // 
            this.bnStop.Location = new System.Drawing.Point(443, 209);
            this.bnStop.Name = "bnStop";
            this.bnStop.Size = new System.Drawing.Size(51, 51);
            this.bnStop.TabIndex = 4;
            this.bnStop.UseVisualStyleBackColor = true;
            this.bnStop.Click += new System.EventHandler(this.bnStop_Click);
            // 
            // bnPause
            // 
            this.bnPause.Location = new System.Drawing.Point(443, 117);
            this.bnPause.Name = "bnPause";
            this.bnPause.Size = new System.Drawing.Size(51, 51);
            this.bnPause.TabIndex = 5;
            this.bnPause.UseVisualStyleBackColor = true;
            this.bnPause.Click += new System.EventHandler(this.bnPause_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(0, 27);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(437, 233);
            this.dgvPlaylist.TabIndex = 6;
            this.dgvPlaylist.Click += new System.EventHandler(this.dgvPlaylist_Click);
            this.dgvPlaylist.DoubleClick += new System.EventHandler(this.dgvPlaylist_DoubleClick);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Location = new System.Drawing.Point(500, 37);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(214, 214);
            this.pbAlbum.TabIndex = 8;
            this.pbAlbum.TabStop = false;
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.tsmDelete});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(714, 24);
            this.msMenu.TabIndex = 9;
            this.msMenu.Text = "Menu";
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(41, 20);
            this.tsmAdd.Text = "Add";
            this.tsmAdd.Click += new System.EventHandler(this.tsmAdd_Click);
            // 
            // tsmDelete
            // 
            this.tsmDelete.Name = "tsmDelete";
            this.tsmDelete.Size = new System.Drawing.Size(52, 20);
            this.tsmDelete.Text = "Delete";
            this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 294);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.bnPause);
            this.Controls.Add(this.bnStop);
            this.Controls.Add(this.bnPlay);
            this.MainMenuStrip = this.msMenu;
            this.Name = "Player";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnPlay;
        private System.Windows.Forms.Button bnStop;
        private System.Windows.Forms.Button bnPause;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmDelete;
    }
}

