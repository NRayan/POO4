using System;
using System.Windows.Forms;
using Models;


namespace POO4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Campainha camp1 = new Campainha1();
            camp1.Soar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Campainha camp2 = new Campainha2();
            camp2.Soar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Campainha camp3 = new Campainha3();
            camp3.Soar();
        }
    }
}
