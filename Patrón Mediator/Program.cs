// See https://aka.ms/new-console-template for more information
using Patrón_Mediator;

Console.WriteLine("Hello, World!");

Users robert = new Users("Robert");
Users john = new Users("John");

robert.SendMessage("Hi! John!");
john.SendMessage("Hello! Robert!");