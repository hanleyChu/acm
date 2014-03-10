import java.io.*;
import java.util.*;

public class PalintmondString
{
    public static void main(String args)
    {
        Scanner in = new Scanner(new BufferedInputStream(System.in));

        while(in.hasNext())
        {
            String str = in.next();
            System.out.println(maxPalintond(str));
        }
    }

    public static String maxPalintond(String str)
    {
        String nstr = " "+str+ " ";
        char[] s = nstr.toCharArray();
        int len = s.length;
        int p=1;
        int q=1;

        String max = null;
        int maxLen = 0;

        while(q<len-1)
        {
            int t = q;
            while(s[p--]==s[q++]);

            //find the different one in the same sequence ascending
            while(s[t]==s[t+1])
                ++t;
            ++t;

            if(t>q)
            {
                if(t-p-1>maxLen)
                {
                    max = String(char[p+1,t-1]);
                    maxLen = t-p-1;
                }
            }
            else
            {
                p = q;
            }
        }
    }
}