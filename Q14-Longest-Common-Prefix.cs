public class Solution 
{
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        if (string.IsNullOrEmpty(strs[0]))
        {
            return string.Empty;
        }

        Array.Sort(strs);
        var firstEle = strs[0];
        var longestCommonPrefix = string.Empty;

        for (int i = 0; i < firstEle.Length; i++)
        {
            if (firstEle[i] == strs[strs.Length - 1][i])
            {
                longestCommonPrefix = firstEle.Substring(0, i + 1);
            }
            else
            {
                break;
            }
        }

        return longestCommonPrefix;
    }
}
