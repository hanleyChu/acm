import java.io.*;
import java.util.*;

public class PAT_1008
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT_1008.class.getClassLoader().getResourceAsStream("test")));

        int n = in.nextInt();
        int m = in.nextInt();
        int i = 0;
        int[] a = new int[n];
        while(i<n)
        {
            a[i] = in.nextInt();
            ++i;
        }

        if(m>=n)
            m=m-n;
        if(m>0)
        {
            // jump copy
            int p = n-m;
            int q = n-1;

            while(p>=m)
            {
                int j=m;
                int tmp;
                while(j>0)
                {
                    --p;
                    tmp = a[q];
                    a[q] = a[p];
                    a[p] = tmp;
                    --q;

                    --j;
                }
            }

            // right cycle rotate for the rest
            if(p>0)
            {
                int restLoop = p;
                p=0;
                int tmp;
                while(restLoop>0)
                {
                    tmp = a[0];

                    //rotate
                    i=1;
                    while(i<=q)
                    {
                        a[i-1] = a[i];
                        ++i;
                    }
                    a[q] = tmp;

                    restLoop--;
                }
            }
        }
        StringBuilder sb= new StringBuilder();
        for(i=0;i<n;++i)
        {
            sb.append(a[i]).append(" ");
        }
        System.out.println(sb.toString().trim());
    }
}