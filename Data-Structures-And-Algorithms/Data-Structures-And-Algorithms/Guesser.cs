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
            LblFac.Text = Factorial(calc).ToString();  
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {

            Replay();
            if(textboxMax.TextLength >0 && textboxMın.TextLength>0)
            {

            max = Convert.ToInt16(textboxMax.Text);
            min = Convert.ToInt16(textboxMın.Text);

            mid = Guess(min,max);
            calc++;
            lblMyGuess.Text = "My Guess is: "+mid.ToString();
            }
            else
            {
                MessageBox.Show("You need to give two number");
            }
            
            
        }
        public int Guess(int MinNumber, int MaxNumber)
        {
            return MinNumber + ((MaxNumber - MinNumber) / 2);
        }

        private void WorkSpace_Load(object sender, EventArgs e)
        {

        }

        public int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return (number * Factorial(number - 1));
            }




            // __________________
            //int answer = 1;
            //for (int i= 1; i <= number; i++)
            //{
            //    answer = i*answer;
            //}

            //return answer;
        }

        public void Replay()
        {
            lblMyGuess.Text = "My guess";
            LblFac.Text = "";
            calc = 0;
        }
    }
}
