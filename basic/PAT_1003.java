import java.util.*;
import java.io.*;
import java.util.regex.*;


public class PAT_1003 
{
    public static void main(String[] args) throws Exception
    {
        Scanner in = new Scanner(new BufferedInputStream(new FileInputStream("E:\\project\\github\\hanleyChu\\acm\\test")));

        int num = in.nextInt();
        String str;

        Pattern p = Pattern.compile("(\\s*PA{1,2}T\\s*)|(A*PA{1,2}TA*)");
        int i=num;
        while(i>0)
        {
            str = in.next();

            if(p.matcher(str).matches())
            {
                if(isCondition3Satisfy(str))
                    System.out.println("YES");
                else
                    System.out.println("NO");
            }
            else
                System.out.println("NO");
            --i;
        }
    }

    public static boolean isCondition3Satisfy(String str)
    {
        int len = str.length();
        int prefixLen = str.indexOf('P');
        int lastPrefixLen = len - str.lastIndexOf('T')-1;

        int p2tLen = lastPrefixLen-prefixLen;
        if(p2tLen == 2)
           return prefixLen*2 == lastPrefixLen ? true:false;

        return prefixLen == lastPrefixLen ? true:false;
    }
}