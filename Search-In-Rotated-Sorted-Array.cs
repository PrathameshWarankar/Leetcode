public class Solution 
{
    public int Search(int[] nums, int target) 
    {
        int p1 = 0;
        int p2 = nums.Length - 1;

        while (p1 <= p2)
        {
            int mid = p1 + (p2-p1)/2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > nums[p2])
            {
                if (nums[p1] <= target && nums[mid] > target)
                {
                    p2 = mid - 1;
                }
                else
                {
                    p1 = mid + 1;
                }
            }
            else
            {
                if (nums[mid] < target && nums[p2] >= target)
                {
                    p1 = mid + 1;
                }
                else
                {
                    p2 = mid - 1;
                }
            }
        }

        return -1;
    }
}
