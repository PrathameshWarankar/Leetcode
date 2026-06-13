public class Solution 
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        var dict = new Dictionary<int, int>();
        var freqArr = new List<int>[nums.Length + 1];
        var result = new int[k];

        // stores the ele and its frequenct in dict
        foreach (var ele in nums)
        {
            if (dict.ContainsKey(ele))
            {
                dict[ele] += 1;
            }
            else
            {
                dict[ele] = 1;
            }
        }

        // populates the buckets
        foreach (var kvp in dict)
        {
            if (freqArr[kvp.Value] == null)
            {
                freqArr[kvp.Value] = new List<int>();
            }

            freqArr[kvp.Value].Add(kvp.Key);
        }

        var index = 0;
        for (int i = freqArr.Length - 1; i > 0; i--)
        {
            if (freqArr[i] == null)
            {
                continue;
            }

            foreach (var ele in freqArr[i])
            {
                result[index] = ele;
                index += 1;

                if (index == k)
                {
                    return result;
                }
            }
        }

        return [];
    }
}
