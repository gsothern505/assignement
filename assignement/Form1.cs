using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignement
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

        private void Button1_Click(object sender, EventArgs e)
        {
            double ResistorSeries1, ResistorSeries2, TotalResistance1;
            try
            {
                ResistorSeries1 = double.Parse(textBox1.Text);
                ResistorSeries2 = double.Parse(textBox2.Text);
                //These lines of code allow the program to still run when a letter is entered.
            }
            catch
            {
                MessageBox.Show("!Input Error!");
                ResistorSeries1 = 0.0;
                ResistorSeries2 = 0.0;
                //These lines of code will inform the user why the program didn't work by showing an error message.
            }

            TotalResistance1 = ResistorSeries1 + ResistorSeries2;
            MessageBox.Show(TotalResistance1.ToString());
            //This will display the answer after the button has been clicked and the numbers have been put into the equasion.

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double ResistorSeries3, ResistorSeries4, ResistorSeries5, TotalResistance2;
            try
            {
                ResistorSeries3 = double.Parse(textBox3.Text);
                ResistorSeries4 = double.Parse(textBox4.Text);
                ResistorSeries5 = double.Parse(textBox5.Text);
                //The only difference between this and the first series circuit is that there is an additional variable.
            }
            catch
            {
                MessageBox.Show("!Input Error!");
                ResistorSeries3 = 0.0;
                ResistorSeries4 = 0.0;
                ResistorSeries5 = 0.0;
                //The only difference between this and the first series circuit is that there is an additional variable that needs to be reset to 0.0.
            }

            TotalResistance2 = ResistorSeries3 + ResistorSeries4 + ResistorSeries5;
            MessageBox.Show(TotalResistance2.ToString());

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double ResistorParallel1, ResistorParallel2, TotalResistance3;
            try
            {
                ResistorParallel1 = double.Parse(textBox6.Text);
                ResistorParallel2 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("!Input Error!");
                ResistorParallel1 = 0.0;
                ResistorParallel2 = 0.0;
            }

            TotalResistance3 = 1.0 / ((1.0 / ResistorParallel1) + (1.0 / ResistorParallel2));
            MessageBox.Show(TotalResistance3.ToString());
            //The parallel circuits are the same as the series circuit other than different names for variables and the different equasion.

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double ResistorParallel3, ResistorParallel4, ResistorParallel5, TotalResistance4;
            try
            {
                ResistorParallel3 = double.Parse(textBox8.Text);
                ResistorParallel4 = double.Parse(textBox9.Text);
                ResistorParallel5 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("!Input Error!");
                ResistorParallel3 = 0.0;
                ResistorParallel4 = 0.0;
                ResistorParallel5 = 0.0;
            }

            TotalResistance4 = 1.0 / ((1.0 / ResistorParallel3) + (1.0 / ResistorParallel4) + (1.0 / ResistorParallel5));
            MessageBox.Show(TotalResistance4.ToString());
            //The only difference between this and the first parallel circuit is that there is an additional variable.

        }
    }
}
