using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KF2Uni;
namespace TestApp
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

        private void button1_Click(object sender, EventArgs e)
        {
            KF2Uni.KiranFont obj = new KF2Uni.KiranFont();

            String input = textBox1.Text;
            String output = obj.convertKFkiran2Uni(input);
            textBox2.Text = output;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String OutputfilePath = textBox3.Text;
            File.WriteAllText(OutputfilePath, textBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
