using System.Collections.Generic;

public class SnailSolution
{
    public static int[] Snail(int[][] array)
    {
        int laenge = array.Length - 1;
        List<int> retValue = new List<int>();

        int zyklus = 0
 

       for (int zyklus = 0; zyklus < laenge / 2; zyklus++)
        {
            for (int r = 0 + zyklus; r < laenge - zyklus; r++)
            {
                retValue.Add(array[0 + zyklus][r]);
            }

        }

        zeile 0 + c reihe 0 + c bis n-1 - c
 
zeile 1: bis n-1  reihe n-1
 
zeile n-1: reihe n-1 bis 1
 
zeile 1 bis n-1 - 1 reihe 0
 

            return retValue.ToArray();
    }
}