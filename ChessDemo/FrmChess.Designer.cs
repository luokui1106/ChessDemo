namespace ChessDemo
{
    partial class FrmChess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChess));
            this.pbChessboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.游戏选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStrat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmXiaoAo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmQianNv = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbChessboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbChessboard
            // 
            this.pbChessboard.Image = ((System.Drawing.Image)(resources.GetObject("pbChessboard.Image")));
            this.pbChessboard.Location = new System.Drawing.Point(-7, 28);
            this.pbChessboard.Name = "pbChessboard";
            this.pbChessboard.Size = new System.Drawing.Size(526, 579);
            this.pbChessboard.TabIndex = 0;
            this.pbChessboard.TabStop = false;
            this.pbChessboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbChessboard_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏选项ToolStripMenuItem,
            this.背景音乐ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(515, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 游戏选项ToolStripMenuItem
            // 
            this.游戏选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStrat,
            this.tsmRestart,
            this.tsmExit});
            this.游戏选项ToolStripMenuItem.Name = "游戏选项ToolStripMenuItem";
            this.游戏选项ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.游戏选项ToolStripMenuItem.Text = "游戏选项";
            // 
            // tsmStrat
            // 
            this.tsmStrat.Name = "tsmStrat";
            this.tsmStrat.Size = new System.Drawing.Size(124, 22);
            this.tsmStrat.Text = "开始游戏";
            this.tsmStrat.Click += new System.EventHandler(this.tsmStrat_Click);
            // 
            // tsmRestart
            // 
            this.tsmRestart.Name = "tsmRestart";
            this.tsmRestart.Size = new System.Drawing.Size(124, 22);
            this.tsmRestart.Text = "重新开始";
            this.tsmRestart.Click += new System.EventHandler(this.tsmRestart_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(124, 22);
            this.tsmExit.Text = "退出";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // 背景音乐ToolStripMenuItem
            // 
            this.背景音乐ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmXiaoAo,
            this.tsmQianNv});
            this.背景音乐ToolStripMenuItem.Name = "背景音乐ToolStripMenuItem";
            this.背景音乐ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.背景音乐ToolStripMenuItem.Text = "背景音乐";
            // 
            // tsmXiaoAo
            // 
            this.tsmXiaoAo.Name = "tsmXiaoAo";
            this.tsmXiaoAo.Size = new System.Drawing.Size(152, 22);
            this.tsmXiaoAo.Text = "笑傲江湖";
            this.tsmXiaoAo.Click += new System.EventHandler(this.tsmXiaoAo_Click);
            // 
            // tsmQianNv
            // 
            this.tsmQianNv.Name = "tsmQianNv";
            this.tsmQianNv.Size = new System.Drawing.Size(152, 22);
            this.tsmQianNv.Text = "倩女幽魂";
            this.tsmQianNv.Click += new System.EventHandler(this.tsmQianNv_Click);
            // 
            // FrmChess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 604);
            this.Controls.Add(this.pbChessboard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmChess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChess2";
            ((System.ComponentModel.ISupportInitialize)(this.pbChessboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbChessboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 游戏选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmStrat;
        private System.Windows.Forms.ToolStripMenuItem tsmRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripMenuItem 背景音乐ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmXiaoAo;
        private System.Windows.Forms.ToolStripMenuItem tsmQianNv;
    }
}