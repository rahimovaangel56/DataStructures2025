using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Tree
    {
        public Node Root { get;  set; } //корень дерева
        public Tree()
        {
            Root = null;
        }

        public Node CreateBalancedTree(int nodeCount)
        {
            string text;
            Node root;
            if (nodeCount == 0) //базовый случай для остановки рекурсии
                root = null;
            else
            {
                Console.WriteLine("введите значения узла");
                text = Console.ReadLine();
                root = new Node(text);
                root.Left = CreateBalancedTree(nodeCount /  2);
                root.Right = CreateBalancedTree(nodeCount - nodeCount / 2 - 1); ;
            }

            return root;
        }
        #region ДобавлениеУзла
        private Node AddNodeRecursive(Node node, string text)
        {
            if(node == null) //базовый случай - не встретилось совпадений
                return new Node(text);
            int result = string.Compare(node.Value, text);
            if(result < 0)
                node.Left = AddNodeRecursive(node.Left, text);
            else if( result > 0)
                node.Right = AddNodeRecursive(node.Right, text);

            return node;
        }
        public void AddNode(string text) =>
            AddNodeRecursive(Root, text);
        #endregion

        #region ОбходДереваRLR
        private void TreeTravelsalRecursive(Node node, List<string> results)
        {
            if(node!=null)
            {
                results.Add(node.Value);
                TreeTravelsalRecursive(node.Left, results);
                TreeTravelsalRecursive(node.Right, results);
            }
        }
        public List<string> TreeTraversal()
        {
            List<string> results = new List<string>();
            TreeTravelsalRecursive(Root, results);
            return results;
        }
        #endregion


    }
}
