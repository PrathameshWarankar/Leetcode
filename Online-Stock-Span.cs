public class StockSpanner {

    Stack<int> stack;
    Dictionary<int, int> dict;

    public StockSpanner() {
        stack = new Stack<int>();
        dict = new Dictionary<int, int>();
    }
    
    public int Next(int price) {
        int count = 1;
        while (stack.Count > 0 && price >= stack.Peek())
        {
            var poppedVal = stack.Pop();
            count += dict[poppedVal];
        }

        stack.Push(price);
        dict[price] = count;

        return count;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
