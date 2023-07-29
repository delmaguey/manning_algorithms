// See https://aka.ms/new-console-template for more information

NaryNode<string> root = new NaryNode<string>("Root");
NaryNode<string> A = new NaryNode<string>("A");
NaryNode<string> B = new NaryNode<string>("B");
NaryNode<string> C = new NaryNode<string>("C");
NaryNode<string> D = new NaryNode<string>("D");
NaryNode<string> E = new NaryNode<string>("E");
NaryNode<string> F = new NaryNode<string>("F");
NaryNode<string> G = new NaryNode<string>("G");
NaryNode<string> H = new NaryNode<string>("H");
NaryNode<string> I = new NaryNode<string>("I");


root.AddChild(A);
root.AddChild(B);
root.AddChild(C);

A.AddChild(D);
A.AddChild(E);

C.AddChild(F);

D.AddChild(G);

F.AddChild(H);
F.AddChild(I);


Console.WriteLine(root);
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(C);
Console.WriteLine(D);
Console.WriteLine(E);
Console.WriteLine(F);
Console.WriteLine(G);
Console.WriteLine(H);
Console.WriteLine(I);

