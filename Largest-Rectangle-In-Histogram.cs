public class Solution 
{
    public int LargestRectangleArea(int[] heights) 
    {
        var right = new int[heights.Length];
        Array.Fill(right, heights.Length);

        var left = new int[heights.Length];
        Array.Fill(left, -1);

        var stack = new Stack<int>();

        for (int i = 0; i < heights.Length; i++)
        {
            while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
            {
                right[stack.Peek()] = i;
                stack.Pop();
            }

            stack.Push(i);
        }

        stack.Clear();
        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && heights[stack.Peek()] > heights[i])
            {
                left[stack.Peek()] = i;
                stack.Pop();
            }

            stack.Push(i);
        }

        int max = 0;
        for (int j = 0; j < heights.Length; j++)
        {
            max = Math.Max(max, (right[j] - left[j] - 1) * heights[j]);
        }

        return max;
    }
}
