using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT_Demo_Day2
{
    internal class Stack_imp
    {
        private int tos;
        private int[] arr;

        public Stack_imp(int size = 5)
        {
            tos = -1;
            arr = new int[size];
        }

        public void Push(int val)
        {
            if (tos == arr.Length - 1) throw new InvalidOperationException("Stack is Full");
            tos++;
            arr[tos] = val;
        }

        public int Pop()
        {
            if (tos == -1) throw new InvalidOperationException("Stach is empty");
            int val = arr[tos];
            tos--;
            return val;
        }
    }
    internal class Stack_string
    {
        private int tos;
        private string[] arr;

        public Stack_string(int size = 5)
        {
            tos = -1;
            arr = new string[size];
        }

        public void Push(string val)
        {
            if (tos == arr.Length - 1) throw new InvalidOperationException("Stack is Full");
            tos++;
            arr[tos] = val;
        }

        public string Pop()
        {
            if (tos == -1) throw new InvalidOperationException("Stach is empty");
            string val = arr[tos];
            tos--;
            return val;
        }
    }
}
