using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadatak2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double korijen = (b * b) - (4 * a * c);
            double re, im, x1, x2; //re - jedno realno rješenje ako je korijen=0 i realno rješenje kada je korijen<0
            if(korijen > 0) //provjera je li korijen > 0
            {
                x1 = (-b + System.Math.Sqrt(korijen)) / (2 * a); //izračun prvog rješenja kvadratne jednadžbe
                x2 = (-b - System.Math.Sqrt(korijen)) / (2 * a); //izračun drugog rješenja kvadratne jednadžbe
                label4.Text = "x1 = " + x1.ToString();
                label5.Text = "x2 = " + x2.ToString();
            }

            else if(korijen < 0) //provjera je li korjen<0
            {
                korijen = -korijen; //stavimo da je korijen negativan
                re = -b / 2 * a; //realni dio rješenja
                im = System.Math.Sqrt(korijen) / (2 * a); //imaginarni dio rješenja
                label4.Text =  "x1 = " + re.ToString() + " + " + "j" + im.ToString();
                label5.Text =  "x2 = " + re.ToString() + " - " + "j" + im.ToString();
            }

            else
            {
                re = (-b + System.Math.Sqrt(korijen)) / (2 * a);
                label4.Text =  "x = " + re.ToString();
                label5.Text =  " "; //s obzirom da ima samo jedno rješenje kada je korjen=0, onda stavim da se na label5 ništa ne ispiše
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Text = " jednadžba: " + textBox1.Text + "x\xB2 +" + textBox2.Text + "x +" + textBox3.Text + " = " + " 0";
        }
    }
}
