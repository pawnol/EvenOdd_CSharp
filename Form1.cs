/*
 * Even or Odd
 * Pawelski
 * 1/3/2022
 * Read the code and run the program a few times so you understand
 * what the program does and how it works. Once you understand what
 * the program does and how it works, answer the questions found
 * on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOdd
{
    public partial class EvenOddForm : Form
    {
        public EvenOddForm()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt32(numberTextBox.Text);
            if (number % 2 == 0)
            {
                evenOddLabel.Text = number + " is even.";
            }
            else
            {
                evenOddLabel.Text = number + " is odd.";
            }
        }
    }
}
