import java.util.*;
import java.io.*;

public class pat1003
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(new BufferedInputStream(pat1003.class.getClassLoader().getResourceAsStream("test")));

        int cityCount;
        int roadCount;
        int curCity;
        int emrCity;

        cityCount = in.nextInt();
        roadCount = in.nextInt();
        curCity = in.nextInt();
        emrCity = in.nextInt();

        int[] teams= new int[cityCount];
        int[][] roads = new int[cityCount][cityCount];

        // input teams
        for(int i=0;i<cityCount;++i)
            teams[i] = in.nextInt();

        //input roads
        for(int i=0;i<roadCount;++i)
        {
            int a = in.nextInt();
            int b = in.nextInt();
             roads[a][b] = roads[b][a] = in.nextInt();
        }

        /*
            dijkstra algorithm
            for i = 1 -> cityCount - 1
                select min one city u from dis[city] where city is not tranversed
                mark it as tranversed
                for each city v around the city u
                    dis = dis[u]+roads[u][v]
                    if dis < dis[v]
                        dis[v] = dis
                        teamsTotal[v] = teamsTotal[u] + teams[v]
                    else if dis == dis[v] && teamsTotal[u]+teams[v]>teamsTotal[v]
                        teamsTotal[u] = teams[v]>teamsTotal[v]
        */

        // initialize
        int[] teamsTotal = new int[cityCount];
        int[] dis = new int[cityCount];
        boolean[] tranversed = new boolean[cityCount];

        teamsTotal[curCity] = teams[curCity];
        
        Arrays.fill(dis, Integer.MAX_VALUE);
        dis[curCity] = 0;

        // calculate n-1 shortest path excluding the current one
        for(int i = 1;i<cityCount;i++)
        {
            // select  city with shortest path 
            int minCity = 0;
            int minDis = Integer.MAX_VALUE;
            for(int j = 0;j<cityCount;j++)
            {
                if(dis[j]<minDis && tranversed[j] == false)
                {
                    minCity = j;
                    minDis = dis[j];
                }
            }

            tranversed[minCity] = true;

            for( int k = 0;k<cityCount;k++)
            {
                int tmpDis = dis[minCity] + roads[minCity][0];
                if(tmpDis<dis[k])
                {
                    dis[k] = tmpDis;
                    teamsTotal[k] = teamsTotal[minCity]+teams[k];
                }
                else if(tmpDis == dis[k] && teamsTotal[k]<teamsTotal[minCity]+teams[k])
                {
                    teamsTotal[k] = teamsTotal[minCity]+teams[k];
                }
            }
        }

        System.out.print(dis[emrCity]+" "+teamsTotal[emrCity]);
    }
}
