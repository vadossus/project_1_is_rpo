using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 :Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\st310-08\Documents\GorovoyPR32\WinFormsApp1\bin\Debug\net8.0-windows"; 
            string filePath = Path.Combine(path, "info.txt");
            DateTime dt = dateTimePicker1.Value;

            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                sw.WriteLine(comboBox1.SelectedItem.ToString());
                sw.WriteLine(dt.ToString());
                sw.WriteLine(textBox1.Text);
            }

            MessageBox.Show("Файл создан", "Информация", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }
    }
}
