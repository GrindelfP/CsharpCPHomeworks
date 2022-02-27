namespace Hw001;

public static class Task38
{
    public static double GetZ(double x, double y)
    {
        if (x > y) return x - y;
        return y - x + 1;
    }
}