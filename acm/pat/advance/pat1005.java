import java.util.*;

public class pat1005
{
    public static void main(String[] args)
    {
        String[] d2e = new String[]{"zero","one","two","three","four","five","six","seven","eight","nine"};
        Scanner in = new Scanner(System.in);

        String str = in.next();
        byte[] r = new byte[100];
        /*
        k=0
        for i = 0->str.length - 1:
            j = 0
            tmp = (str[i]-'0')
            while(true)
                sum = tmp+r[j]
                if sum>10
                    r[j] = sum%10
                    tmp = 1
                    j++
                else
                    if(k<j)
                        k=j
                    break;
        print r[0->j]
        */

        int k=0;
        int l = str.length();
        for(int i=0;i<l;i++)
        {
            int j = 0;
            byte tmp = (byte)(str.charAt(i)-'0');
            while(true)
            {
                int sum = tmp+r[j];
                if(sum>10)
                {
                    r[j]%=10;
                    tmp = 1;
                    j++;
                }
                else
                {
                    if(k<j)
                        k=j;
                    break;
                }
            }
        }
        System.out.print(k);
        StringBuilder sb = new StringBuilder();
        for(int i=k;i>=0;i--)
        {
            sb.append(d2e[r[i]]+" ");
        }

        sb.deleteCharAt(sb.length()-1);
        System.out.print(sb);
    }
}