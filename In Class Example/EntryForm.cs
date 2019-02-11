using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace In_Class_Example
{
    class EntryForm
    {
        public string Name { get; set; }        //if private, then no get set. Just semicolon 

        public string Address { get; set; }

        public int Zip { get; set; }

        //constructor= no return type and matches name as class

        public EntryForm()
        {
            Name = "";
            Address = string.Empty;
            Zip = 0;
        }

        public EntryForm(string name, string address, int zip)           //overloaded constructor; already have name entry form 
        {
            Name = name;
            Address = address;
            Zip = zip;
        }

        public override string ToString()
        {
            string entryForm = $"{Name} lives at {Address} {Zip}";
            return entryForm;
        }
    }


}
