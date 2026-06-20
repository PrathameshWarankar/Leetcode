public class Solution 
{
    public int Trap(int[] height) 
    {
        int lmax = 0, rmax = 0;
        int l = 0;
        int r = height.Length - 1;
        int water = 0;

        while (l < r)
        {
            lmax = Math.Max(lmax, height[l]);
            rmax = Math.Max(rmax, height[r]);

            if (height[l] < height[r])
            {
                water += lmax - height[l];
                l += 1;
            }
            else
            {
                water += rmax - height[r];
                r -= 1;
            }
        }

        return water;
    }
}
