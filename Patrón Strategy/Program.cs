// See https://aka.ms/new-console-template for more information
using Patrón_Strategy;

Console.WriteLine("Hello, World!");
SortContext context;

context = new SortContext(new BubbleSort());
context.Sort(new int[] { 1, 2, 3, 4, 5 });

context = new SortContext(new QuickSort());
context.Sort(new int[] { 1, 2, 3, 4, 5 });