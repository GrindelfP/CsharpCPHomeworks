namespace Hw001;

public static class Task57
{
    public static double GetResult57(double x)
    {
        switch (x)
        {
            case <= 0:
                return 0;
            case > 0 and <= 1:
                return x;
            default:
                return x * x * x * x;
        }
    }
}