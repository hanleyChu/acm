import java.util.*;
import java.io.*;

public class PAT_1002
{
    
    public static void main(String args[])
    {
        final String[] num2pin = {"ling", "yi", "er", "san", "si", "wu","liu","qi","ba","jiu","shi"};
        Scanner in = new Scanner(new BufferedInputStream(System.in));
        String num = in.next();

        int i = 0;
        int len = num.length();
        int sum = 0;
        for(i=0; i<len;++i)
        {
            sum+=(int)num.charAt(i)-48;
        }

        StringBuilder sb = new StringBuilder();

        if(sum == 0)
            System.out.println("ling");
        else
        {
            while(sum!=0)
            {
                sb.insert(0, num2pin[sum%10]);
                sb.insert(0, ' ');

                sum/=10;
            }

            sb.deleteCharAt(0);
            System.out.println(sb.toString());
        }
    }
}