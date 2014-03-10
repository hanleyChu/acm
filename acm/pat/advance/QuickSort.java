import java.util.*;

public class QuickSort
{
    public static void main(String[] args)
    {
        int[] a = new int[]{0,0,0};
        quickSort(a);
        System.out.print(Arrays.toString(a));
    }

    public static void quickSort(int[] a)
    {
        _quickSort(a,0,a.length-1);
    }

    public static void _quickSort(int[] a, int s, int e)
    {
        if(s>=e)
            return;

        // s->i less than a[e], i+1->j greater than a[e], k is the next candidate
        int i = s-1;
        int j = s-1;
        int k = s;

        for(;k<e;k++)
        {
            if(a[k]>=a[e])
            {
                j = k;
            }
            else
            {
                i++;
                int tmp = a[i];
                a[i] = a[k];
                a[k] = tmp;

                j = k;
            }
        }

        i++;
        int tmp = a[i];
        a[i] = a[e];
        a[e] = tmp;

        _quickSort(a, s, i-1);
        _quickSort(a,i+1,e);
    }
}