namespace RSP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_pa = new System.Windows.Forms.PictureBox();
            this.pic_sci = new System.Windows.Forms.PictureBox();
            this.pic_Roc = new System.Windows.Forms.PictureBox();
            this.player_panel = new System.Windows.Forms.Panel();
            this.player_picbox = new System.Windows.Forms.PictureBox();
            this.ai_panel = new System.Windows.Forms.Panel();
            this.ai_picbox = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Roc)).BeginInit();
            this.player_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player_picbox)).BeginInit();
            this.ai_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ai_picbox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(142, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(309, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Scissor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.RosyBrown;
            this.label5.Location = new System.Drawing.Point(505, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Paper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RSP.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(12, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RSP.Properties.Resources.index7;
            this.pictureBox2.Location = new System.Drawing.Point(612, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pic_pa
            // 
            this.pic_pa.Image = global::RSP.Properties.Resources.index2;
            this.pic_pa.Location = new System.Drawing.Point(505, 57);
            this.pic_pa.Name = "pic_pa";
            this.pic_pa.Size = new System.Drawing.Size(100, 84);
            this.pic_pa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pa.TabIndex = 7;
            this.pic_pa.TabStop = false;
            this.pic_pa.Click += new System.EventHandler(this.pic_pa_Click);
            // 
            // pic_sci
            // 
            this.pic_sci.Image = global::RSP.Properties.Resources.index5;
            this.pic_sci.Location = new System.Drawing.Point(309, 57);
            this.pic_sci.Name = "pic_sci";
            this.pic_sci.Size = new System.Drawing.Size(107, 84);
            this.pic_sci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_sci.TabIndex = 8;
            this.pic_sci.TabStop = false;
            this.pic_sci.Click += new System.EventHandler(this.pic_sci_Click);
            // 
            // pic_Roc
            // 
            this.pic_Roc.Image = global::RSP.Properties.Resources.index4;
            this.pic_Roc.Location = new System.Drawing.Point(125, 57);
            this.pic_Roc.Name = "pic_Roc";
            this.pic_Roc.Size = new System.Drawing.Size(101, 84);
            this.pic_Roc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Roc.TabIndex = 9;
            this.pic_Roc.TabStop = false;
            this.pic_Roc.Click += new System.EventHandler(this.pic_Roc_Click);
            // 
            // player_panel
            // 
            this.player_panel.BackColor = System.Drawing.Color.Transparent;
            this.player_panel.Controls.Add(this.player_picbox);
            this.player_panel.Location = new System.Drawing.Point(158, 176);
            this.player_panel.Name = "player_panel";
            this.player_panel.Size = new System.Drawing.Size(134, 108);
            this.player_panel.TabIndex = 10;
            // 
            // player_picbox
            // 
            this.player_picbox.Location = new System.Drawing.Point(12, 16);
            this.player_picbox.Name = "player_picbox";
            this.player_picbox.Size = new System.Drawing.Size(108, 78);
            this.player_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.player_picbox.TabIndex = 0;
            this.player_picbox.TabStop = false;
            // 
            // ai_panel
            // 
            this.ai_panel.BackColor = System.Drawing.Color.Transparent;
            this.ai_panel.Controls.Add(this.ai_picbox);
            this.ai_panel.Location = new System.Drawing.Point(411, 176);
            this.ai_panel.Name = "ai_panel";
            this.ai_panel.Size = new System.Drawing.Size(134, 108);
            this.ai_panel.TabIndex = 11;
            // 
            // ai_picbox
            // 
            this.ai_picbox.Location = new System.Drawing.Point(13, 16);
            this.ai_picbox.Name = "ai_picbox";
            this.ai_picbox.Size = new System.Drawing.Size(108, 78);
            this.ai_picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ai_picbox.TabIndex = 1;
            this.ai_picbox.TabStop = false;
            this.ai_picbox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(55, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(107, 109);
            this.listBox1.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(723, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(286, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 15;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RSP.Properties.Resources.index331;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(254, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 230);
            this.panel1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ai_panel);
            this.Controls.Add(this.player_panel);
            this.Controls.Add(this.pic_Roc);
            this.Controls.Add(this.pic_sci);
            this.Controls.Add(this.pic_pa);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock Scissor Paper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Roc)).EndInit();
            this.player_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.player_picbox)).EndInit();
            this.ai_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ai_picbox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pic_pa;
        private PictureBox pic_sci;
        private PictureBox pic_Roc;
        private Panel player_panel;
        private PictureBox player_picbox;
        private Panel ai_panel;
        private PictureBox ai_picbox;
        private ListBox listBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private Label label2;
        private Panel panel1;
    }
}