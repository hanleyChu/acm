import java.io.*;
import java.util.*;
import static java.lang.System.out;

public class PAT_1017
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(PAT_1017.class.getClassLoader().getResourceAsStream("test")));

        String a = in.next();
        int b = in.nextInt();
        StringBuilder sb = new StringBuilder();

        if(a.length()>1)
        {
            int q = a.length()-1;
            int p =1;

            int rest = a.charAt(0)-48;
            int num = 0;
            while(p<=q)
            {
                num = rest*10+a.charAt(p)-48;
                sb.append(num/b);
                rest=num%b;
                ++p;
            }
            sb.append(" "+rest);
        }
        else
        {
            int tmp = a.charAt(0)-48;
            sb.append(tmp/b+" "+tmp%b);
        }

        
        out.println(sb.toString());
    }
}