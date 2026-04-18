public class Solution 
{
    public int RemoveDuplicates(int[] nums) 
    {
        var dict = new Dictionary<int, int>();
        var index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.Keys.Contains(nums[i]))
            {
                dict[nums[i]] = 1;
                nums[index] = nums[i];
                index += 1;
            }
        }

        return index;
    }
}
