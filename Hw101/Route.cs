namespace hw0217;

public static class Route
{
    public static object GetTime(int dist, int dayDist)
    {
        if (dist == dayDist || dist < dayDist) return 1;
        if (dist % dayDist == 0) return dist / dayDist;
        return dist / dayDist + 1;
    }
}