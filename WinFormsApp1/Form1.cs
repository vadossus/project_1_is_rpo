using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int click = 1;

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(550, 863); // 550; 863
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1267, 843);
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
            this.Size = new Size(1267, 843);
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
            this.Size = new Size(1267, 843);
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
            this.Size = new Size(1267, 843);
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
            this.Size = new Size(1267, 843);
            panel5.Visible = true;
            click++;
            if (click == 2)
            {
                panel5.Visible = false;
                click = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=LbOve_UZZ54");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
