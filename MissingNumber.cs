using System;
using System.Collections.Generic;
using System.Linq;

public class NumberUtils
{
    public static int GetMaxValue(List<int> array)
    {
        return array.Max();
    }

    public static int? FindMissingNumber(List<int> array)
    {
        int max = GetMaxValue(array);
        for (int i = 0; i <= max; i++)
        {
            if (!array.Contains(i))
            {
                return i;
            }
        }
        return null; // If nothing is missing
    }
}

public class MissingNumberService
{
    private List<int> _numberArray;

    public MissingNumberService(List<int> numberArray)
    {
        _numberArray = numberArray;
    }

    public int? GetMissingNumber()
    {
        return NumberUtils.FindMissingNumber(_numberArray);
    }
}

public class Program
{
    public static void Main()
    {
        var nums = new List<int> { 9, 6, 4, 2, 3, 5, 7, 0, 1, 8, 11 };
        var missingService = new MissingNumberService(nums);
        var missingNumber = missingService.GetMissingNumber();

        Console.WriteLine(missingNumber.HasValue ? $"Missing number: {missingNumber}" : "No missing number found");
    }
}
