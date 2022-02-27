using static ConsoleMethods.ConsoleInput;
using static ConsoleMethods.ConsoleOutput;
using static Hw001.Task11;
using static Hw001.Task38;
using static Hw001.Task57;
using static Hw001.Task59;
using static Hw001.Task67;
using static Hw001.Task77;
namespace Hw001;

internal static class Program
{
    private static void Main()
    {
        // Task 11
        var x1 = DoubleInput();
        var y1 = DoubleInput();
        var z1 = DoubleInput();
        PrintLn(GetResult11(x1, y1, z1, "EA"));
        PrintLn(GetResult11(x1, y1, z1, "EB"));
        PrintLn(GetResult11(x1, y1, z1, "GA"));
        PrintLn(GetResult11(x1, y1, z1, "default"));
        
        // Task 38
        var x2 = DoubleInput();
        var y2 = DoubleInput();
        PrintLn(GetZ(x2, y2));
        
        // Task 57
        var a = DoubleInput();
        PrintLn(GetResult57(a));
        
        // Task 59
        var x3 = DoubleInput();
        var y3 = DoubleInput();
        PrintLn(IsContained(x3, y3, "a"));
        PrintLn(IsContained(x3, y3, "b"));
        PrintLn(IsContained(x3, y3, "c"));
        PrintLn(IsContained(x3, y3, "d"));
        PrintLn(IsContained(x3, y3, "e"));
        PrintLn(IsContained(x3, y3, "f"));
        PrintLn(IsContained(x3, y3, "g"));
        PrintLn(IsContained(x3, y3, "h"));
        PrintLn(IsContained(x3, y3, "i"));
        PrintLn(IsContained(x3, y3, "j"));
        
        //Task 67
        var num1 = StrInput();
        PrintResult67(num1);
        
        // Task 77
        var num2 = IntInput();
        PrintResult77(num2);
    }
}
