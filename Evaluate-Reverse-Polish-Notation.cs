public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        var stack = new Stack<int>();
        int val1, val2, ans;

        foreach (var token in tokens)
        {
            switch (token)
            {
                case "+":
                    val1 = stack.Pop();
                    val2 = stack.Pop();

                    ans = val2 + val1;
                    stack.Push(ans);
                    break;
                case "-":
                    val1 = stack.Pop();
                    val2 = stack.Pop();

                    ans = val2 - val1;
                    stack.Push(ans);
                    break;
                case "*":
                    val1 = stack.Pop();
                    val2 = stack.Pop();

                    ans = val2 * val1;
                    stack.Push(ans);
                    break;
                case "/":
                    val1 = stack.Pop();
                    val2 = stack.Pop();

                    ans = val2 / val1;
                    stack.Push(ans);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Peek();
    }
}
