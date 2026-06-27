public class Solution 
{
    public int[] AsteroidCollision(int[] asteroids) 
    {
        var stack = new Stack<int>();

        foreach (var asteroid in asteroids)
        {
            var skip = false;

            if (asteroid > 0)
            {
                stack.Push(asteroid);
            }

            while (stack.Count > 0
                && stack.Peek() > 0
                && asteroid < 0)
            {
                if (stack.Peek() < -(asteroid))
                {
                    stack.Pop();
                }
                else if (stack.Peek() > -(asteroid))
                {
                    skip = true;
                    break;
                }
                else
                {
                    stack.Pop();
                    skip = true;
                    break;
                }
            }

            if (!skip && asteroid < 0)
            {
                stack.Push(asteroid);
            }
        }

        var result = new int[stack.Count];

        for (int i = stack.Count - 1; i >= 0; i--)
        {
            result[i] = stack.Pop();
        }

        return result;
    }
}
