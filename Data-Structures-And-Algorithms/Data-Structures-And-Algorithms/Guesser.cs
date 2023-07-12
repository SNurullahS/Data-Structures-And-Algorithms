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
        GMethods GMethods = new GMethods();


        private void BtnHigher_Click(object sender, EventArgs e)
        {
            min = mid;
            mid = GMethods.Guess(mid, max);
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
            mid = GMethods.Guess(min, mid);
            calc++;
            lblMyGuess.Text = "My Guess is: " + mid.ToString();
        }

        private void BtnCorrect_Click(object sender, EventArgs e)
        {
            lblMyGuess.Text = "Yey your number is: " + mid.ToString() +"\n Process steps : "+calc;
            LblFac.Text = GMethods.Factorial(calc).ToString();  
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            Replay();
            if(textboxMax.TextLength >0 && textboxMın.TextLength>0)
            {

            max = Convert.ToInt16(textboxMax.Text);
            min = Convert.ToInt16(textboxMın.Text);

            mid = GMethods.Guess(min,max);
            calc++;
            lblMyGuess.Text = "My Guess is: "+mid.ToString();
            }
            else
            {
                MessageBox.Show("You need to give two number");
            }
            
            
        }
        public void Replay()
        {
            lblMyGuess.Text = "My guess";
            LblFac.Text = "";
            calc = 0;
        }
    }
}
