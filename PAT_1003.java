import java.util.*;
import java.io.*;


public class PAT_1003
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(System.in));

        int num = in.nextInt();
        String str;

        Pattern p = Pattern.compile("[\\sA]*P[A]{1,2}T[\\sA]*");

        int i=num;
        while(i>0)
        {
            str = in.next();

            if(p.matcher(str).matches())
                System.out.println("YES");
            else
                System.out.println("NO");
            --i;
        }

    }
}