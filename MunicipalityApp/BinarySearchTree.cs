using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class BinarySearchTree
    {
        // Property to hold the root node of the binary search tree
        public TreeNode Root { get; set; }

        // Method to insert a new service request into the binary search tree
        public void Insert(ServiceRequest request)
        {
            Root = InsertRec(Root, request);
        }

        // Recursive helper method to insert a new service request into the binary search tree
        private TreeNode InsertRec(TreeNode root, ServiceRequest request)
        {
            // If the current node is null, create a new node with the service request
            if (root == null) return new TreeNode(request);

            // If the request ID is less than the current node's request ID, insert into the left subtree
            if (request.RequestID < root.Data.RequestID)
                root.Left = InsertRec(root.Left, request);
            // If the request ID is greater than the current node's request ID, insert into the right subtree
            else if (request.RequestID > root.Data.RequestID)
                root.Right = InsertRec(root.Right, request);

            // Return the current node
            return root;
        }

        // Method to search for a service request by its request ID
        public ServiceRequest Search(int requestId)
        {
            return SearchRec(Root, requestId)?.Data;
        }

        // Recursive helper method to search for a service request by its request ID
        private TreeNode SearchRec(TreeNode root, int requestId)
        {
            // If the current node is null or the request ID matches the current node's request ID, return the current node
            if (root == null || root.Data.RequestID == requestId)
                return root;

            // If the request ID is less than the current node's request ID, search in the left subtree
            if (requestId < root.Data.RequestID)
                return SearchRec(root.Left, requestId);
            // If the request ID is greater than the current node's request ID, search in the right subtree
            else
                return SearchRec(root.Right, requestId);
        }
    }
}
