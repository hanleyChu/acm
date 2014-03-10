import java.util.*;
import java.io.*;
import java.text.*;

public class pat1002
{
    public static void main(String[] args)
    {
        Scanner in  = new Scanner(new BufferedInputStream(pat1002.class.getClassLoader().getResourceAsStream("test")));

        int k;

        // type 1 exponents; type 2 coefficients
        k = in.nextInt();
        Map<Integer,Float> poly1 = readPoly(in,k);

        k = in.nextInt();
        Map<Integer,Float> poly2 = readPoly(in,k);

        // add poly1 to poly2
        for(int c: poly1.keySet())
        {
            if(poly2.containsKey(c))
            {
                poly2.put(c,poly2.get(c)+poly1.get(c));
            }
            else
            {
                poly2.put(c,poly1.get(c));
            }
        }

        // print poly2
        StringBuilder sb = new StringBuilder();

        Integer[] keys = poly2.keySet().toArray(new Integer[0]);

        Arrays.sort(keys, new Comparator<Integer>(){
            @Override
            public int compare(Integer a, Integer b){
                return b-a;
            }
        });

        int count = 0;
        DecimalFormat df = new DecimalFormat("#.#");
        for(int key : keys)
        {
            // skip item with 0 coefficient 
            float value = poly2.get(key);
            if(value != 0)
            {
                sb.append(key);
                sb.append(" ");
                sb.append(df.format(value));
                sb.append(" ");
                count++;
            }
        }
        sb.deleteCharAt(sb.length()-1);
        sb.insert(0, count+" ");
        System.out.print(sb.toString());
    }

    public static Map<Integer,Float> readPoly(Scanner in, int k)
    {
        Map<Integer,Float> poly = new HashMap<Integer,Float>();

        float c;
        int e;
        while(k>0)
        {
            e = in.nextInt();
            c = in.nextFloat();
            poly.put(e, c);

            --k;
        }

        return poly;
    }
}