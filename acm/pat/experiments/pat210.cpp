#include <iostream>
#include <cstring>
using namespace std;

int main()
{
    //pn->pirate,dn->diamond
    int pn,dn;
    cin>>dn>>pn;

    // pn>3, use to hold the diamonds each pirate has, but p[0] is not used
    int *p = new int[pn+1];
	memset(p, 0, sizeof(int)*(pn+1));

    // used for the bribe flag
    bool *flag = new bool[pn+1];
    memset(flag, false, sizeof(bool)*(pn+1));

    if(pn==3)
        cout<<dn-1;
    else
    {
        int boss = pn-3;
        p[pn-1] = 1;
        p[pn] = 0;

        while(boss>0)
        {
            // how many pirate will allocate the diamond
            int numberOfPirates = pn-boss+1;

            // the number of other voters must be at least half of the whole
            int leastNumber = numberOfPirates/2;
            
            int count=0;
            int i=0;
            int j=boss+2; // boss+1 always deny boss excpet the last thrid one
            while(true)
            {
                // we give another one diamond to the least diamond owners
                if(p[j]==i && flag[j]==false)
                {
                    p[j]++;
                    flag[j]=true; // the pirate is bribed
                    count++;

                    // we have the enough bribees
                    if(count==leastNumber)
                    {
                        int k = boss+2;
                        while(k<=pn)
                        {
                            // do not bribe the other pirate, claer them
                            if(flag[k]==false)
                                p[k] = 0;

                            flag[k]=false;
                            k++;
                        }
                        break;
                    }
                }

                ++j;
                if(j>pn)
                {
                    j=boss+2;
                    i++;
                }
            }

            boss--;
        }

        // summation
        int t = 2;
        int sum=0;
        while(t<=pn)
        {
            sum+=p[t];
            t++;
        }

        cout<<dn-sum;
    }

    delete[] p,flag;
}