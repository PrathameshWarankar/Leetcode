public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        int p1 = 0, p2 = numbers.Length - 1;

        while (p1 < p2)
        {
            if (numbers[p1] + numbers[p2] < target)
            {
                p1++;
            }
            else if (numbers[p1] + numbers[p2] > target)
            {
                p2--;
            }
            else
            {
                return [p1 + 1, p2 + 1];
            }
        }

        return [-1, -1];
    }
}
