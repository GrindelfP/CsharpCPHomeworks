using static ConsoleMethods.ConsoleOutput;

namespace Hw001;

public static class Task11
{
    public static double GetResult11(double x, double y, double z, string modifier)
    {
        switch (modifier)
        {
            case "EA":
                return (1 + Math.Sin(x + y) * Math.Sin(x + y))/(2 + Math.Abs((x - 2*x)/(1 + x*x*y*y)));
            
            case "EB":
                try
                {
                    return Math.Cos(Math.Atan(1 / z)) * Math.Cos(Math.Atan(1 / z));
                }
                catch
                {
                    PrintLn("Operation is impossible!");
                    throw;
                }
            case "GA":
                try
                {
                    return Math.Log((y - Math.Sqrt(Math.Abs(x)))*(x - y/(z + x*x/4)));
                }
                catch
                {
                    PrintLn("Operation is impossible!");
                    throw;
                }
            default:
                return x - x*x/(2*3) + x*x*x*x*x/(2*3*4*5);
        }
    }
}