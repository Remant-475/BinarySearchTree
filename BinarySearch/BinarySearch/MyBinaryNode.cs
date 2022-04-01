using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class MyBinaryTree<T> where T : IComparable
    {
        public INode<T> root;

        public void insertNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parent = root;
                INode<T> current = root;
                while (true)
                {
                    parent = current;
                    if (current.data.CompareTo(value) >= 0)
                    {
                        current = current.leftTree;
                        if (current == null)
                        {
                            parent.leftTree = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightTree;
                        if (current == null)
                        {
                            parent.rightTree = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Display Root Node.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }

        /// Displays Nodes in BST
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.leftTree);
                Display(parent.rightTree);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }

        private void Display(object right)
        {
            throw new NotImplementedException();
        }

        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return Size(root.leftTree) + 1 + Size(root.rightTree);
        }

    }
}