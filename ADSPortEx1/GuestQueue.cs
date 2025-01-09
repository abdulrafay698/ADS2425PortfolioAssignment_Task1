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

    class GuestQueue
    {

        // Functions for EX.1A

        private int maxsize = 10;
        private Guest[] store;
        private int head = 0;
        private int tail = 0;
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

        public void Enqueue(Guest value)
        {

            store[tail] = value;
            tail++;
            numItems++;



        }

        public Guest Dequeue()
        {
            Guest temp = store[head];
            head++;
            numItems--;
            return temp;


        }

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
            throw new NotImplementedException();
        }

        public Guest GetMostFunds()
        {
            throw new NotImplementedException();
        }

        // See tasksheet for details for EX.1C



        //Free space, use as necessary to address task requirements... 







    } // End of class
}
