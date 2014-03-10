import java.util.*;

public class pat1048
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1048.class.getClassLoader().getResourceAsStream("test"));

        int[] counts = new int[501];
        int n = in.nextInt();
        int m = in.nextInt();

        // indice is the coin face value, content is the number of coin with specific value
        for(int i=0;i<n;i++)
            counts[in.nextInt()]++;

        int a;
        int b;
        int k = m/2;
        for(int i=1;i<=k;i++)
        {
            a = i;
            b = m-a;
            if(a == b && counts[a]>=2)
            {
                System.out.print(a+" "+b);
                return;
            }
            
            if(a!=b && counts[a]>0 && counts[b]>0)
            {
                System.out.print(a+" "+b);
                return;
            }
        }

        System.out.print("No Solution");
    }
}