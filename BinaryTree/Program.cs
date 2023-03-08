
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Program
    {
        public static void Visit(BinaryTreeNode radice)
        {

        }
        static void Main(string[] args)
        {
            BinaryTreeNode radice = new BinaryTreeNode("A");
            BinaryTreeNode f1 = new BinaryTreeNode("C");
            radice.ChildDx = f1;
            BinaryTreeNode f2 = new BinaryTreeNode("B");
            radice.ChildSx = f2;
            BinaryTreeNode f3 = new BinaryTreeNode("D");
            f2.ChildSx = f3;

            Visit(radice);
        }
    }
    public class BinaryTreeNode
    { 
        public string Element { get; set; }
        public BinaryTreeNode ChildSx { get; set; }
        public BinaryTreeNode ChildDx { get; set; }

        public BinaryTreeNode(string Element)
        { 
            this.Element = Element;
            ChildSx = ChildDx = null;
        }


    }
}
