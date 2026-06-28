public class Solution 
{
    public string DecodeString(string s) 
    {
        var numberStack = new Stack<int>();
        var stack = new Stack<string>();
        var number = string.Empty;
        var str = new StringBuilder();

        foreach (var ele in s)
        {
            if (char.IsDigit(ele))
            {
                number += ele;
            }
            else if (ele == '[')
            {
                numberStack.Push(int.Parse(number));
                stack.Push(str.ToString());
                number = string.Empty;
                str.Clear();
            }
            else if (ele == ']')
            {
                var pop = numberStack.Pop();
                var temp = new StringBuilder(stack.Pop());

                for (int i = 0; i < pop; i++)
                {
                    temp.Append(str);
                }

                str = temp;
            }
            else
            {
                str.Append(ele);
            }
        }

        return str.ToString();
    }
}
