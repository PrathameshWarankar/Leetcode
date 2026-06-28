public class FreqStack {

    Dictionary<int, int> counter;
    Dictionary<int, Stack<int>> map;
    int max = 0;

    public FreqStack() {
        counter = new Dictionary<int, int>();
        map = new Dictionary<int, Stack<int>>();
    }
    
    public void Push(int val) {
        if(counter.ContainsKey(val))
        {
            counter[val] += 1;
        }
        else
        {
            counter[val] = 1;
        }

        if(map.ContainsKey(counter[val]))
        {
            map[counter[val]].Push(val);
        }
        else
        {
            map[counter[val]] = new Stack<int>();
            map[counter[val]].Push(val);
        }

        max = Math.Max(max, counter[val]);
    }
    
    public int Pop() {
        var pop = map[max].Pop();

        counter[pop]--;

        if (map[max].Count == 0)
        {
            max -= 1;
        }

        return pop;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */
