using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Vadim\source\repos\WinFormsApp1\bin\Debug\net8.0-windows";
            string filePath = Path.Combine(path, "info1.txt");

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine(textBox5.Text);
            }

            MessageBox.Show("Файл создан", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
}
