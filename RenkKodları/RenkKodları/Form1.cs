using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RenkKodları
{
    public partial class Form1 : Form
    {    
        public Form1()
        {   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a,b,c,d;
            a = comboBox1.SelectedIndex;
            b = comboBox2.SelectedIndex;
            c = comboBox3.SelectedIndex;
            d = comboBox4.SelectedIndex;
            double k;
            k =  Math.Pow(10, d);
            string h = a.ToString() +b.ToString() +c.ToString();

            double sonuc = k * (Convert.ToInt32(h));



            label6.Text = sonuc.ToString()  
                ; 
                





















            /*Siyah
            Kahverengi
            Kırmızı
            Turuncu
            Sarı
            Yeşil
            Mavi
            Mor
            Gri
            Beyaz*/
            if (comboBox1.SelectedIndex == 0)
            {
                button1.BackColor= Color.Black;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                button1.BackColor = Color.Brown;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                button1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                button1.BackColor = Color.Orange;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                button1.BackColor = Color.Yellow;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                button1.BackColor = Color.Green;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                button1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                button1.BackColor = Color.Purple;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                button1.BackColor = Color.Gray;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                button1.BackColor = Color.White;
            }
            //1.renk tamam
            if (comboBox2.SelectedIndex == 0)
            {
                button2.BackColor = Color.Black;
            }
            if (comboBox2.SelectedIndex == 1)
            {
                button2.BackColor = Color.Brown;
            }
            if (comboBox2.SelectedIndex == 2)
            {
                button2.BackColor = Color.Red;
            }
            if (comboBox2.SelectedIndex == 3)
            {
                button2.BackColor = Color.Orange;
            }
            if (comboBox2.SelectedIndex == 4)
            {
                button2.BackColor = Color.Yellow;
            }
            if (comboBox2.SelectedIndex == 5)
            {
                button2.BackColor = Color.Green;
            }
            if (comboBox2.SelectedIndex == 6)
            {
                button2.BackColor = Color.Blue;
            }
            if (comboBox2.SelectedIndex == 7)
            {
                button2.BackColor = Color.Purple;
            }
            if (comboBox2.SelectedIndex == 8)
            {
                button2.BackColor = Color.Gray;
            }
            if (comboBox2.SelectedIndex == 9)
            {
                button2.BackColor = Color.White;
            }
            //2.de tamam
            if (comboBox3.SelectedIndex == 0)
            {
                button3.BackColor = Color.Black;
            }
            if (comboBox3.SelectedIndex == 1)
            {
                button3.BackColor = Color.Brown;
            }
            if (comboBox3.SelectedIndex == 2)
            {
                button3.BackColor = Color.Red;
            }
            if (comboBox3.SelectedIndex == 3)
            {
                button3.BackColor = Color.Orange;
            }
            if (comboBox3.SelectedIndex == 4)
            {
                button3.BackColor = Color.Yellow;
            }
            if (comboBox3.SelectedIndex == 5)
            {
                button3.BackColor = Color.Green;
            }
            if (comboBox3.SelectedIndex == 6)
            {
                button3.BackColor = Color.Blue;
            }
            if (comboBox3.SelectedIndex == 7)
            {
                button3.BackColor = Color.Purple;
            }
            if (comboBox3.SelectedIndex == 8)
            {
                button3.BackColor = Color.Gray;
            }
            if (comboBox3.SelectedIndex == 9)
            {
                button3.BackColor = Color.White;
            }
            //3detamam
            if (comboBox4.SelectedIndex == 0)
            {
                button4.BackColor = Color.Black;
            }
            if (comboBox4.SelectedIndex == 1)
            {
                button4.BackColor = Color.Brown;
            }
            if (comboBox4.SelectedIndex == 2)
            {
                button4.BackColor = Color.Red;
            }
            if (comboBox4.SelectedIndex == 3)
            {
                button4.BackColor = Color.Orange;
            }
            if (comboBox4.SelectedIndex == 4)
            {
                button4.BackColor = Color.Yellow;
            }
            if (comboBox4.SelectedIndex == 5)
            {
                button4.BackColor = Color.Green;
            }
            if (comboBox4.SelectedIndex == 6)
            {
                button4.BackColor = Color.Blue;
            }
            if (comboBox4.SelectedIndex == 7)
            {
                button4.BackColor = Color.Purple;
            }
            if (comboBox4.SelectedIndex == 8)
            {
                button4.BackColor = Color.Gray;
            }
            if (comboBox4.SelectedIndex == 9)
            {
                button4.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
