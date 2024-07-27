using System;

BinaryTree tree = new BinaryTree(4);
tree.Root.Left = new TreeNode(2);
tree.Root.Right = new TreeNode(5);
tree.Root.Left.Left = new TreeNode(1);
tree.Root.Left.Right = new TreeNode(3);

Console.WriteLine("In-Order Traversal:");
tree.InOrderTraversal(tree.Root); // Output: 1 2 3 4 5

Console.WriteLine("\nPre-Order Traversal:");
tree.PreOrderTraversal(tree.Root); // Output: 4 2 1 3 5

Console.WriteLine("\nPost-Order Traversal:");
tree.PostOrderTraversal(tree.Root); // Output: 1 3 2 5 4

Console.ReadLine();


public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinaryTree
{
    public TreeNode Root { get; private set; }

    public BinaryTree(int rootValue)
    {
        Root = new TreeNode(rootValue);
    }

    // In-Order Traversal
    public void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;
        InOrderTraversal(node.Left);
        Console.Write(node.Value + " ");
        InOrderTraversal(node.Right);
    }

    // Pre-Order Traversal
    public void PreOrderTraversal(TreeNode node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        PreOrderTraversal(node.Left);
        PreOrderTraversal(node.Right);
    }

    // Post-Order Traversal
    public void PostOrderTraversal(TreeNode node)
    {
        if (node == null) return;
        PostOrderTraversal(node.Left);
        PostOrderTraversal(node.Right);
        Console.Write(node.Value + " ");
    }
}

