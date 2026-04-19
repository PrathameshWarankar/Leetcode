public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.Keys.Contains(nums[i]))
            {
                dict[nums[i]] += 1;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }

        foreach (var (key, value) in dict)
        {
            if (value > 1)
            {
                return true;
            }
        }

        return false;
    }
}
