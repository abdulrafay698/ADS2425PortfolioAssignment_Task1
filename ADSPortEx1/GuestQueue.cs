using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{
    //Queue implementation for Assessed Exercise 1

    //Hints : 
    //Use lecture materials from Week 2A
    // and lab sheet 'Lab 2 (second part): Stacks and Queues' to aid with implementation...

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //Don't forget to properly commit and document your work! 
    // Commit fairly frequently with proper descriptions, i.e. commit after implementing the enqueue function...
    
    //Lastly, don't forget about implementing your UI in 'Form1.cs' too!
    // See lab material from week 1 to aid with this...

    // - Adam.M 

    public class GuestQueue
    {

        // Functions for EX.1A

        private int maxsize = 10;
        private Guest[] store;
        private int head = 0;
        private int tail = -1;
        private int numItems = 0; // current number of items 

        public GuestQueue()
        {
            store = new Guest[maxsize];
        }

        public GuestQueue(int size)
        {
            this.maxsize = size;
            store = new Guest[maxsize];
        }

        //public void Enqueue(Guest value)
        //{

        //    store[tail] = value;
        //    tail++;
        //    numItems++;



        //}

        //public Guest Dequeue()
        //{
        //    Guest temp = store[head];
        //    head++;
        //    numItems--;
        //    return temp;


        //}

        public Guest Peek()
        {

            return store[head];
        }

        public int Count()
        {

            return numItems;
        }

        public bool IsEmpty()
        {

            return numItems == 0;
        }

        public bool IsFull()
        {
            return numItems == maxsize;
        }


        // Functions for EX.1B

        public void Reverse(int k)
        {
            if (k <= 0 || k > numItems)
            {
                Console.WriteLine("Invalid value for k.");
                return;
            }

            int[] indices = new int[k];
            for (int i = 0; i < k; i++)
            {
                indices[i] = (head + i) % maxsize;
            }

            for (int i = 0; i < k / 2; i++)
            {
                var temp = store[indices[i]];
                store[indices[i]] = store[indices[k - i - 1]];
                store[indices[k - i - 1]] = temp;
            }

        }

        public Guest GetMostFunds()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty!");
                return null;
            }

            Guest maxGuest = store[head];
            for (int i = 1; i < numItems; i++)
            {
                int index = (head + i) % maxsize;
                if (store[index].Funds > maxGuest.Funds)
                {
                    maxGuest = store[index];
                }
            }



            return maxGuest;
        }

        // See tasksheet for details for EX.1C


        public void Enqueue(Guest value)
        {


            if (IsFull())
            {
                Console.WriteLine("Queue full, Cannot add more guests.");
                return;
            }
            tail = (tail + 1) % maxsize;
            store[tail] = value;
            numItems++;
        }

        public Guest Dequeue()
        {
            

            if (IsEmpty())
            {
                Console.WriteLine("Queue empty, No guests to remove.");
                return null;
            }

            Guest temp = store[head];
            head = (head + 1) % maxsize;
            numItems--;
            return temp;
        }


        //Free space, use as necessary to address task requirements... 


        public List<Guest> GetAllGuests()
        {
            List<Guest> guests = new List<Guest>();
            for (int i = 0; i < numItems; i++) // 'size' keeps track of the current number of elements
            {
                int index = (head + i) % maxsize; // Circular queue logic to calculate the correct index
                guests.Add(store[index]);
            }
            return guests;
        }




    } // End of class
}
