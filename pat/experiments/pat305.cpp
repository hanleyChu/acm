#include <iostream>
#include <fstream>
using namespace std;

/*
    create array a[] containing k items
    for i = 0->k-1 input item:
        if no more input:
            print NULL
            return 0;
        else
            a[k] = input item

    set cur = k-1
    while(input item>0)
        cur = (cur+1)%k;
        a[cur] = input item

    // cur+1 is the last k-th item
    print a[cur+1]
    */
int main()
{
    std::ios::sync_with_stdio(false);
    
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    int k;
    cin>>k;

    int *a;
    a = new int[k];

    int tmp;
    for(int i=0;i<k;++i)
    {
        cin>>tmp;

        if(tmp<0)
        {
            cout<<"NULL";
            delete[] a;
            return 0;
        }
        else
        {
            a[i] = tmp;
        }
    }

    int cur = k-1;
    while(true)
    {
        cin>>tmp;
        cur = (cur+1)%k;
        if(tmp>=0)
        {
            a[cur] = tmp;
        }
        else
        {
            cout<<a[cur];
            break;
        }
    }

    delete[] a;

    return 0;
}