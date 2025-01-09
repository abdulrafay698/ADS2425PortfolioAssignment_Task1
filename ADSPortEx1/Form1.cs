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
    public partial class Form1 : Form
    {
        private GuestQueue guestQueue = null ;
        public Form1()
        {
            InitializeComponent();
            guestQueue = new GuestQueue();
        }

        // add a guest 
        private void button1_Click(object sender, EventArgs e)
        {
            EnqueueForm f2 = new EnqueueForm(ref guestQueue);
            f2.Show();

         

        }

        // Dequeue Guest 
        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        // revevr e k times 
        private void button4_Click(object sender, EventArgs e)
        {

        }


        // Display count 
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Number of guests : " + guestQueue.Count().ToString());
        }

        // peek 
        private void button6_Click(object sender, EventArgs e)
        {
            // Check if guestQueue is properly initialized
            if (guestQueue == null)
            {
                MessageBox.Show("Guest queue is not initialized!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the queue is not empty
            if (!guestQueue.IsEmpty())
            {
                // Peek at the first guest
                Guest guest = guestQueue.Peek();

                if ( guest != null)
                {
                    MessageBox.Show("Name: " + guestQueue.Peek().Name + " Funds: " + guestQueue.Peek().Funds, "Details");
                }
                else
                {
                    MessageBox.Show("No guest details available.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Queue is empty!", "Error");
            }
        }


        // IS full () 
        private void button7_Click(object sender, EventArgs e)
        {

        }

        // is empty () 
        private void button8_Click(object sender, EventArgs e)
        {

        }

        // display guest with most funds 
        private void button9_Click(object sender, EventArgs e)
        {
            Guest guest = null;
            if (!guestQueue.IsEmpty())
            {
                guest = guestQueue.GetMostFunds();

                MessageBox.Show("Name : " + guest.Name + " Funds : " + guest.Funds, "Details");
            }
            else
            {
                MessageBox.Show("Queue is empty!");
            }
        }


        // print all guest 
        private void button3_Click(object sender, EventArgs e)
        {
            //if (guestQueue == null)
            //{
            //    MessageBox.Show("Queue is null.", "Error");
            //    return;  // Exit the method to avoid further processing
            //}

            //if (!guestQueue.IsEmpty())
            //{
            //    // Build a string with all guest details
            //    string allGuests = "Guests in Queue:\n";

            //    // Make sure GetAllGuests() returns a valid collection
            //    var allGuestsList = guestQueue.GetAllGuests();
            //    if (allGuestsList != null)
            //    {
            //        foreach (Guest guest in allGuestsList)
            //        {
            //            allGuests += $"Name: {guest.Name}, Funds: {guest.Funds}\n";
            //        }

            //        MessageBox.Show(allGuests, "Queue Details");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Failed to retrieve guests.", "Error");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Queue is empty!", "Queue Details");
            //}
        }


    }
}
