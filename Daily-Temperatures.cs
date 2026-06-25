public class Solution 
{
    public int[] DailyTemperatures(int[] temperatures) 
    {
        var stack = new Stack<int>();
        var result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()])
            {
                var poppedIndex = stack.Pop();
                result[poppedIndex] = i - poppedIndex;
            }

            stack.Push(i);
        }

        return result;
    }
}
