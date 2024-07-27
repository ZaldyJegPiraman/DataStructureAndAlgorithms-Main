// See https://aka.ms/new-console-template for more information

using Stack;
using System;
using System.Collections.Generic;


StackADT<int> stack = new StackADT<int>();

stack.Push(10);
stack.Push(20);
Console.WriteLine(stack.Peek());  // Output: 20
stack.Pop();
Console.WriteLine(stack.Peek());  // Output: 10