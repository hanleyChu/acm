import java.util.*;

public class PAT_1001
{
    public static void main(String args[])
    {
        Scanner in = new Scanner(System.in);
        int num = in.nextInt();

        int count = 0;
        while(num!=1)
        {
            if(num%2==0)
                num/=2;
            else
                num = (3*num+1)/2;

            ++count;
        }

        System.out.println(count);

    }
}