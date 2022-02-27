namespace Hw001;

public static class Task67
{
    public static void PrintResult67(string n)
    {
        var counter = 0;
        foreach (var digit in n) counter++;
        
        var nint = Convert.ToInt32(n);
        var preLastDigit = '-';
        if (nint >= 10)
        {
            preLastDigit = n[^2];
        }

        var digitSum = 0;
        while (nint > 0)
        {
            digitSum += nint - nint / 10 * 10;
            nint /= 10;
        }
    
        var lastDigit = n[^1];
        var firstDigit = n[0];
        Console.WriteLine("Your number is {0} digits long. Sum of its digits equals to {1}. Its last and first digits " +
                          "are agreeably {2} and {3}. If it's greater or equal to ten int pre-last digit is {4}.", 
            counter, digitSum, lastDigit, firstDigit, preLastDigit);
    }
}