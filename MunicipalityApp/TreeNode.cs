using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class TreeNode
    {
        // Property to hold the data of the node
        public ServiceRequest Data { get; set; }

        // Property to hold the left child node
        public TreeNode Left { get; set; }

        // Property to hold the right child node
        public TreeNode Right { get; set; }

        // Constructor to initialize the node with a service request
        public TreeNode(ServiceRequest request)
        {
            Data = request;
            Left = null;
            Right = null;
        }
    }
}
