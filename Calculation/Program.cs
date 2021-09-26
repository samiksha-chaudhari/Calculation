using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculation");
            oprations op = new oprations();
            op.Add(3, 5);
            op.Sub(8, 2);
        }
    }
}
