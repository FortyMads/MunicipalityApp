using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class AVLTree<T> where T : IComparable<T>
    {
        private Node root; // Root node of the AVL tree

        // Insert a new value into the AVL tree
        public void Insert(T value)
        {
            root = Insert(root, value);
        }

        // Search for a value with a specific ID (assuming T has an ID property)
        public T Search(int id)
        {
            return Search(root, id);
        }

        // Internal insert method with balancing logic
        private Node Insert(Node node, T value)
        {
            if (node == null)
            {
                return new Node(value); // Create a new node if the current node is null
            }

            int comparison = value.CompareTo(node.Value);
            if (comparison < 0)
            {
                node.Left = Insert(node.Left, value); // Insert in the left subtree
            }
            else if (comparison > 0)
            {
                node.Right = Insert(node.Right, value); // Insert in the right subtree
            }
            else
            {
                // Duplicate values are not allowed
                return node;
            }

            // Update height of this ancestor node
            node.Height = Math.Max(GetHeight(node.Left), GetHeight(node.Right)) + 1;

            // Check if this node became unbalanced
            int balance = GetBalance(node);

            // If the node is unbalanced, then there are four cases

            // Left Left Case
            if (balance > 1 && value.CompareTo(node.Left.Value) < 0)
            {
                return RightRotate(node);
            }

            // Right Right Case
            if (balance < -1 && value.CompareTo(node.Right.Value) > 0)
            {
                return LeftRotate(node);
            }

            // Left Right Case
            if (balance > 1 && value.CompareTo(node.Left.Value) > 0)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && value.CompareTo(node.Right.Value) < 0)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node; // Return the (potentially new) root node
        }

        // Search for a value with a specific ID in the tree
        private T Search(Node node, int id)
        {
            if (node == null)
                return default(T); // Return default value if node is null

            if (((ServiceRequest)(object)node.Value).RequestID == id)
            {
                return node.Value; // Return the value if the ID matches
            }
            else if (id < ((ServiceRequest)(object)node.Value).RequestID)
            {
                return Search(node.Left, id); // Search in the left subtree
            }
            else
            {
                return Search(node.Right, id); // Search in the right subtree
            }
        }

        // Right rotate subtree rooted with y
        private Node RightRotate(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            // Return the new root
            return x;
        }

        // Left rotate subtree rooted with x
        private Node LeftRotate(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            // Return the new root
            return y;
        }

        // Get the height of a node
        private int GetHeight(Node node)
        {
            if (node == null)
                return 0; // Height is 0 if node is null
            return node.Height;
        }

        // Get the balance factor of a node
        private int GetBalance(Node node)
        {
            if (node == null)
                return 0; // Balance is 0 if node is null
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        // Node class to represent each element in the AVL tree
        private class Node
        {
            public T Value { get; set; } // Value of the node
            public Node Left { get; set; } // Left child
            public Node Right { get; set; } // Right child
            public int Height { get; set; } // Height of the node

            public Node(T value)
            {
                Value = value;
                Left = Right = null;
                Height = 1; // Starting height
            }
        }
    }

}
