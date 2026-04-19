public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        var index = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[index] = nums[i];
                index += 1;
            }
        }

        var remaining = nums.Length - index;

        var j = nums.Length - 1;

        while (remaining > 0)
        {
            nums[j] = 0;
            remaining -= 1;
            j -= 1;
        }
    }
}
