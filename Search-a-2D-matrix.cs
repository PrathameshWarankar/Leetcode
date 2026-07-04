public class Solution 
{
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        int p1 = 0;
        int p2 = rows - 1;
        int row = -1;

        while (p1 <= p2)
        {
            int mid = ((p2-p1)/2) + p1;

            if (matrix[mid][0] > target)
            {
                p2 = mid - 1;
            }
            else
            {
                row = mid;
                p1 = mid + 1;
            }
        }

        if (row == -1)
        {
            return false;
        }

        p1 = 0;
        p2 = cols - 1;

        while (p1 <= p2)
        {
            int mid = ((p2-p1)/2) + p1;

            if (matrix[row][mid] == target)
            {
                return true;
            }
            else if (matrix[row][mid] > target)
            {
                p2 = mid - 1;
            }
            else
            {
                p1 = mid + 1;
            }
        }

        return false;
    }
}
