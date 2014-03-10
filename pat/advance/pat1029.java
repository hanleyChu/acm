import java.util.*;

public class pat1029
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1029.class.getClassLoader().getResourceAsStream("test"));
        
        int n = in.nextInt();
        int[] a = new int[n];
        for(int i=0;i<n;++i)
            a[i] = in.nextInt();

        int m = in.nextInt();
        int[] b = new int[m];
        for(int i=0;i<m;++i)
            b[i] = in.nextInt();

        if(m==1 && n==1)
            System.out.print(a[0]>b[0]?b[0]:a[0]);
        else
        {
            int k = (n+m+1)/2;
            int i = 0; //present position, visited
            int j = 0;
            int c = 0;
            int median = 0;
            while(c<k && i<n && j<m)
            {
                if(a[i]<b[j])
                {
                    median = a[i];
                    i++;
                }
                else
                {
                    median = b[j];
                    j++;
                }

                c++;
            }

            if(c==k)
                System.out.print(median);
            else
            {
                if(i==n)
                {
                    while(c<k)
                    {
                        j++;
                        c++;
                    }
                        
                    System.out.print(b[j]);
                }
                else
                {
                    while(c<k)
                    {
                        i++;
                        c++;
                    }
                    System.out.print(a[i]);
                }
            }

        }
    }
}