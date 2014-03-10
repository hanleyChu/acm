import java.io.*;
import java.util.*;

public class PAT206
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT205.class.getClassLoader().getResourceAsStream("test")));
        int a = in.nextInt();
        int n = in.nextInt();
        int[] num = new int[n+1]; //num[n] holds the carry
        Arrays.fill(num,0);

        for(int i=0;i<n;++i)
        {
            num[i] = num[i]+(n-i)*a;
            num[i+1] +=num[i]/10;
            num[i] %= 10;
        }

        //display the carry
        if(num[n]!=0)
            System.out.print(num[n]);
        //display the rest num
        for(int i=n-1;i>=0;--i)
            System.out.print(num[i]);

    }
}