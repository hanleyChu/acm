import java.io.*;
import java.util.*;

public class PAT_1011
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT_1010.class.getClassLoader().getResourceAsStream("test")));

        int n = in.nextInt();

        int i=1;
        while(i<=n)
        {
            int a = in.nextInt();
            int b = in.nextInt();
            int c = in.nextInt();

            if(a>0 && b>0 && a+b<0)
            {
                System.out.println(String.format("Case #%d: true", i));
            }
            else if(a<0 && b<0 && a+b>0)
            {
                System.out.println(String.format("Case #%d: false", i));
            }
            else if(a+b>c)
            {
                System.out.println(String.format("Case #%d: true", i));
            }
            else
            {
                System.out.println(String.format("Case #%d: false", i));
            }

            ++i;
        }
    }
}