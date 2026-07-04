public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int p1 = 0;
        int p2 = nums.Length - 1;

        while (p1 <= p2)
        {
            var mid = ((p2 - p1)/2) + p1;

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] > target)
            {
                p2 = mid - 1;
            }
            else
            {
                p1 = mid + 1;
            }
        }

        return -1;
    }
}
