public class Solution 
{
    public int FindMin(int[] nums) 
    {
        int p1 = 0;
        int p2 = nums.Length - 1;
        int ans = int.MaxValue;

        while (p1 <= p2)
        {
            int mid = ((p2-p1)/2) + p1;
            ans = Math.Min(ans, nums[mid]);

            if (nums[mid] < nums[p2])
            {
                p2 = mid - 1;
            }
            else
            {
                p1 = mid + 1;
            }
        }

        return ans;
    }
}
