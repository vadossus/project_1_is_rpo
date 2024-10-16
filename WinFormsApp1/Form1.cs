namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int click = 0;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(550, 863); // 550; 863
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1097, 863);
            click++;
            panel1.Visible = true;
            if (click == 2)
            {
                panel1.Visible = false;
                click = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1097, 863);
            panel2.Visible = true;
            click++;
            if (click == 2)
            {
                panel2.Visible = false;
                click = 0;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1097, 863);
            panel3.Visible = true;
            click++;
            if (click == 2)
            {
                panel3.Visible = false;
                click = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1097, 863);
            panel4.Visible = true;
            click++;
            if (click == 2)
            {
                panel4.Visible = false;
                click = 0;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1097, 863);
            panel5.Visible = true;
            click++;
            if (click == 2)
            {
                panel5.Visible = false;
                click = 0;
            }
        }
    }
}
