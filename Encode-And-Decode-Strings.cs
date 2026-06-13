public class Solution {

    public string Encode(IList<string> strs) 
    {
        var sb = new StringBuilder();
        foreach (var str in strs)
        {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
        int index = 0;
        var result = new List<string>();

        while (index < s.Length)
        {
            int pointer = 0;

            while (s[index + pointer] != '#')
            {
                pointer += 1;
            }

            var length = int.Parse(s.Substring(index, pointer));

            var word = s.Substring(index + pointer + 1, length);

            result.Add(word);

            index = index + pointer + length + 1;
        }

        return result;
    }
}
