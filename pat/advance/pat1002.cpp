#include <iostream>
#include <fstream>
#include <sstream>
#include <iomanip>
#include <cstdio>
#include <cstring>

using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    float a[1001];
    memset(a,0,sizeof(float)*1001);
    int k;
    cin>>k;

    int e;
    while(k>0)
    {
        cin>>e;
        cin>>a[e];
        k--;
    }

    float tmp;
    cin>>k;
    while(k>0)
    {
        cin>>e;
        cin>>tmp;
        a[e]+=tmp;
        k--;
    }

    stringstream ss;
    ss<<setiosflags(ios::fixed)<<setprecision(1);
    k=1000;
    int count = 0;
    while(k>=0)
    {
        if(a[k]!=0)
        {
            ss<<' '<<k<<' '<<a[k];
            count++;
        }
        k--;
    }

    string result = ss.str();
    char prefix[5];
    sprintf(prefix,"%d",count);
    cout<<prefix<<result;

    return 0;
}