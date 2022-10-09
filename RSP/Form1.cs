namespace RSP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pic_Roc_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            player_panel.BackColor = Color.White;
            ai_panel.BackColor = Color.LightGray;
            int aiChoice;
            player_picbox.Image = pic_Roc.Image;

            int randnum = rand.Next(100, 4000);
            aiChoice = (randnum % 3) + 1;

            switch (aiChoice)
            {
                case 1:
                    ai_picbox.Image = pic_Roc.Image;
                    label2.Text = "Draw";
                    listBox1.Items.Add("Without Winner");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    ai_picbox.Image = pic_pa.Image;
                    label2.Text = "Paper covers Rock";
                    ai_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("AI Won!");
                    listBox1.Items.Add("\n");
                    break;
                case 3:
                    ai_picbox.Image = pic_sci.Image;
                    label2.Text = "Rock crushes scissor!";
                    player_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("Player Won!");
                    listBox1.Items.Add("\n");
                    break;
            }

        }

        private void pic_sci_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            player_panel.BackColor = Color.White;
            ai_panel.BackColor = Color.White;
            int aiChoice;
            player_picbox.Image = pic_sci.Image;

            int randnum = rand.Next(100, 4000);
            aiChoice = (randnum % 3) + 1;

            switch (aiChoice)
            {
                case 1:
                    ai_picbox.Image = pic_Roc.Image;
                    label2.Text = "Rock crushes Scissor!";
                    ai_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("AI Won!");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    ai_picbox.Image = pic_pa.Image;
                    label2.Text = "Scissor cuts Paper";
                    player_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("Player Won");
                    listBox1.Items.Add("\n");
                    break;
                case 3:
                    ai_picbox.Image = pic_sci.Image;
                    label2.Text = "Draw";
                    listBox1.Items.Add("Without Winner");
                    listBox1.Items.Add("\n");
                    break;
            }


        }

        private void pic_pa_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            player_panel.BackColor = Color.White;
            ai_panel.BackColor = Color.White;
            int aiChoice;
            player_picbox.Image = pic_pa.Image;

            int randnum = rand.Next(100, 4000);
            aiChoice = (randnum % 3) + 1;

            switch (aiChoice)
            {
                case 1:
                    ai_picbox.Image = pic_Roc.Image;
                    label2.Text = "Paper covers rock";
                    player_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("Player Won!");
                    listBox1.Items.Add("\n");
                    break;
                case 2:
                    ai_picbox.Image = pic_pa.Image;
                    label2.Text = "Draw";
                    listBox1.Items.Add("Without Winner!");
                    listBox1.Items.Add("\n");
                    break;
                case 3:
                    ai_picbox.Image = pic_sci.Image;
                    label2.Text = "Scissor Cuts Paper!";
                    ai_panel.BackColor = Color.Aqua;
                    listBox1.Items.Add("AI Won!");
                    listBox1.Items.Add("\n");
                    break;
            }
        }

        private void Reset()
        {
            ai_picbox.Image = null;
            player_picbox.Image = null;
            label2.Text = null;
            player_panel.BackColor = Color.White;
            ai_panel.BackColor = Color.White;
            listBox1.Items.Clear();
        }

        
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Reset();
        }
    }
}