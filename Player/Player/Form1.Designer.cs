namespace Player
{
    partial class Form1
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
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnPlay = new System.Windows.Forms.Button();
            this.bnStop = new System.Windows.Forms.Button();
            this.bnPause = new System.Windows.Forms.Button();
            this.dgvPlaylist = new System.Windows.Forms.DataGridView();
            this.bnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // bnAdd
            // 
            this.bnAdd.Location = new System.Drawing.Point(498, 12);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(75, 23);
            this.bnAdd.TabIndex = 2;
            this.bnAdd.Text = "Add";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnAdd_Click);
            // 
            // bnPlay
            // 
            this.bnPlay.Location = new System.Drawing.Point(30, 175);
            this.bnPlay.Name = "bnPlay";
            this.bnPlay.Size = new System.Drawing.Size(51, 51);
            this.bnPlay.TabIndex = 3;
            this.bnPlay.UseVisualStyleBackColor = true;
            this.bnPlay.Click += new System.EventHandler(this.bnPlay_Click);
            // 
            // bnStop
            // 
            this.bnStop.Location = new System.Drawing.Point(176, 175);
            this.bnStop.Name = "bnStop";
            this.bnStop.Size = new System.Drawing.Size(54, 51);
            this.bnStop.TabIndex = 4;
            this.bnStop.UseVisualStyleBackColor = true;
            this.bnStop.Click += new System.EventHandler(this.bnStop_Click);
            // 
            // bnPause
            // 
            this.bnPause.Location = new System.Drawing.Point(332, 175);
            this.bnPause.Name = "bnPause";
            this.bnPause.Size = new System.Drawing.Size(51, 51);
            this.bnPause.TabIndex = 5;
            this.bnPause.UseVisualStyleBackColor = true;
            this.bnPause.Click += new System.EventHandler(this.bnPause_Click);
            // 
            // dgvPlaylist
            // 
            this.dgvPlaylist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylist.Location = new System.Drawing.Point(0, 0);
            this.dgvPlaylist.Name = "dgvPlaylist";
            this.dgvPlaylist.Size = new System.Drawing.Size(473, 150);
            this.dgvPlaylist.TabIndex = 6;
            this.dgvPlaylist.Click += new System.EventHandler(this.dgvPlaylist_Click);
            // 
            // bnDelete
            // 
            this.bnDelete.Location = new System.Drawing.Point(498, 56);
            this.bnDelete.Name = "bnDelete";
            this.bnDelete.Size = new System.Drawing.Size(75, 23);
            this.bnDelete.TabIndex = 7;
            this.bnDelete.Text = "Delete";
            this.bnDelete.UseVisualStyleBackColor = true;
            this.bnDelete.Click += new System.EventHandler(this.bnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 262);
            this.Controls.Add(this.bnDelete);
            this.Controls.Add(this.dgvPlaylist);
            this.Controls.Add(this.bnPause);
            this.Controls.Add(this.bnStop);
            this.Controls.Add(this.bnPlay);
            this.Controls.Add(this.bnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnPlay;
        private System.Windows.Forms.Button bnStop;
        private System.Windows.Forms.Button bnPause;
        private System.Windows.Forms.DataGridView dgvPlaylist;
        private System.Windows.Forms.Button bnDelete;
    }
}

