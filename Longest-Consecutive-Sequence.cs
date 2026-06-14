public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        var dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }

        int max = 0;
        foreach (var ele in nums)
        {
            if(!dict.ContainsKey(ele - 1))
            {
                int i = 1;
                var canRun = true;

                while (canRun)
                {
                    if (dict.ContainsKey(ele + i))
                    {
                        i++;
                    }
                    else
                    {
                        canRun = false;
                    }
                }

                max = Math.Max(i, max);
            }
        }

        return max;
    }
}
