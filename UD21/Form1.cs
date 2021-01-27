using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            this.button1.Visible = true;
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    label2.Text = "Lado:";
                    label3.Text = "";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    break;
                case 1:
                    label2.Text = "Radio:";
                    label3.Text = "";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox3.Visible = false;
                    textBox2.Visible = false;
                    break;
                case 2:
                    label2.Text = "Base:";
                    label3.Text = "Altura:";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case 3:
                    label2.Text = "Base:";
                    label3.Text = "Altura:";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case 4:
                    label2.Text = "Lado:";
                    label3.Text = "Apotema:";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case 5:
                    label2.Text = "Diagonal1:";
                    label3.Text = "Diagonal2:";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case 6:
                    label2.Text = "Base:";
                    label3.Text = "Altura:";
                    label4.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    break;
                case 7:
                    label2.Text = "Base1:";
                    label3.Text = "Base2:";
                    label4.Text = "Altura:";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria G = new Geometria();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    if (textBox1.Text != "")
                    {
                        label5.Text = Convert.ToString(G.areacuadrado(Convert.ToInt32(textBox1.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor del lado");
                    }
                    break;
                case 1:
                    if (textBox1.Text != "")
                    {
                        label5.Text = Convert.ToString(G.areaCirculo(Convert.ToInt32(textBox1.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor del radio");
                    }
                    break;
                case 2:
                    if (textBox1.Text != ""&&textBox2.Text!="")
                    {
                        label5.Text = Convert.ToString(G.areatriangulo(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor de la base y la altura");
                    }
                    break;
                case 3:
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        label5.Text = Convert.ToString(G.arearectangulo(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor de la base y la altura");
                    }
                    break;
                case 4:
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        label5.Text = Convert.ToString(G.areapentagono(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor del lado y el apotema");
                    }
                    break;
                case 5:
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        label5.Text = Convert.ToString(G.arearombo(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor de ambas diagonales");
                    }
                    break;
                case 6:
                    if (textBox1.Text != "" && textBox2.Text != "")
                    {
                        label5.Text = Convert.ToString(G.arearomboide(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor de la base y la altura");
                    }
                    break;
                case 7:
                    if (textBox1.Text != "" && textBox2.Text != ""&& textBox3.Text!="")
                    {
                        label5.Text = Convert.ToString(G.areatrapecio(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                        label5.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Introduce el valor de ambas bases y la altura");
                    }
                    break;

            }
        }
    }
}
