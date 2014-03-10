#include <cmath>
#include <iostream>
#include <sstream>
using namespace std;

bool is_prime(int n);

int main()
{

    long n;
    cin>>n;
    cout<<n<<'=';
    if(n == 1)
        cout<<1;

    if(n == 2)
        cout<<2;

    if(n == 3)
        cout<<3;

    stringstream ss;
    if(n>3)
    {
        int count=0;

        // only odd number need to be handled
        long m = (long)sqrt(n);
        for(long i=2;i<=m;i+=1)
        {
            if(i%2==0 && i!=2)
                continue;

            if(is_prime(i))
            {
                while(n%i==0)
                {
                    n/=i;
                    count++;
                }

                if(count>0)
                {
                    if(count==1)
                        ss<<'*'<<i;
                    else
                        ss<<'*'<<i<<'^'<<count;
                    count=0;
                    // recompute the terminal number
                    m = (long)sqrt(n);
                }
            }
        }
        // add the rest number
        if(n!=1)
            ss<<'*'<<n;

        cout<<ss.str().substr(1);
    }

    

    return 0;
}

bool is_prime(int n)
{
    int m = (int)sqrt(n);
    for(int i=1;i<=m;i+=2)
    {
        if(i==1)
            continue;
        if(n%i==0)
            return false;
    }
    return true;
}