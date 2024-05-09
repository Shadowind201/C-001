using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Meu primeiro programa C#");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi");
            MessageBox.Show("Tudo Bem?");
        }
    }
}
