#include <iostream>
#include <fstream>
#include <cstring>
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    int n,m;
    cin>>n>>m;

    int map[501];
    memset(map, 0, sizeof(int)*501);

    int k = m/2;
    for(int i=0;i<n;++i)
    {
        int t;
        cin>>t;
        map[t]++;
    }
    for(int i=1;i<=k;++i)
    {
        if(map[i]>0)
        {
            if(m-i<=500 && i!=m-i && map[i]>0 && map[m-i]>0)
            {
                cout<<i<<" "<<m-i;
                return 0;
            }

            if(i==m-i && map[i]>=2)
            {
                cout<<i<<" "<<i;
                return 0;
            }
        }
    }

    cout<<"No Solution";

    return 0;
}