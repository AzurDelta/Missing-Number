namespace Missing_Number;

public class MissingNumber
{
    public static int MissingNumberFinder(int[] inputMassive)
    {
        inputMassive = inputMassive.OrderBy(i => i)
            .ToArray();
        
        for (int i = 0; i < inputMassive.Length; i++)
        {
            if (inputMassive[i] != i) return i;
        }

        return -1;
    }
}