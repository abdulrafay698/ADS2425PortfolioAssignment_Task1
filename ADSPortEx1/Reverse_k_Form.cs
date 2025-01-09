using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADSPortEx1
{
    public partial class Reverse_k_Form : Form
    {

        private GuestQueue guestQueue; 
        public Reverse_k_Form(ref GuestQueue other)
        {
            InitializeComponent();
            this.guestQueue = other;
        }


        // reverse action ... 
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Empty box, please provide input.");
            }
            else if (guestQueue.IsEmpty())
            {
                MessageBox.Show("Queue is Empty!");
            }
            else
            {

                string kInput = textBox1.Text;

                if (int.TryParse(kInput, out int k))
                {
                    guestQueue.Reverse(k);
                    MessageBox.Show("Queue Reversed successfully.");
                }
            }

        }
    }
}
