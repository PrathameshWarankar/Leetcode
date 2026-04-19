public class Solution 
{
    public IList<IList<int>> Generate(int numRows) 
    {
        var finalList = new List<IList<int>> { new List<int> {1} };
        var prevList = new List<int>();

        if (numRows == 0)
        {
            return new List<IList<int>>();
        }

        for (var i = 2; i <= numRows; i++)
        {
            var arr = GetPascalElements(prevList);
            List<int> newList = [1, ..arr, 1];
            finalList.Add(newList);
            prevList = newList;
        }

        return finalList;
    }

    public List<int> GetPascalElements(List<int> prevList)
    {
        var returnList = new List<int>();

        for (var i = 0; i < prevList.Count - 1; i++ )
        {
            returnList.Add(prevList[i] + prevList[i+1]);
        }

        return returnList;
    }
}
