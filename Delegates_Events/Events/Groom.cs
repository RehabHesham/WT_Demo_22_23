using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Events.Events
{
    internal class Groom : Person
    {
        //public delegate void WeddingInvetation(DateTime WeddingDate,string name);
        //public event WeddingInvetation Wedding;

        public event Action<DateTime, string> Wedding;
        public Groom(string name) : base(name) { }

        public void SendInventations(DateTime dateTime)
        {
            Console.WriteLine($"\n\n{Name} is sending Notifications");
            if (Wedding != null)
            {
                Wedding(dateTime,Name);
            }
        }
    }
}
