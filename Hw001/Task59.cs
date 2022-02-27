namespace Hw001;

public static class Task59
{
    public static bool IsContained(double x, double y, string modifier)
    {
        switch (modifier)
        {
            case "a":
                return x * x + y * y <= 1;
            case "b":
                return x * x + y * y <= 1 && x*x + y*y >= .25;
            case "c":
                return x is >= -1 and <= 1 && y is >= -1 and <= 1;
            case "d":
                return Math.Abs(x) + Math.Abs(y) <= 1;
            case "e":
                return Math.Abs(x)/.5 + Math.Abs(y) <= 1;
            case "f":
                if (x >= 0) return x*x + y*y <= 1;
                else return Math.Abs(x)/2 + Math.Abs(y) <= 1;
            case "g":
                if (x >= 0) return y >= -1 && y - 3*x <= 2; 
                else return y >= -1 && y + 3*x <= 2;
            case "h":
                if (x >= 0) return y >= -2 && x <= 1 && y - x <= 0;
                else return y >= -2 && x >= -1 && y + x <= 0;
            case "i":
                switch (x)
                {
                    case 0 when y == 0:
                        return true;
                    case >= 0:
                        return y <= 0 && y - .5*x <= .5;
                    default:
                        return y + x <= 0 && y - 2*x <= 3;
                }
            default:
                if (x >= 1 && x <= -1) return y >= 1;
                else return y - x >= 0 && y + x >= 0;
        }
    }
}