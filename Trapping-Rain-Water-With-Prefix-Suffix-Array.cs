public class Solution 
{
    public int Trap(int[] height) 
    {
        int max = 0;
        var lmax = new int[height.Length];
        var rmax = new int[height.Length];

        lmax[0] = 0;
        rmax[height.Length - 1] = 0;

        for (int i = 1; i < height.Length; i++)
        {
            max = Math.Max(max, height[i-1]);
            lmax[i] = max;
        }

        max = 0;
        for (int i = height.Length - 2; i >= 0; i--)
        {
            max = Math.Max(max, height[i+1]);
            rmax[i] = max;
        }

        int trappedWater = 0;
        for (int i = 0; i < height.Length; i++)
        {
            var temp = Math.Min(lmax[i], rmax[i]) - height[i];

            if (temp > 0)
            {
                trappedWater += temp;
            }
        }

        return trappedWater;
    }
}
