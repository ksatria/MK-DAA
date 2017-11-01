using System;

public class Fibonacci
{
	public int[] hitung(int n)
	{
        int[] F = new int[n+1]; //inisialisasi ruang perekaman

        F[0] = 0;
        F[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            F[i] = F[i - 1] + F[i - 2];
        }

        return F;
	}
}
