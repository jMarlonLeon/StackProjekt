using System;

namespace MyStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack(0);

            Console.Write("Enter stack size: ");
            string? sizeInput = Console.ReadLine();
            int size = int.Parse(sizeInput!);

            if (size == 0)
            {
                Console.WriteLine("Cannot initialize Stack with length '0'");
                size = 1;
                Console.WriteLine("Set default Stack length to 1");
            }
            myStack = new Stack(size);

            while (true)
            {
                Console.Write("Enter a command (push, pop, end): ");
                string? input = Console.ReadLine()?.Trim();

                if (input == "end")
                {
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else if (input == "push")
                {
                    Console.Write("Enter a value to push: ");
                    string? valueInput = Console.ReadLine()?.Trim();

                    if (int.TryParse(valueInput, out int value))
                    {
                        myStack.Push(value);
                        Console.WriteLine($"Value {value} pushed to the stack.");
                        Console.WriteLine("Elements in stack:");
                        myStack.printelements();
                    }
                    else
                    {
                        Console.WriteLine($"Invalid value: {valueInput}. Please enter an integer value.");
                    }
                }
                else if (input == "pop")
                {
                    if (myStack.Capacity > 0)
                    {
                        int value = myStack.Pop();
                        Console.WriteLine($"Value {value} popped from the stack.");
                    }
                    else
                    {
                        Console.WriteLine("Stack is empty.");
                    }
                }
                else if (input == "end")
                {
                    myStack.End();
                }
                else if (input == "print")
                {
                    Console.WriteLine("printing Elements in Stack:");
                    myStack.printelements();
                }
                else
                {
                    Console.WriteLine("Invalid command. Please enter push, pop, or end.");
                }
            }
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}
