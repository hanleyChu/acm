import java.util.*;
import java.io.*;


public class A
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(A.class.getClassLoader().getResourceAsStream("test")));

        String a = in.next();
        byte da = in.nextByte(); 
        String b = in.next();
        byte db = in.nextByte(); 

        int la = a.length();
        int lb = b.length();

        int ca = 0,cb = 0;
        for(int j =0;j<la;++j)
        {
            if(a.charAt(j)==da+48)
                ca = ca*10+1;
        }

        for(int j =0;j<lb;++j)
        {
            if(b.charAt(j)==db+48)
                cb = cb*10+1;
        }

        ca = ca*((int)da);
        cb = cb*((int)db);

        System.out.println(ca+cb);
    }
}