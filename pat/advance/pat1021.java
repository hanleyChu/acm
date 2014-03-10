import java.util.*;

class UnionFindSet
{
    public int[] a;
    public int count;
    public int n;
    public int find(int i)
    {
        while(i!=a[i])
        {
            i = a[i] = a[a[i]];
        }
        return i;
    }

    public void union(int i, int j)
    {
        int m = find(i);
        int n = find(j);

        if(m==n)
            return;

        a[m] = n;
        count--;
    }

    public void init()
    {
        for(int i=1;i<=n;i++)
        {
            a[i] = i;
        }

        this.count = n;

    }

    public UnionFindSet(int n)
    {
        this.n = n;
        this.a = new int[n+1];
        this.init();
    }
}

public class pat1021
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1021.class.getClassLoader().getResourceAsStream("test"));

        /*
        fisrt of all ,we use union find set to check the connection of given graphic
        if a connected and acyclic graphic, 
            then pick a vertex, apply dfs to find the farest other vertex,
            finnally again use dfs to find the deepest root(A and the farest vertex against A)
            */

        int n = in.nextInt();
        int k = n-1;
        int[][] pairs = new int[n-1][2];
        for(int i=0;i<k;i++)
        {
            pairs[i][0] = in.nextInt();
            pairs[i][1] = in.nextInt();
        }

        UnionFindSet ufs = new UnionFindSet(n);
        for(int i=0;i<k;i++)
        {
            ufs.union(pairs[i][0], pairs[i][1]);
        }
        if(ufs.count>1)
        {
            System.out.printf("Error: %d components", ufs.count);
            return;
        }

        // intialize adjacent table in an array
        LinkedList[] adjs = new LinkedList[n+1];
        int[] dis = new int[n+1];
        boolean[] visited = new boolean[n+1];
        for(int i=0;i<k;i++)
        {
            int x = pairs[i][0];
            int y = pairs[i][1];

            if(adjs[x] == null)
                adjs[x] = new LinkedList<Integer>();
            if(adjs[y] == null)
                adjs[y] = new LinkedList<Integer>();

            adjs[x].add(y);
            adjs[y].add(x);
        }

        // pick one
        int x = 1;
        Stack<Integer> stack = new Stack<Integer>();
        //find the farest
        stack.push(x);
        while(!stack.isEmpty())
        {
            int e = stack.pop();
            int d = dis[e]+1;
            visited[e] = true;
            if(adjs[e] != null)
            {
                for(int t:(LinkedList<Integer>)adjs[e])
                {
                    if(visited[t] == false)
                    {
                        dis[t] = d;
                        stack.push(t);
                    }
                }
            }
        }
        int maxDisIndex = 1;
        int maxDis = dis[1];
        for(int i=1;i<=n;++i)
        {
            if(maxDis<dis[i])
            {
                maxDis = dis[i];
                maxDisIndex = i;
            }
        }

        // maxDisIndex is the farest one
        // dfs on it
        stack.clear();
        Arrays.fill(dis,0);
        Arrays.fill(visited,false);
        stack.push(maxDisIndex);
        while(!stack.isEmpty())
        {
            int e = stack.pop();
            int d = dis[e]+1;
            visited[e] = true;
            if(adjs[e]!=null)
            {
                for(int t:(LinkedList<Integer>)adjs[e])
                {
                    if(visited[t] == false)
                    {
                        dis[t] = d;
                        stack.push(t);
                    }
                }
            }
        }

        // find the max Distance
        List<Integer> buf = new LinkedList<Integer>();
        maxDis = 0;
        for(int i=1;i<=n;i++)
            if(dis[i]>maxDis)
                maxDis = dis[i];
        for(int i=1;i<=n;++i)
            if(dis[i]==maxDis || dis[i] == 0)
                buf.add(i);
        Integer[] a = buf.toArray(new Integer[0]);
        Arrays.sort(a);
        for(int r:a)
        {
            System.out.println(r);
        }

    }
}