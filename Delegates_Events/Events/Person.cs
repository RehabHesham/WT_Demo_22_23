using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events.Events
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set;}
        public string PhoneNumber { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
    }
}
