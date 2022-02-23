using static hw0302.VariantOne;
using static ConsoleMethods.ConsoleInput;
using static ConsoleMethods.ConsoleOutput;

namespace hw0224;

internal static class Program
{
    private static void Main()
    {
        PrintLn(GetNegativeSum(ArrayInput("number")));
    }
}