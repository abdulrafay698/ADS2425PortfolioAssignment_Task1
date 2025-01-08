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

    class Guest : IComparable
    {

        public Guest(string name, double funds)
        {
            throw new NotImplementedException();
        }

        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public double Funds
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }


    }// End of class...
}
