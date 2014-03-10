import java.util.*;

public class pat1010
{
    public static void main(String[] args)
    {
        /*
        String a, b,  a is the given number with radix, b is target number
        radix_a is a's radix
        define toDecimal(number_string, radix)

        deciaml_a = toDecimal(a,radix_a)
        plr = get possible_least_radix for b
        for radix_b = plr -> 36
            decimal_b = toDecimal(b, radix_b)
            if decimal_b == deciaml_a
                print radix_b
                return;

        print Impossible
                */
        Scanner in = new Scanner(pat1010.class.getClassLoader().getResourceAsStream("test"));
        String a = in.next();
        String b = in.next();
        int select = in.nextInt();
        if(select == 2)
        {
            String tmp = a;
            a = b;
            b=tmp;
        }
        int radix_a = in.nextInt();

        long decimal_a = toDecimal(a,radix_a);

        int plr = 0;//possible_least_radix of b
        for(char c:b.toCharArray())
        {
            int cur_radix;
            if(Character.isDigit(c))
            	cur_radix = c-'0'+1;
            else
            	cur_radix = c - 'a'+11;
            if(cur_radix>plr)
            {
                plr = cur_radix;
            }
        }

        for(int i=plr;i<=36;i++)
        {
            long decimal_b = toDecimal(b,i);
            if(decimal_a == decimal_b)
            {
                System.out.print(i);
                return;
            }
        }

        System.out.print("Impossible");
    }

    public static long toDecimal(String num, int radix)
    {
        long result = 0;
        int len = num.length();
        for(int i=0;i<len;i++)
        {
        	int coef;
        	if(Character.isDigit(num.charAt(i)))
			{
				coef = num.charAt(i)-'0';
			}
        	else
        	{
        		coef = num.charAt(i) - 'a'+10;
        	}
            result += (long)(coef*Math.pow(radix,(len-i-1)));
        }

        return result;
    }
}