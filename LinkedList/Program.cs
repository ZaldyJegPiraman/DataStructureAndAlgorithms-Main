// See https://aka.ms/new-console-template for more information
using LinkedList;

Console.WriteLine("Hello, World!");

Node nodeA = new Node();
nodeA.Data = 111;

Node nodeB = new Node();
nodeB.Data = 222;


Node nodeC = new Node();
nodeC.Data = 333;


Node nodeD = new Node();
nodeD.Data = 444;

nodeA.Next= nodeB;
nodeB.Next= nodeC;
nodeC.Next= nodeD;

LinkedList.LinkedList linkedList = new LinkedList.LinkedList();
linkedList.First= nodeA;
linkedList.InsertAnywhere(999, 2);

Console.ReadLine();