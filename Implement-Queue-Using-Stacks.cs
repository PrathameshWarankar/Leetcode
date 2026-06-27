public class MyQueue {

    Stack<int> mainStack;
    Stack<int> bufferStack;

    public MyQueue() {
        mainStack = new Stack<int>();
        bufferStack = new Stack<int>();
    }
    
    public void Push(int x) {
        while (mainStack.Count > 0)
        {
            bufferStack.Push(mainStack.Pop());
        }

        mainStack.Push(x);

        while (bufferStack.Count > 0)
        {
            mainStack.Push(bufferStack.Pop());
        }
    }
    
    public int Pop() {
        return mainStack.Pop();
    }
    
    public int Peek() {
        return mainStack.Peek();
    }
    
    public bool Empty() {
        return mainStack.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
