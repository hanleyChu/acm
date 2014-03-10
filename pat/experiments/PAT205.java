import java.io.*;
import java.util.*;
import java.text.*;

public class PAT205
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT205.class.getClassLoader().getResourceAsStream("test")));

        int n = in.nextInt();
        int[] a = new int[n];

        int i=0;

        long sum = 0;
        while(i<n)
        {
            int tmp = in.nextInt();
            a[i] = tmp;
            sum +=tmp;
            ++i;
        }

        float avg = sum/(float)n;
        float sigma = 0f;
        i = 0;
        while(i<n)
        {
            float tmp = (a[i]-avg);
            sigma += tmp*tmp;
            ++i;
        }
        sigma = (float)Math.sqrt(sigma/n);

        DecimalFormat df = new DecimalFormat("0.00000");
        System.out.println(df.format(sigma));
    }
}