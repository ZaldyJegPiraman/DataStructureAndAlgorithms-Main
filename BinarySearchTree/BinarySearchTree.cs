using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BinarySearchTree
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; set; } = null;
        public void Insert(int key, string value)
        {
            Root = InsertItem(Root,key, value);
        }


        public TreeNode InsertItem(TreeNode node, int key, string value)
        {
            TreeNode newNode = new TreeNode(key, value);

            // IF THIS IS THE FIRST TIME YOU INSERT, CREATE THE ROOT
            if(node == null)
            {
                node = newNode;
                return node;
            }

            //IF THIS INST THE FIRST INSERT, TRAVERSE, FIND NULL, INSERT
            if(key < node.Key)
            {
                node.LeftChild = InsertItem(node.LeftChild, key, value);
            }
            else {
                node.RightChild = InsertItem(node.RightChild, key, value);
            }

            return node;
        }


        public string Find(int key)
        {
            TreeNode node = Find(Root, key);
            return node == null ? null : node.Value;
        }

        private TreeNode? Find(TreeNode node, int key)
        {
            if(node == null || node.Key == key) {
                return node;
            }
            else if(key < node.Key)
            {
                return Find(node.LeftChild, key);
            }
            else if(key > node.Key)
            {
                return Find(node.RightChild, key);  
            }
            return null;
        }

    }
}
