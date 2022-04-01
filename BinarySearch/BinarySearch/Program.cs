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
            MyBinaryTree<int> mybinarynode = new MyBinaryTree<int>();
            mybinarynode.insertNode(56);
            mybinarynode.insertNode(30);
            mybinarynode.insertNode(70);
            mybinarynode.insertNode(22);
            mybinarynode.insertNode(40);
            mybinarynode.insertNode(60);
            mybinarynode.insertNode(95);
            mybinarynode.insertNode(11);
            mybinarynode.insertNode(65);
            mybinarynode.insertNode(3);
            mybinarynode.insertNode(16);
            mybinarynode.insertNode(63);
            mybinarynode.insertNode(67);
            mybinarynode.Root();
            mybinarynode.Display(mybinarynode.root);
            Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));
        }
    }
}


