using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            var listNode = new ListNode<int>(10) { 20, 1000, 40 };
            int[] arr = listNode.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
