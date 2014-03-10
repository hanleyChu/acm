import java.util.*;

public class pat1014
{
    public static void main(String[] args)
    {
        /*
        heap class
            func peek
            func peel
            func push
            func empty
            funct construct

        customer class
            int leavingTime
            int number
            int window

        n window
        m line capacity
        create customers
        create heap(capacit n*m)

        int[] timeConsumptions for time consumption of each window right now
        ArrayList[] emtpyWindows, a buffer to hold the available window number right now

        while(!heap.isEmpty())
        {
            emtpyWindows.clear();
            customer c = heap.peel();
            int leavingTime = c.leavingTime;
            emtpyWindows.add(c.window);

            // buffer all the customers with same leaving time
            while(!heap.isEmpty() && leavingTime == heap.peek().leavingTime)
                emtpyWindows.(heap.peel().window);

            // sort the empty window
            sort(emtpyWindows);
            for each w in emtpyWindows:
                if there is still a waiting customer:
                    customer come to window w, his leaving time is timeConsumptions[w]+service time
                    timeConsumptions[w]+=service time
                    heap.push(c)
        }
        emtpyWindows
        */

        Scanner in = new Scanner(pat1014.class.getClassLoader().getResourceAsStream("test"));

        int n = in.nextInt();
        int m = in.nextInt();
        int k = in.nextInt();
        int q = in.nextInt();

        int[] timeConsumptions = new int[n];

        Heap heap = new Heap(n*m);
        Customer[] customers = new Customer[k+1]; // 0 not used

        for(int i=1;i<=k;i++)
        {
            customers[i] = new Customer(i, -1, in.nextInt(), -1); // absent window number and leaving time
        }

        int j = 0;
        int l = m*n;
        for(int i=1;i<=l;i++)
        {
            timeConsumptions[j] += customers[i].serviceTime;

            customers[i].window = j;
            customers[i].leavingTime = timeConsumptions[j];

            heap.customers[i] = customers[i];

            j++;
            if(j == n)
                j=0;
        }

        heap.build();

        int p = n*m;
        ArrayList<Integer> emtpyWindows = new ArrayList<Integer>();
        while(!heap.isEmpty())
        {
            emtpyWindows.clear();
            Customer c = heap.peel();
            emtpyWindows.add(c.window);
            int leavingTime = c.leavingTime;

            while(!heap.isEmpty() && leavingTime == heap.peek().leavingTime)
                emtpyWindows.add(heap.peel().window);

            // sort the empty window
            Collections.sort(emtpyWindows);
            for(int w : emtpyWindows)
            {
                //there is still a waiting customer
                if(p<k)
                {
                    ++p;
                    timeConsumptions[w] += customers[p].serviceTime;
                    customers[p].leavingTime = timeConsumptions[w];
                    customers[p].window = w;

                    heap.push(customers[p]);
                }
            }
        }

        for(int i=1;i<=q;i++)
        {
            int qNum = in.nextInt();
            System.out.println(toTime(customers[qNum].leavingTime));
        }

    }

    public static String toTime(int time)
    {
        if(time > 540)
            return "Sorry";

        int hour = time/60+8;
        int min = time%60;

        return String.format("%02d:%02d",hour,min);
    }
}

class Customer
{
    public int leavingTime;
    public int number;
    public int window;
    public int serviceTime;

    public Customer(int n, int w, int st, int lt)
    {
        leavingTime = lt;
        serviceTime = st;
        number = n;
        window = w;
    }
}

class Heap
{
    public Customer[] customers;// 0 is not used
    public int capacity;
    public Heap(int capacity)
    {
        this.capacity = capacity;
        customers = new Customer[capacity+1];
    }

    public void justify(int i)
    {
        while(i<=capacity/2)
        {
            int smaller;
            if(i*2+1<=capacity)
            {
                if(customers[i*2].leavingTime<customers[i*2+1].leavingTime)
                    smaller = i*2;
                else
                    smaller = i*2+1;
            }
            else
                smaller = i*2;

            if(customers[i].leavingTime>customers[smaller].leavingTime)
            {
                swap(i, smaller);
                i = smaller;
            }
            else
                break;
        }


    }

    public void build()
    {
        for(int i = capacity/2;i>=1;i--)
            justify(i);
    }

    public void push(Customer c)
    {
        customers[++capacity] = c;

        int i = capacity;
        while(i/2>=1)
        {
            if(customers[i/2].leavingTime>customers[i].leavingTime)
            {
                swap(i/2,i);
                i /= 2;
            }
            else
                break;
        }
    }

    public Customer peek()
    {
        return customers[1];
    }

    public Customer peel()
    {
        Customer c = customers[1];
        customers[1] = customers[capacity];

        // decrease first, then justify
        capacity--;
        justify(1);
        return c;
    }

    private void swap(int i, int j)
    {
        Customer c = customers[i];
        customers[i] = customers[j];
        customers[j] = c;
    }

    public boolean isEmpty()
    {
        if(capacity == 1)
            return true;
        else
            return false;
    }
}