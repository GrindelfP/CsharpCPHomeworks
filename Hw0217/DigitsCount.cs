namespace hw0217;

public static class DigitsCount
{
    public static int GetDigitsSum(int number)
    {
        var sumOfDigits = 0;
        while (number > 0)
        {
            sumOfDigits += number % 10;
            number /= 10;
        }
        return sumOfDigits;
    }
}