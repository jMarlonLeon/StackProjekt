using System;

public class Stack
{
    public int[] data;
    private int top;
    private int capacity;
    private int elements;

    public Stack(int length)
    {
        capacity = length;
        data = new int[capacity];
        top = -1;
    }

    public void Push(int value)
    {
        if (top == capacity - 1)
        {
            throw new OverflowException("Stack is full");
        }
        top++;
        data[top] = value;
        elements++;
        Console.WriteLine($"Pushed {value} onto the stack");
    }

    public int Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        int value = data[top];
        top--;
        elements--;
        Console.WriteLine($"Popped {value} from the stack");
        return value;
    }

    public void Init(int length)
    {
        capacity = length;
        data = new int[capacity];
        top = -1;
        elements = 0;
        Console.WriteLine($"Initialized stack with capacity {capacity}");
    }
    public int Capacity

    {
        get { return capacity; }
    }

    public void End()
    {
        Console.WriteLine("Ciao!");
    }

    public void printelements()
    {
        if (elements == 0)
        {
            Console.WriteLine("No elements in Stack!");
        }
        else
        {
            for (int i = 0; i < elements; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
