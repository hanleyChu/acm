import java.util.*;

class Station
{
    public float payment = Float.MAX_VALUE;
    public float price = -1;
    public float distance = -1;
    public boolean done = false;
    
    public String toString(){
    	return String.format("payment:%f distance:%f",payment,distance);
    }
}

public class pat1033
{
    public static void main(String[] args)
    {
        Scanner in = new Scanner(pat1033.class.getClassLoader().getResourceAsStream("test"));

        float c = in.nextFloat();
        float d = in.nextFloat();
        float da = in.nextFloat();
        int n = in.nextInt();

        /*
        Station
            payment max value
            distance -1
            price -1

        Station[] s = Station[n+1] // stations+city
        fill station 0-n-1 and station[n]

        init station[0]

        while true:
            chose min payment station cur from stations

            if cur is destination && cur.payment != float max value:
                print cur.payment
                break

            calculate the  stations ss to which current station can reach

            if ss is empty:
                max_dis = cur.distance + c/da
                print max_dis

            for each sation t in ss:
                relax(t):
                    if not destination:
                        new_pay= ((t.distance-cur.distance)/da)*t.price+cur.payment
                        if(t.payment>new_pay)
                            t.payment = new_pay
                    else
                        if(t.payment>cur.payment)
                            t.payment = cur.payment
                            */

        Station[] s = new Station[n+1];
        for(int i=0;i<n;i++)
        {
            Station n_station = new Station();
            
            n_station.price = in.nextFloat();
            n_station.distance = in.nextInt();

            s[i] = n_station;
        }
        s[n] = new Station();
        s[n].distance = d;
        
        //sort
        Arrays.sort(s, new Comparator<Station>(){
            @Override
            public int compare(Station s1, Station s2){
                return (s1.distance-s2.distance)<0?-1:1;
            }
        });
        
        //init
        s[0].payment = s[0].price*c;
        
        float max_length = c*da;

        while(true)
        {
            float min_pay = Float.MAX_VALUE;
            int min_pay_i = 0;
            for(int i=0;i<=n;++i)
            {
                if(s[i].done == false && s[i].payment<min_pay)
                {
                    min_pay = s[i].payment;
                    min_pay_i = i;
                }
            }

            s[min_pay_i].done = true;

            // found
            if(min_pay_i == n && s[n].payment != Float.MAX_VALUE)
            {
                System.out.print(s[n].payment);
                break;
            }


            Station cur = s[min_pay_i];

            int count = 0;
            for(int i=min_pay_i+1;i<=n;++i)
            {
                if((s[i].distance-cur.distance)<=max_length)
                    count++;
            }

            // can not reach any city
            if(count==0)
            {
                float max_dis = cur.distance + c/da;
                System.out.print("The maximum travel distance = "+max_dis);
                break;
            }

            for(int i=1;i<=count;i++)
            {
                int t_i = i+min_pay_i ;
                Station t = s[t_i];
                if(t_i != n)
                {
                    float new_pay= ((t.distance-cur.distance)/da)*t.price+cur.payment; // fill it, calculate the total costs
                    if(t.payment>new_pay)
                        t.payment = new_pay;
                }
                else
                {
                    if(t.payment>cur.payment)
                        t.payment = cur.payment;
                }
            }
        }


    }
}