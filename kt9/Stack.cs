class Stack<T> where T : IComparable<T>
{
    List<T> stack = new List<T>();
    public void Push(T item)
    {
        stack.Add(item);
    }
    public void Pop(T item)
    {
        if(stack.Count <= 0)
        {
            throw new InvalidOperationException("Стек пуст");
        }
        int lastindex = stack.Count - 1;
        if (lastindex >= 0)
        {
            stack.RemoveAt(lastindex);
        }
    }
    public T Max()
    {
        T max = stack[0];
        foreach(T item in stack)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
}
