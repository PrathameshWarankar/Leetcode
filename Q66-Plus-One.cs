public class Solution 
{
    public int[] PlusOne(int[] digits)
    {
       Increment(digits, digits.Length - 1);

       if (digits[0] == 0)
       {
         return [1, ..digits];
       }

       return digits;
    }

    public void Increment(int[] digits, int index)
    {
        if (digits[index] + 1 >= 10)
        {
            digits[index] = 0;

            if (index - 1 >= 0)
            {
                Increment(digits, index - 1);
            }
        }
        else
        {
            digits[index] += 1;
        }
    }
}
