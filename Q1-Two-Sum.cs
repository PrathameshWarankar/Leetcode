public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i <= nums.Length -1; i++)
        {
            var diff = target - nums[i];

            if(dict.Keys.Contains(diff))
            {
                return new int[] {dict[diff], i};
            }
            else 
            {
                dict[nums[i]] = i;
            }
        }

        return new int[] {-1, -1};
    }
}
