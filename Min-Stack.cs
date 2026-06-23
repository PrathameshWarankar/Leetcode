public class MinStack {
    int min = int.MaxValue;
    Stack<int> minStack, getMin;

    public MinStack() {
        minStack = new Stack<int>();
        getMin = new Stack<int>();
    }
    
    public void Push(int val) {

        if (val <= min)
        {
            min = val;
            getMin.Push(val);
        }

        minStack.Push(val);
    }
    
    public void Pop() {
        var poppedVal = minStack.Pop();

        if (poppedVal == min)
        {
            getMin.Pop();

            if (getMin.TryPeek(out var value))
            {
                min = value;
            }
            else
            {
                min = int.MaxValue;
            }
        }
    }
    
    public int Top() {
        return minStack.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}
