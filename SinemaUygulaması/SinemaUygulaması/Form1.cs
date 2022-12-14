using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //kat, salon, koltuk
        string[,,] sinema = new string[2, 3, 4];
        private void Form1_Load(object sender, EventArgs e)
        {
            sinema[0, 0, 0] = "X"; //0.kat 0.salon 0.ve 1.koltuk dolu
            sinema[0, 0, 1] = "X";
            
        }

       

        private void biletalbtn_Click(object sender, EventArgs e)
        {
            int katNo = comboBox1.SelectedIndex;
            int salon = comboBox2.SelectedIndex; 

            if (textBox1.Text == "X")
            {
                sinema[katNo, salon, 0] = "X";
            }
            if (textBox2.Text == "X")
            {
                sinema[katNo, salon, 1] = "X";
            }
            if (textBox3.Text == "X")
            {
                sinema[katNo, salon, 2] = "X";
            }
            if (textBox4.Text == "X")
            {
                sinema[katNo, salon, 3] = "X";
            }


        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            textBox3.Text = "X";
           
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            textBox4.Text = "X";
           
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();


            int katBoyut = sinema.GetLength(0);
            int salonBoyut = sinema.GetLength(1);
            int secimKat = comboBox1.SelectedIndex;
            int secimSalon = comboBox2.SelectedIndex;


            for (int kat = 0; kat < katBoyut; kat++)
            {
                for (int salon = 0; salon < salonBoyut; salon++)
                {
                    for (int koltuk = 0; koltuk < 4; koltuk++)
                    {
                        if (sinema[secimKat, secimSalon, koltuk] == "X")
                        {
                            switch (koltuk)
                            {
                                case 0:
                                    textBox1.Text = "X";
                                    textBox1.ReadOnly = true;
                                    break;
                                case 1:
                                    textBox2.Text = "X";
                                    textBox2.ReadOnly = true;
                                    break;
                                case 2:
                                    textBox3.Text = "X";
                                    textBox3.ReadOnly = true;
                                    break;
                                case 3:
                                    textBox4.Text = "X";
                                    textBox4.ReadOnly = true;
                                    break;

                                default:
                                    break;
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "X")
            {
                textBox1.Text = "";
                label3.Text = "1.Koltuk iptal edildi";
            }
            else if (textBox2.Text == "X")
            {
                textBox2.Text = "";
                label3.Text = "2.Koltuk iptal edildi";
            }    
            else if (textBox3.Text == "X")
            {
                textBox3.Text = "";
                label3.Text = "3.Koltuk iptal edildi";
            }
            else if (textBox4.Text=="X")
            {
                textBox4.Text = "";
                label3.Text = "4.Koltuk iptal edildi"; 
            }
            
            
            
            textBox4.Text = "";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "X";
            
            

        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.Text = "X";

            
        }
    }
}
