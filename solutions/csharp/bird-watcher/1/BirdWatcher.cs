using System.Numerics;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length-1] ++;
    }

    public bool HasDayWithoutBirds()
    {
        return birdsPerDay.Contains(0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for (int i=0; i<numberOfDays; i++)
        {
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {   
        int count = 0;
        foreach (int i in birdsPerDay)
        {
            if (i >= 5)
            {
                count ++;
            }
        }
        return count;
    }
}
