namespace hw0302;

public class VariantOne
{
    public static string GetNegativeSum(Array array)
    {
        int sum = 0;
        foreach (var number in array)
        {
            var intedElement = Convert.ToInt32(number);
            if (intedElement < 0) sum += intedElement;
        }
        return "Here is your result: " + Convert.ToString(sum) + ".";
    }
}