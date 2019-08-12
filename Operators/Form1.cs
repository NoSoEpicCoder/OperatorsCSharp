using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        int firstNumber, secondNumber;

        private void Button1_Click(object sender, EventArgs e) {

            firstNumber = int.Parse(textBox1.Text);
            secondNumber = int.Parse(textBox2.Text);

            if (firstNumber >= secondNumber) {
                MessageBox.Show("First number is greater");
            }

            if (firstNumber <= secondNumber) {
                MessageBox.Show("Second number is greater");
            }
        }
    }
}
