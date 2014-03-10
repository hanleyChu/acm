import java.util.*;

class UnionFindSet
{
    public int[] a;
    public int count;
    public int n;
    //public int[] size;

    public int find(int i)
    {
        while(i!=a[i])
        {
            i=a[i]=a[a[i]];
        }

        return i;
    }

    public void union(int i, int j)
    {
        int m = find(i);
        int n = find(j);

        if(m==n)
            return;
        else
        {
            // if(size[m]>size[n])
            // {
            //     a[n] = m;
            //     size[m]+=size[n];
            // }
            // else
            // {
                a[m] = n;
            //    size[n] +=size[m];
            //}

            count--;
        }
    }

    public void init()
    {
        for(int i=1;i<=n;i++)
        {
            a[i] = i;
            //size[i] = 1;
        }
        this.count = n;
    }

    public UnionFindSet(int n)
    {
        this.n = n;
        this.count = n;
        this.a = new int[n+1];
        //this.size = new int[n+1];
    }
}
public class pat1013
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1013.class.getClassLoader().getResourceAsStream("test"));
        // union find set is used to divide the rest cities into many groups.
        // the result is the city count - 1

        // first of all, we put all the connection pair into an array
        int n = in.nextInt();
        int m = in.nextInt();
        int k = in.nextInt();
        int[][] pairs = new int[m][2];
        for(int i=0; i<m; i++)
        {
            pairs[i][0] = in.nextInt();
            pairs[i][1] = in.nextInt();
        }

        UnionFindSet ufs = new UnionFindSet(n);// exclude the test one
        for(int i=0;i<k;i++)
        {
            ufs.init();

            int t = in.nextInt();
            for(int j=0;j<m;j++)
            {
                if(pairs[j][0]!=t && pairs[j][1]!=t)
                {
                    ufs.union(pairs[j][0],pairs[j][1]);
                }
            }

            System.out.println(ufs.count-2);
        }
    }
}