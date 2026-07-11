public class TimeMap {
    Dictionary<(string, int), string> dict1;
    Dictionary<string, List<int>> dict2;

    public TimeMap() {
        dict1 = new Dictionary<(string, int), string>();
        dict2 = new Dictionary<string, List<int>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        dict1[(key, timestamp)] = value;

        if(dict2.ContainsKey(key))
        {
            dict2[key].Add(timestamp);
        }
        else
        {
            var list = new List<int>();
            list.Add(timestamp);
            dict2[key] = list;
        }
    }
    
    public string Get(string key, int timestamp) {
        if(dict1.ContainsKey((key, timestamp)))
        {
            return dict1[(key, timestamp)];
        }

        if (!dict2.ContainsKey(key))
        {
            return "";
        }

        var arr = dict2[key];

        int p1 = 0;
        int p2 = arr.Count - 1;
        int ans = 0;

        while (p1 <= p2)
        {
            int mid = ((p2 - p1)/2) + p1;

            if (arr[mid] > timestamp)
            {
                p2 = mid - 1;
            }
            else 
            {
                ans = Math.Max(ans, arr[mid]);
                p1 = mid + 1;
            }
        }

        if (ans == 0)
        {
            return "";
        }

        return dict1[(key, ans)];
    }
}
