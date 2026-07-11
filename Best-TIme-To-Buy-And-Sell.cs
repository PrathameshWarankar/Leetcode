public class Solution 
{
    public int MaxProfit(int[] prices) 
    {
        int left = 0;
        int right = 1;
        int ans = 0;

        while (right < prices.Length)
        {
            if (prices[left] < prices[right])
            {
                ans = Math.Max(ans, prices[right] - prices[left]);
            }
            else
            {
                left = right;
            }

            right++;
        }

        return ans;
    }
}
