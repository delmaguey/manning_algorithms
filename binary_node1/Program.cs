// See https://aka.ms/new-console-template for more information
using System;


BinaryNode<String> root = new BinaryNode<string>("Root");
BinaryNode<String> A = new BinaryNode<string>("A");
BinaryNode<String> B = new BinaryNode<string>("B");
BinaryNode<String> C = new BinaryNode<string>("C");
BinaryNode<String> D = new BinaryNode<string>("D");
BinaryNode<String> E = new BinaryNode<string>("E");
BinaryNode<String> F = new BinaryNode<string>("F");

root.AddLeft(A);
root.AddRight(B);

A.AddLeft(C);
A.AddRight(D);

B.AddRight(E);

E.AddLeft(F);


Console.WriteLine(root);
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(E);
Console.WriteLine(F);

