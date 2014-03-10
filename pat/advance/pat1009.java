import java.util.*;
import java.text.*;

class Node
{
    public int e;
    public float v;

    public Node(int e, float v)
    {
        this.e = e;
        this.v = v;
    }
}

public class pat1009
{
    public static void main(String[] args)
    {
        float[] r = new float[1001]; // 0-1000, indice is the exponent, value is the coefficent

        Scanner in = new Scanner(pat1009.class.getClassLoader().getResourceAsStream("test"));

        List<Node> list = new LinkedList<Node>();
        int k = in.nextInt();
        while(k>0)
        {
            int e = in.nextInt();
            float v = in.nextFloat();
            list.add(new Node(e, v));

            k--;
        }

        // for each input, we make it multiplied by every element of list, and record it in r array
        k = in.nextInt();
        while(k>0)
        {
            int e = in.nextInt();
            float v = in.nextFloat();

            for(Node n:list)
            {
                int re = e+n.e;
                float rv = v*n.v;

                r[re] += rv;
            }

            k--;
        }

        DecimalFormat df = new DecimalFormat("0.0");
        StringBuilder sb = new StringBuilder();
        int count=0;
        for(int i=1000;i>=0;i--)
        {
            if(r[i]!=0)
            {
                sb.append(" "+i+" "+df.format(r[i]));
                count++;
            }
        }

        System.out.print(count+sb.toString());

    }
}