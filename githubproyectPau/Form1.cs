using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace githubproyectPau
{
    //pau lopez
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBox1.ToString());
            char letter = funtionDNI(dni);
            textBox2.Text = letter.ToString();

        }
        private char funtionDNI(int dni)
        {
            char letter = 'A';
            return letter;

        }
    }
}
