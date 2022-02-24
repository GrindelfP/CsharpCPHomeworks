namespace Hw0224;

public static class VariantOne
{
    public static string GetNegativeSum(Array array)
    {
        var sum = 0;
        foreach (var number in array)
        {
            var intedElement = Convert.ToInt32(number);
            if (intedElement < 0) sum += intedElement;
        }
        return "Here are summed negative elements: " + sum + ".";
    }

    public static string GetProductBetween(int[] indexes, double[] array)
    {
        var upper = indexes[0];         
        var bottom = indexes[1]; 
        if (upper - bottom == 1) return "There is no elements between max and min element!";
        double product = 1;
        for (var i = bottom + 1; i < upper; i++)
        {
            product *= array[i];
        }
        return "Here is result of multiplying numbers between max and min elements: " + product + ".";
    }

    public static int[] GetMaxMinIndexes(double[] array)
    {
        var max = 0;
        var min = 0;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] > array[max]) max = i; if (array[i] < array[min]) min = i;
        }
        int[] result;
        if (max > min)
        {
            result = new[] {max, min};
            return result;
        }
        result = new[] {min, max};
        return result;
    }

    public static string GetSumBetween(int[] indexes, double[] array)
    {
        var upper = indexes[1];         
        var bottom = indexes[0]; 
        if (upper - bottom == 1) return "There is no elements between first and second positive elements!";
        double sum = 0;
        for (var i = bottom + 1; i < upper; i++)
        {
            sum += array[i];
        }
        return "Here are summed numbers between first and second positive elements: " + sum + ".";
    }

    public static int[] GetFirstSecondPositiveIndexes(double[] array)
    {
        var counter = 2;
        var index = 0;
        int[] result = {0,0};
        for (var i = 0; i < array.Length; i++)
        {
            if (!(array[i] > 0) || counter <= 0) continue;
            result[index] = i;
            index += 1;
            counter -= 1;
        }
        return result;
    }
 
    public static string GetAbsMax(double[] array)
    {
        var max = array[0];
        foreach (var element in array)
        {
            if (max < Math.Abs(element)) max = element;
        }
        return "Here is the absolutely-biggest element of your array: " + max + ".";
    }
}