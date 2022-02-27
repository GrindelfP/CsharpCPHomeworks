using static Hw0224.VariantOne;
using static ConsoleMethods.ConsoleInput;
using static ConsoleMethods.ConsoleOutput;

namespace Hw0224;

internal static class Program
{
    private static void Main()
    {
        // Variant One
        var array = ArrayNumInput();
        
        PrintLn(GetNegativeSum(array));
        PrintLn(GetProductBetween(GetMaxMinIndexes(array), array));
        PrintLn(GetAbsMax(array));
        PrintLn(GetSumBetween(GetFirstSecondPositiveIndexes(array), array));
    }
}