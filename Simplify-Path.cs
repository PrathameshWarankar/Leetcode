public class Solution {
    public string SimplifyPath(string path) {
        var stack = new Stack<string>();

        var splittedPath = path.Split("/");

        var output = new StringBuilder();

        foreach (var ele in splittedPath)
        {
            if (string.IsNullOrEmpty(ele) || ele == ".")
            {
                continue;
            }
            else if (ele == "..")
            {
                stack.TryPop(out var val);
            }
            else
            {
                stack.Push(ele);
            }
        }

        if (stack.Count > 0)
        {
            foreach (var s in stack.Reverse())
            {
                output.Append("/");
                output.Append(s);
            }

            return output.ToString();
        }

        return "/";
    }
}
