using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Data_Structures_And_Algorithms
{
    public partial class WorkSpace : Form
    {
        int max, min, mid;
        int calc = 0;


        private void BtnHigher_Click(object sender, EventArgs e)
        {
            min = mid;
            mid = Guess(mid, max);
            calc++;
            lblMyGuess.Text = "My Guess is: " + mid.ToString();
        }

        public WorkSpace()
        {
            InitializeComponent();
        }

        private void BtnLower_Click(object sender, EventArgs e)
        {
            max = mid;
            mid = Guess(min, mid);
            calc++;
            lblMyGuess.Text = "My Guess is: " + mid.ToString();
        }

        private void BtnCorrect_Click(object sender, EventArgs e)
        {
            lblMyGuess.Text = "Yey your number is: " + mid.ToString() +"\n Process steps : "+calc;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            max = Convert.ToInt16(textboxMax.Text);
            min = Convert.ToInt16(textboxMın.Text);

            mid = Guess(min,max);
            calc++;
            lblMyGuess.Text = "My Guess is: "+mid.ToString();
            
            
        }
        public int Guess(int MinNumber, int MaxNumber)
        {
            return MinNumber + ((MaxNumber - MinNumber) / 2);
        }
    }
}
