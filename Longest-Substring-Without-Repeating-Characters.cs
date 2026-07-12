public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int left = 0;
        var dict = new Dictionary<char, int>();
        int max = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (dict.ContainsKey(s[right]))
            {
                dict.Remove(s[left]);
                left++;
            }

            dict[s[right]] = 1;
            max = Math.Max(max, right-left+1);
        }

        return max;
    }
}
