public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
    {
        var result = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            int p1 = i + 1;
            int p2 = nums.Length - 1;

            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            while (p1 < p2)
            {
                if (nums[i] + nums[p1] + nums[p2] > 0)
                {
                    p2 -= 1;
                }
                else if (nums[i] + nums[p1] + nums[p2] < 0)
                {
                    p1 += 1;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[p1], nums[p2] });

                    while (p1 < p2 && nums[p1] == nums[p1 + 1])
                    {
                        p1++;
                    }

                    while (p1 < p2 && nums[p2] == nums[p2 - 1])
                    {
                        p2--;
                    }

                    p1++;
                    p2--;
                }
            }
        }

        return result;
    }
}
