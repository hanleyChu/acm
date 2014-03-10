import java.util.*;

public class pat1007
{
    public static void main(String[] args)
    {
        /*
         * testing = false // if we find the sum > 0, found = true
         * tmpMaxSum
         * for i = 0->k-1
         * 	sum+=a[i]
         * 	if(sum<0)
         * 		sum=0;
         * 		testing = false
         * 		
         * 		if(tmpMaxSum>maxSum ||(tmpMaxSum==maxSum && (tmpLast-tmpFirst)>(last-first)))
         *			fisrt = tmpFisrt
     	 *			last = tmpLast
     	 *			maxSum = tmpMaxSum
         *  else 
         *  	if(testing==false)
         *  		tmpFirst = tmpLast = i
         *  		tmpMaxSum = sum
         *  		testing = true
         *  	else
         *  		if(sum>=tmpMaxSum)
         *  			tmpLast = i;
         *  			tmpMaxSum = sum
         *  	
         * if(tmpMaxSum>maxSum)
         *		fisrt = tmpFisrt
     	 *		last = tmpLast
     	 *		maxSum = tmpMaxSum
         */
    	
    	Scanner in = new Scanner(pat1007.class.getClassLoader().getResourceAsStream("test"));
    	int k = in.nextInt();
    	
    	int[] a = new int[k];
    	for(int i=0;i<k;i++)
    		a[i] = in.nextInt();
    	
    	int maxSum = -1;
    	int first = -1;
    	int last = -1;
    	
    	int tmpMaxSum = -1;
    	int tmpFirst = -1;
    	int tmpLast = -1;
    	
    	int sum = 0;
    	boolean testing = false;
    	for(int i=0;i<k;i++)
    	{
    		sum+=a[i];
    		
    		if(sum<0)
    		{
    			testing = false;
    			sum=0;
    			
    			if(tmpMaxSum>maxSum ||(tmpMaxSum==maxSum && (tmpLast-tmpFirst)>(last-first)))
    			{
    				first = tmpFirst;
    				last = tmpLast;
    				maxSum = tmpMaxSum;
    			}
    		}
    		else
    		{
    			if(testing==false)
    			{
    				tmpFirst = tmpLast = i;
    				tmpMaxSum = sum;
    				testing = true;
    			}
    			else
    			{
    				if(sum>=tmpMaxSum)
    				{
    					tmpLast = i;
    					tmpMaxSum = sum;
    				}
    			}
    		}
    	}
    	
    	if(tmpMaxSum>maxSum ||(tmpMaxSum==maxSum && (tmpLast-tmpFirst)>(last-first)))
		{
			first = tmpFirst;
			last = tmpLast;
			maxSum = tmpMaxSum;
		}
    	
    	// all negative digit
    	if(first == -1)
    	{
    		System.out.print(0+" "+a[0]+" "+a[k-1]);
    	}
    	else
    	{
    		System.out.print(maxSum+" "+a[first]+" "+a[last]);
    	}
    }
}