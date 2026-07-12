public class Solution 
{
    public int CharacterReplacement(string s, int k) 
    {
        int left = 0;
        int max = 0;
        var dict = new Dictionary<char, int>();

        for (int right = 0; right < s.Length; right++)
        {
            if (dict.ContainsKey(s[right]))
            {
                dict[s[right]] += 1;
            }
            else
            {
                dict[s[right]] = 1;
            }

            int maxF = GetMaxFreq(dict);

            if ((right - left + 1) - maxF <= k)
            {
                max = Math.Max(max, right - left + 1);
            }
            else
            {
                dict[s[left]] -= 1;
                left += 1;
            }
        }

        return max;
    }

    private int GetMaxFreq(Dictionary<char, int> dict)
    {
        int maxF = 0;

        foreach (var val in dict.Values)
        {
            maxF = Math.Max(maxF, val);
        }

        return maxF;
    }
}
