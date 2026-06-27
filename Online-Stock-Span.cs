public class StockSpanner 
{
    Stack<int[]> stack;

    public StockSpanner() 
    {
        stack = new Stack<int[]>();
    }
    
    public int Next(int price) {
        int count = 1;
        while (stack.Count > 0 && price >= stack.Peek()[0])
        {
            count += stack.Pop()[1];
        }

        stack.Push([price, count]);

        return count;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */
