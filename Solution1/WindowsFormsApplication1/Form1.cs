using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Checked = false;
            checkBox4.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                label1.Text = "selecciono el check2";
            }
            if (checkBox3.Checked == true)
            {
                label1.Text = "selecciono el check3";
            }
            if (checkBox4.Checked == true)
            {
                label1.Text = "selecciono el check4";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "un solo click ";
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "dos click ";
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label1.Text = "suma";
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "resta";
            }
            if (radioButton3.Checked == true)
            {
                label1.Text = "multiplicacion";
            }
            if (radioButton4.Checked == true)
            {
                label1.Text = "division";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                Form1 obj = new Form1();
                obj.BackColor = Color.Green;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                comboBox1.Items.Add(i.ToString());


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
         
       

    }
}
