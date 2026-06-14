public class Solution 
{
    public bool IsValidSudoku(char[][] board) 
    {
        var rows = new Dictionary<int, Dictionary<char, char>>();
        var cols = new Dictionary<int, Dictionary<char, char>>();
        var boxes = new Dictionary<int, Dictionary<char, char>>();

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                char value = board[row][col];
                int box = (row/3) * 3 + (col/3);

                if (value == '.')
                {
                    continue;
                }

                if (!rows.ContainsKey(row))
                {
                    rows[row] = new Dictionary<char, char>();
                }

                if (!cols.ContainsKey(col))
                {
                    cols[col] = new Dictionary<char, char>();
                }

                if (!boxes.ContainsKey(box))
                {
                    boxes[box] = new Dictionary<char, char>();
                }

                // checks if value exists available in row
                if (rows[row].ContainsKey(value))
                {
                    return false;
                }
                else
                {
                    rows[row][value] = value;
                }

                // checks if value exists available in column
                if (cols[col].ContainsKey(value))
                {
                    return false;
                }
                else
                {
                    cols[col][value] = value;
                }

                // checks if value exists available in box
                if (boxes[box].ContainsKey(value))
                {
                    return false;
                }
                else
                {
                    boxes[box][value] = value;
                }
            }
        }

        return true;
    }
}
