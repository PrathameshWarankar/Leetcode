public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var alphaArr = new int[26];
        var dict = new Dictionary<string, List<string>>();
        var result = new List<List<string>>();
        var key = string.Empty;
        for (int i = 0; i < strs.Length; i++)
        {
            Array.Clear(alphaArr, 0, alphaArr.Length);
            foreach (var c in strs[i])
            {
                alphaArr[c - 'a'] += 1;
            }
            
            key = string.Join(',', alphaArr);

            if (dict.Keys.Contains(key))
            {
                dict[key].Add(strs[i]);
            }
            else
            {
                dict[key] = new List<string>() {strs[i]};
            }
        }

        result = dict.Values.ToList();

        return result;
    }
}
