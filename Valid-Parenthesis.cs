public class Solution 
{
    public bool IsValid(string s) 
    {
        if (s.Length % 2 != 0) 
        {
            return false;
        }

        var stack = new Stack<int>();

        foreach (char c in s) 
        {
            if (c == ')' || c == '}' || c == ']') 
            {
                if (stack.TryPop(out var value)) 
                {
                    if (value == '(' && c == ')' || value == '{' && c == '}' ||
                        value == '[' && c == ']') 
                    {
                        continue;
                    }

                    return false;
                } 
                else 
                {
                    return false;
                }
            } 
            else 
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
