using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
        private void button_WOC1_Click_1(object sender, EventArgs e)
        {
            //DNA boxes are empty?
            bool flag2 = false;
            if (firstDNA.Text =="" )
            {
                MessageBox.Show("Sequence one is empty.Enter Again.", "Warning");
                percent.Text = "";
                flag2 = true;
            }
            if (secondDNA.Text == "")
            {
                MessageBox.Show("Sequence two is empty.Enter Again.", "Warning");
                percent.Text = "";
                flag2 = true;
            }
            int size1;
            int size2;
            string s;
            //Genome Class where compare two DNA
            Genome c = new Genome();
            s = firstDNA.Text.ToUpper();
            size1 = s.Length;
            char[] arr1 = new char[size1];//Array for first DNA
            bool flag = false;
            //String to Array conversion of firstDNA
            for (int i = 0; i < size1; i++)
            {
                if (s[i] == 'A' || s[i] == 'G' || s[i] == 'C' || s[i] == 'T' || s[i] == 'N')
                {
                    arr1[i] = s[i];
                    
                }
                else
                {
                    MessageBox.Show("Sequence 1 DNA is incorrect.Enter Again.", "Warning");
                    firstDNA.Text = "";
                    percent.Text = "";
                    flag = true;
                    break;
                }
            }
            s = secondDNA.Text.ToUpper();
            size2 = s.Length;
            char[] arr2 = new char[size2]; //Array for secondDNA
            //String to Array conversion of firstDNA
            for (int i = 0; i < size2; i++)
            {
                if (s[i] == 'A' || s[i] == 'G' || s[i] == 'C' || s[i] == 'T' || s[i] == 'N')
                {
                    arr2[i] = s[i];
                }
                else
                {
                    MessageBox.Show("Sequence 2 DNA is incorrect.Enter Again.", "Warning");
                    secondDNA.Text = "";
                    percent.Text = "";
                    flag = true;
                    break;
                }

            }
            //Finding percentage of matching DNA w.r.t to firstDNA
            if (flag == false && flag2 == false)
            {
                float perc;
                int len;
                len = c.CHECKER(arr1, arr2, size1, size2);
                perc = (len * 100) / size1;
                string check = perc.ToString();
                percent.Text = check + "%";
            }
            

        }

        private void button_WOC2_Click(object sender, EventArgs e)
        {
            //Exit button/To close form
            this.Close();
        }
    }
}
