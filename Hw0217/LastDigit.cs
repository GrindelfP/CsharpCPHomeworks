namespace hw0217;

public static class LastDigit
{
    public static object GetLastDigit(string? number)
    {
        if (number != "") return number![^1];
        return "None";
    }
}