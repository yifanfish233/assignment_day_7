namespace Assignment4;

using System;
using System.Collections.Generic;

public class MyStack<T>
{
    private List<T> elements;

    public MyStack()
    {
        elements = new List<T>();
    }
    public int Count()
    {
        return elements.Count;
    }
    public T Pop()
    {
        if (elements.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        T value = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return value;
    }
    
    public void Push(T item)
    {
        elements.Add(item);
    }
}
