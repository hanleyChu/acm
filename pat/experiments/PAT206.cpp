#include <iostream>
#include <cstdio>
#include <cstring>
using namespace std;

int main()
{
    int a,n;
    cin>>a;
    cin>>n;

    if(n==0)
        cout<<0;
    else
    {
        int* p = new int[n+1];
        int* q = (int*)memset(p, 0, sizeof(int)*(n+1));

        for(int i=0;i<n;++i)
        {
            p[i] += (n-i)*a;
            p[i+1] += p[i]/10;
            p[i] %= 10;
        }

        if(p[n] != 0)
            cout<<p[n];
        for(int i=n-1;i>=0;--i)
            cout<<p[i];

        delete p;
    }

    return 0;
}