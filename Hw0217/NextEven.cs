namespace hw0217;

public static class NextEven
{
    public static object GetNextEven(int number)
    {
        if (number % 2 == 0) return number + 2;
        return number + 1;
    }
}