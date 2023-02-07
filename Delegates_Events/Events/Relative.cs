using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events.Events
{
    internal class Relative : Person
    {
        public Relative(string name) : base(name) { }
        
        public void GetNotifed(DateTime WeddingDate,string groomName)
        {
            Console.WriteLine($"{Name} have been invented to {groomName}'s Wedding at {WeddingDate}");
        }
    }
}
