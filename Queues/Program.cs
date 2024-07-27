// See https://aka.ms/new-console-template for more information
using Queues;

Queue queue = new Queue(10);
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);

queue.Dequeue();
queue.Dequeue();

Console.WriteLine(queue.Peek());
Console.ReadLine();