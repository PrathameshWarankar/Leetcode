public class Solution 
{
    public bool IsAnagram(string s, string t) 
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var alphaArr = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            alphaArr[s[i] - 'a'] += 1;
            alphaArr[t[i] - 'a'] -= 1;
        }

        foreach (var j in alphaArr)
        {
            if (j != 0)
            {
                return false;
            }
        }

        return true;
    }
}
