public class Solution 
{
    public int MaxArea(int[] heights) 
    {
        int max = 0;
        int p1 = 0;
        int p2 = heights.Length - 1;

        while (p1 < p2)
        {
            if (heights[p1] > heights[p2])
            {
                max = Math.Max(max, (heights[p2] * (p2 - p1)));
                p2 -= 1;
            }
            else
            {
                max = Math.Max(max, (heights[p1] * (p2 - p1)));
                p1 += 1;
            }
        }

        return max;
    }
}
