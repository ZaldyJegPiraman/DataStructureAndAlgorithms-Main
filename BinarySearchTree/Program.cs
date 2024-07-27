
using BinarySearchTree;

BinarySearchTree.BinarySearchTree bst = new BinarySearchTree.BinarySearchTree();
bst.Insert(7, "Squirtle");
bst.Insert(8, "Ekans");
bst.Insert(151, "Mew");
bst.Insert(4, "Charmander");
bst.Insert(1, "Balbasaur");


Console.WriteLine(bst.Find(151).ToString());

Console.ReadLine(); 
