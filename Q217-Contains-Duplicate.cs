public class Solution 
{
    public bool hasDuplicate(int[] nums) 
    {
        var dict = new Dictionary<int, int>();

        foreach (var i in nums)
        {
            if (dict.Keys.Contains(i))
            {
                return true;
            }
            else
            {
                dict[i] = 1;
            }
        }

        return false;
    }
}
