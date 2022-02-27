namespace Hw001;

public static class Task77
{
    public static void PrintResult77(int n)
    {
        var powered = 1;
        for (int i = 0; i < n; i++) powered *= 2;

        long factorial = 1;
        for (long i = 1; i <= n; i++) factorial *= i;

        var product = 1.0;
        for (var i = 1.0; i <= n; i++) product *= (1.0 + 1.0/i*i);
        
        Console.WriteLine("2 powered to n equals {0}. n-factorial equals {1}. " +
                          "Product of multiplying (1 + 1/1^2)(1 + 1/2^2)...(1 + 1/n^2) is {2}.", 
                            powered, factorial, product);
    }
}