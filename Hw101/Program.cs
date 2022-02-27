using static ConsoleMethods.ConsoleOutput;
using static ConsoleMethods.ConsoleInput;
using static hw0217.DigitsCount;
using static hw0217.Route;
using static hw0217.NextEven;
using static hw0217.LastDigit;
using static hw0217.Hypotenuse;

namespace hw0217;

internal static class Program
{
    private static void Main()
    {
        // Hypotenuse task;
        Print("Task 1. \nTo get hypotenuse type here your 'a' and 'b' legs: ");
        var a = IntInput();
        var b = IntInput();
        PrintLn(">>>>>>>>>>>>>>>\nHere is your hypotenuse: " + GetHyp(a, b));
        // Last digit task;
        Print("\nTask 5. \nTo get last digit type your number here: ");
        var number = StrInput();
        PrintLn(">>>>>>>>>>>>>>>\nHere is your number's last digit: " + GetLastDigit(number));
        // Next even number task;
        Print("\nTask 9. \nTo get next even type your number here: ");
        var evenChecked = IntInput();
        PrintLn(">>>>>>>>>>>>>>>\nHere is your number's next even: " + GetNextEven(evenChecked));
        // Get days task;
        Print("\nTask 10. \nTo get travel time type your distance and daily distance here: ");
        var distance = IntInput();
        var dailyDistance = IntInput();
        PrintLn(">>>>>>>>>>>>>>>\nHere is your transport passage time in days: " 
                + GetTime(distance, dailyDistance));
        // Get digits' sum t/home/gregory/programming/C#Projects/CsPersonalLibraries/ConsoleMethods/bin/Debug/net6.0/ConsoleMethods.dllask;
        Print("\nTask 8. \nTo get sum of digits type your number here: ");
        var numberForSum = IntInput();
        PrintLn(">>>>>>>>>>>>>>>\nHere is sum of digits of your number: " + 
                GetDigitsSum(numberForSum));
    }
}