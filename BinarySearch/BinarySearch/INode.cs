﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class INode<T>
    {
        public T data;
        public INode<T> leftTree;
        public INode<T> rightTree;
        public INode(T data)
        {
            this.data = data;
            leftTree = null;
            rightTree = null;
        }
    }
}