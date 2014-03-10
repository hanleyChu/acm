import java.io.*;
import java.util.*;

public class PAT_1010
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT_1010.class.getClassLoader().getResourceAsStream("test")));

        StringBuilder sb = new StringBuilder();
        while(in.hasNextInt())
        {
            int a = in.nextInt();
            int b = in.nextInt();

            if(b==0)
            {
                a=0;
                b=0;
            }
            else
            {
                a*=b;
                b-=1;
            }

            sb.append(a).append(" ").append(b);
        }

        System.out.println(sb.toString());
    }
}