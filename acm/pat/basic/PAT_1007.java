import java.util.*;
import java.io.*;

public class PAT_1007
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT_1007.class.getClassLoader().getResourceAsStream("test")));

        int n = in.nextInt();
        int count = 0;
        int p = 3;
        for(int i=5;i<=n;++i)
        {
            if(i%2 == 0)
                continue;

            if(isSuShu(i))
            {
                if(i-p==2)
                {
                    count++;
                }

                p=i;
            }
        }

        System.out.println(count);
    }

    public static boolean isSuShu(int n)
    {
        int m = (int)Math.sqrt(n);

        for(int i=2;i<=m;++i)
        {
            if(n%i==0)
                return false;
        }
        return true;
    }
}