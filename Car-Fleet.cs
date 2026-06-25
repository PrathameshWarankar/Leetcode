public class Solution 
{
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        var combi = new List<int[]>();
        var resultStack = new Stack<int[]>();

        for (int i = 0; i < position.Length; i++)
        {
            combi.Add([position[i], speed[i]]);
        }

        var sortedCombination = combi.OrderByDescending(x => x[0]);

        foreach (var sc in sortedCombination)
        {
            if (resultStack.Count == 0)
            {
                resultStack.Push(sc);
            }
            else
            {
                var r = resultStack.Peek();

                var d1 = (target - sc[0])/(decimal)sc[1];
                var d2 = (target - r[0])/(decimal)r[1];

                if (d1 > d2)
                {
                    resultStack.Push(sc);
                }
            }
        }

        return resultStack.Count;
    }
}
