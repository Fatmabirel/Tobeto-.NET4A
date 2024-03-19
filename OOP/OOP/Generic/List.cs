using System;

public class MyList<T>
{
    private T[] items;
    private int count;

    public MyList(int capacity)
    {
        items = new T[capacity];
        count = 0;
    }

    public void Add(T item)
    {
        if (count == items.Length)
        {
            Console.WriteLine("List is full. Cannot add more items.");
            return;
        }

        items[count++] = item;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
        {
            Console.WriteLine("Invalid index.");
            return default(T);
        }

        return items[index];
    }

    public int Count()
    {
        return count;
    }
}
