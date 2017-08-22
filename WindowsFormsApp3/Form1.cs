using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text =="admin")
            {
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Duzgun username ve password girin:");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        TextBox tb;
        static int a = 480;
        Button btn = new Button();
        Label hekimler = new Label();
        ListBox list1 = new ListBox();
        Button btn1 = new Button();
        TextBox hekimyarat = new TextBox();

        public void button3_Click(object sender, EventArgs e)
        {
            btn.Text = textBox7.Text;
            btn.Width = 120;
            btn.Height = 30;
            btn.BackColor = Color.Aqua;
            btn.Left = a;
            btn.Top = 215;
            Controls.Add(btn);
   
            hekimler.Text = "hekimler";
            hekimler.Top = 280;
            hekimler.Left = a;
            Controls.Add(hekimler);
    
            list1.Width = 140;
            list1.Height = 200;
            list1.Top = 330;
            list1.Left = a;
            Controls.Add(list1);

            btn1.Width = 120;
            btn1.Height = 30;
            btn1.BackColor = Color.Aqua;
            btn1.Left = a;
            btn1.Top = 580;
            btn1.Click += new EventHandler(this.btn1_Click);
            Controls.Add(btn1);

            hekimyarat.Width = 120;
            hekimyarat.Height = 35;
            hekimyarat.Top = 620;
            hekimyarat.Left = a;
            Controls.Add(hekimyarat);
            a += 300;

        }

        public void btn1_Click(object sender, EventArgs e)
        {
            list1.Items.Add(hekimyarat.Text);
        }


        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button13_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void button19_Click(object sender, EventArgs e)
        {
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
        }


        static int b = 350;
        private void button22_Click(object sender, EventArgs e)
        {
            TextBox hekim = new TextBox();
            hekim.Top = b;
            hekim.Left = 714;
            hekim.Width = 213;
            Controls.Add(hekim);
            Button sil = new Button();
            sil.Width = 62;
            sil.Left = 630;
            sil.Top = b;
            sil.BackColor = Color.Gray;
            sil.Text = "sil";
            Controls.Add(sil);
            b += 40;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void button29_Click(object sender, EventArgs e)
        {
        }

        private void button33_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox16.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(textBox17.Text);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add(textBox19.Text);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            listBox3.Items.Remove(textBox18.Text);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button30.Visible = false;
            button33.Visible = false;
            button34.Visible = false;
            button32.Visible = false;
            listBox2.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            label3.Visible = false;
            button37.Visible = true;
        }
    }
}
