// See https://aka.ms/new-console-template for more information
using Patron_Composite;

Console.WriteLine("Hello, World!");
Composite composite = new Composite();
composite.Add(new Leaf());
composite.Add(new Leaf());
composite.Operation();