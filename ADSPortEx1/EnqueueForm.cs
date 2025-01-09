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
    public partial class EnqueueForm : Form
    {

        private GuestQueue guestQueue;
        public EnqueueForm(ref GuestQueue other)
        {
            InitializeComponent();
            this.guestQueue = other;
        }

        // funds input 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // name input 
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        // Enqueue action 
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Empty box, please provide input.");
            }

            if (guestQueue.IsFull())
            {
                MessageBox.Show("Queue is full, cannot add more guests.", "Error");
                return;
            }

            string name = textBox2.Text;
            string fundsInput = textBox1.Text;

            if (double.TryParse(fundsInput, out double funds))
            {
                guestQueue.Enqueue(new Guest(name, funds));
                MessageBox.Show("Guest added successfully.");
            }

        }

    }
}
