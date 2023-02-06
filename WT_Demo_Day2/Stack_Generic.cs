using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT_Demo_Day2
{
    internal class Stack_Generic<Dt>
    {
        private int tos;
       // private Dt[] arr;
       private List<Dt> list;
        public Stack_Generic(int size = 3)
        {
            //arr = new Dt[size];
            list = new List<Dt>();
            tos = -1;
        }

        public void Push(Dt val)
        {
            
            //if (tos == arr.Length - 1) throw new InvalidOperationException("Stack is full");
            tos++;
            //arr[tos] = val;
            list.Add(val);
        }

        public Dt Pop()
        {
            //if (false) return 1;
            if (tos == -1) throw new InvalidOperationException("Stack is empty");
           // Dt val = arr[tos];
           Dt val = list[tos];
            list.RemoveAt(tos);
            tos--;
            return val;
        }
    }
}
