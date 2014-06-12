namespace DoosanBears
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.구단정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구단연혁ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구단응원가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.빠라빠빠ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.해냈다두산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.승리의두산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.선수별정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.야수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홍성흔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.투수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.포수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구단정보ToolStripMenuItem,
            this.선수별정보ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 구단정보ToolStripMenuItem
            // 
            this.구단정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구단연혁ToolStripMenuItem,
            this.구단응원가ToolStripMenuItem});
            this.구단정보ToolStripMenuItem.Name = "구단정보ToolStripMenuItem";
            this.구단정보ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.구단정보ToolStripMenuItem.Text = "구단 정보";
            // 
            // 구단연혁ToolStripMenuItem
            // 
            this.구단연혁ToolStripMenuItem.Name = "구단연혁ToolStripMenuItem";
            this.구단연혁ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.구단연혁ToolStripMenuItem.Text = "구단 연혁";
            // 
            // 구단응원가ToolStripMenuItem
            // 
            this.구단응원가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.빠라빠빠ToolStripMenuItem,
            this.해냈다두산ToolStripMenuItem,
            this.승리의두산ToolStripMenuItem});
            this.구단응원가ToolStripMenuItem.Name = "구단응원가ToolStripMenuItem";
            this.구단응원가ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.구단응원가ToolStripMenuItem.Text = "구단 응원가";
            this.구단응원가ToolStripMenuItem.Click += new System.EventHandler(this.구단응원가ToolStripMenuItem_Click);
            // 
            // 빠라빠빠ToolStripMenuItem
            // 
            this.빠라빠빠ToolStripMenuItem.Name = "빠라빠빠ToolStripMenuItem";
            this.빠라빠빠ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.빠라빠빠ToolStripMenuItem.Text = "빠라빠빠";
            this.빠라빠빠ToolStripMenuItem.Click += new System.EventHandler(this.빠라빠빠ToolStripMenuItem_Click);
            // 
            // 해냈다두산ToolStripMenuItem
            // 
            this.해냈다두산ToolStripMenuItem.Name = "해냈다두산ToolStripMenuItem";
            this.해냈다두산ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.해냈다두산ToolStripMenuItem.Text = "해냈다 두산";
            this.해냈다두산ToolStripMenuItem.Click += new System.EventHandler(this.해냈다두산ToolStripMenuItem_Click);
            // 
            // 승리의두산ToolStripMenuItem
            // 
            this.승리의두산ToolStripMenuItem.Name = "승리의두산ToolStripMenuItem";
            this.승리의두산ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.승리의두산ToolStripMenuItem.Text = "승리의 두산";
            this.승리의두산ToolStripMenuItem.Click += new System.EventHandler(this.승리의두산ToolStripMenuItem_Click);
            // 
            // 선수별정보ToolStripMenuItem
            // 
            this.선수별정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.야수ToolStripMenuItem,
            this.투수ToolStripMenuItem,
            this.포수ToolStripMenuItem});
            this.선수별정보ToolStripMenuItem.Name = "선수별정보ToolStripMenuItem";
            this.선수별정보ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.선수별정보ToolStripMenuItem.Text = "선수별 정보";
            // 
            // 야수ToolStripMenuItem
            // 
            this.야수ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.홍성흔ToolStripMenuItem});
            this.야수ToolStripMenuItem.Name = "야수ToolStripMenuItem";
            this.야수ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.야수ToolStripMenuItem.Text = "야수";
            // 
            // 홍성흔ToolStripMenuItem
            // 
            this.홍성흔ToolStripMenuItem.Name = "홍성흔ToolStripMenuItem";
            this.홍성흔ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.홍성흔ToolStripMenuItem.Text = "홍성흔";
            this.홍성흔ToolStripMenuItem.Click += new System.EventHandler(this.홍성흔ToolStripMenuItem_Click);
            // 
            // 투수ToolStripMenuItem
            // 
            this.투수ToolStripMenuItem.Name = "투수ToolStripMenuItem";
            this.투수ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.투수ToolStripMenuItem.Text = "투수";
            // 
            // 포수ToolStripMenuItem
            // 
            this.포수ToolStripMenuItem.Name = "포수ToolStripMenuItem";
            this.포수ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.포수ToolStripMenuItem.Text = "포수";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DoosanBears.Properties.Resources.Jamsil;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 419);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 구단정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구단연혁ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구단응원가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 빠라빠빠ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 해냈다두산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 승리의두산ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 선수별정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 야수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 홍성흔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 투수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 포수ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

