import java.util.*;

public class pat1006
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1006.class.getClassLoader().getResourceAsStream("test"));

        /*
        load data
        for each line i = 0 ->length-1
            parts = line.splits
            ids[i] = parts[0] as String
            it[i] = parts[1] as int
            ot[i] = parts[2] as int

        int[] index = new index[]; 
        fill index from 0->length-1;
        sort index by it asc,select ids[0]
    
        fill index array for reseting
        sort index by ot asc, select ids[n-1]
        */
        int n = in.nextInt();
        String[] ids = new String[n];
        int[] it = new int[n];
        int[] ot = new int[n];
        
        in.nextLine();
        for(int i=0;i<n;i++)
        {
            String line = in.nextLine();
            String[] parts = line.split(" ");
            ids[i] = parts[0];

            String[] strTime = parts[1].split(":");
            it[i] = Integer.valueOf(strTime[0])*3600
            +Integer.valueOf(strTime[1])*60
            +Integer.valueOf(strTime[2]);

            strTime = parts[2].split(":");
            ot[i] = Integer.valueOf(strTime[0])*3600
            +Integer.valueOf(strTime[1])*60
            +Integer.valueOf(strTime[2]);
        }

        int[] idx = new int[n];
        for(int i=0;i<n;i++)
            idx[i] = i;

        quickSort(idx,it);
        System.out.print(ids[idx[0]]+" ");

        for(int i=0;i<n;i++)
            idx[i] = i;
        quickSort(idx,ot);
        System.out.print(ids[idx[n-1]]);

    }

    public static void quickSort(int[] idx, int[] time)
    {
        sort(idx,time,0,idx.length-1);
    }

    private static void sort(int[] idx, int[] time, int s, int e)
    {

        if(s>=e)
            return;

        int i=s-1;
        int j=s-1;
        int k=s;

        int t = time[e];
        for(;k<e;j++)
        {
            if(time[k]<t)
            {
                i++;
                int tmp = idx[i];
                idx[i] = idx[k];
                idx[k] = tmp;
            }
            j = k;
            k++;
        }

        // swap idx[e] with idx[++i]
        i++;
        int tmp = idx[e];
        idx[e] = idx[i];
        idx[i] = tmp;

        sort(idx,time,s,i-1);
        sort(idx,time,i+1,e);
    }
}