using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Binary search tree problem ");
            DisplayBinary();
            Console.ReadLine();
        }

        public static void DisplayBinary()
        {
            MyBinaryTree<int> tree = new MyBinaryTree<int>();
            tree.insertNode(56);
            tree.insertNode(30);
            tree.insertNode(70);
            Console.WriteLine("Display Nodes ");
            tree.Display();
        }
    }

}
