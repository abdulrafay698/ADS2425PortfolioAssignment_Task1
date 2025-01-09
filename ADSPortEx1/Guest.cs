using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx1
{

    //Guest class implementation for use with 
    // GuestQueue structure

    //Do not delete the current function definitions, just replace the exceptions with the required functionality...

    //See material from 'C# Classes' in week 2 to 
    // aid with implementation...

    public class Guest : IComparable
    {

        private string name;
        private double funds; 

        public Guest(string name, double funds)
        {
            this.name = name;  
            this.funds = funds; 
        }

        public string Name
        {
            get {  return name ; }
            set { name = value ; }
        }

        public double Funds
        {
            get { return funds; }
            set { funds = value; }
        }

        public int CompareTo(object obj)
        {
            Guest other = (Guest)obj;
            return name.CompareTo(other.name);
        }


    }// End of class...
}
