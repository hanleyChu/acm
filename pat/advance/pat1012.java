import java.util.*;

class Stu
{
    public String id;
    public int c;
    public int m;
    public int e;

    public float a;

    public Stu(String id, int c,int m,int e)
    {
        this.id = id;
        this.c = c;
        this.m =m ;
        this.e = e;

        this.a = (float)(c+m+e)/3;
    }
    
    @Override
    public boolean equals(Object obj)
    {
    	return obj == this;
    }
}

public class pat1012
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1012.class.getClassLoader().getResourceAsStream("test"));

        int n,k;
        n = in.nextInt();
        k = in.nextInt();

        Stu[]  stus = new Stu[n];
        Map<String,Stu> map = new HashMap<String,Stu>();
        for(int i=0;i<n;++i)
        {
        	String id = in.next();
            stus[i] = new Stu(id,in.nextInt(),in.nextInt(),in.nextInt());
            map.put(id, stus[i]);
        }
        
        Comparator<Stu> c_c = new Comparator<Stu>(){
        	@Override
        	public int compare(Stu o1, Stu o2)
        	{
        		return -(o1.c-o2.c);
        	}
        };
        Stu[] stus_c = Arrays.copyOf(stus, n);
        Arrays.sort(stus_c, c_c);
        
        Comparator<Stu> c_m = new Comparator<Stu>(){
        	@Override
        	public int compare(Stu o1, Stu o2)
        	{
        		return -(o1.m-o2.m);
        	}
        };
        Stu[] stus_m = Arrays.copyOf(stus, n);
        Arrays.sort(stus_m, c_m);
        
        Comparator<Stu> c_e = new Comparator<Stu>(){
        	@Override
        	public int compare(Stu o1, Stu o2)
        	{
        		return -(o1.e-o2.e);
        	}
        };
        Stu[] stus_e = Arrays.copyOf(stus, n);
        Arrays.sort(stus_e, c_e);
        
        Comparator<Stu> c_a = new Comparator<Stu>(){
        	@Override
        	public int compare(Stu o1, Stu o2)
        	{
        		if(o1.a>o2.a)
        			return -1;
        		else if(o1.a == o2.a)
        			return 0;
        		else
        			return 1;
        	}
        };
        Stu[] stus_a = Arrays.copyOf(stus, n);
        Arrays.sort(stus_a, c_a);
        
        char[] chars = new char[]{'A','C','M','E'};
        int[] ranks = new int[4];
        while(k>0)
        {
        	String id = in.next();
        	Stu stu = map.get(id);
        	if(stu == null)
        		System.out.println("N/A");
        	else
        	{
        		int idx_a = find(stus_a,c_a,stu);
        		
        		if(idx_a<0)
        			System.out.println("N/A");
        		else
        		{
        			int idx_c = find(stus_c,c_c,stu);
        			int idx_m = find(stus_m,c_m,stu);
        			int idx_e = find(stus_e,c_e,stu);
        			
        			ranks[0] = idx_a;
        			ranks[1] = idx_c;
        			ranks[2] = idx_m;
        			ranks[3] = idx_e;
        			
        			int max_rank_idx = 0;
        			for(int j = 1;j<4;j++)
        			{
        				if(ranks[j]<ranks[max_rank_idx])
        					max_rank_idx = j;
        			}
        			
        			System.out.println((ranks[max_rank_idx]+1)+" "+chars[max_rank_idx]);
        		}
        		
        		
        	}
        	
        	k--;
        }
    }
    
    public static int find(Stu[] stus, Comparator<Stu> c, Stu key)
    {
    	int idx = Arrays.binarySearch(stus, key, c);
    	
    	if(stus[idx].equals(key))
    		return idx;
    	else
    	{
    		int i = idx-1;
    		while(i>=0)
    		{
    			if(stus[i].equals(key))
    				return i;
    			i--;
    		}
    		
    		i = idx+1;
    		while(i<stus.length)
    		{
    			if(stus[i].equals(key))
    				return i;
    			i++;
    		}
    		
    		return -1;
    	}
    }
}