using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        List<int> ret = new List<int>();
        int len = array.Length - 1;
        int max = len * len;

        if (array == null)
        {
            ret.Add(new int());
            return ret.ToArray();
        }

        if (len == 0)
        {
            ret.Add(array[0][0]);
            return ret.ToArray();
        }
        for (int zyklus = 0; zyklus < len; zyklus++)
        {

            //(1+Zyklus). Line
            for (int i = 0 + zyklus; i <= len - zyklus; i++)
            {
                ret.Add(array[0 + zyklus][i]);
            }

            for (int i = 1 + zyklus; i < len - zyklus; i++)
            {
                ret.Add(array[i][len - zyklus]);
            }

            for (int i = len - zyklus; i >= 1 + zyklus; i--)
            {
                ret.Add(array[len - zyklus][i]);
            }

            for (int i = len - zyklus; i >= 1 + zyklus; i--)
            {
                ret.Add(array[i][0 + zyklus]);
            }

        }
        return ret.ToArray();
    }
}