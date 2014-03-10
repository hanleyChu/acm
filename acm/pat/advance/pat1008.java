import java.util.*;

public class pat1008
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1008.class.getClassLoader().getResourceAsStream("test"));
        int n = in.nextInt();

        int cur = 0;
        int next;

        int k = n;

        int sum = 0;
        while(k>0)
        {
            next = in.nextInt();
            int d = next - cur;
            if(d>0)
                d*=6;
            else
                d*=-4;

            sum+=d;

            cur = next;
            k--;
        }

        sum +=n*5;
        System.out.print(sum);
    }
}