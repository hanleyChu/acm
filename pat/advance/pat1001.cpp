#include <iostream>
#include <stack>
using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);

    stack<char> s;
    int a,b;
    cin>>a;
    cin>>b;

    int sum = a+b;

    if(sum == 0)
    {
        cout<<"0";
        return 0;
    }

    if(sum<0)
    {
        cout<<"-";
        sum = -sum;
    }

    int count = 0;
    while(sum>0)
    {
        s.push((char)(sum%10+'0'));
        sum/=10;
        ++count;

        if(count == 3 && sum>0)
        {
            s.push(',');
            count = 0;
        }
    }

    //print
    while(!s.empty())
    {
        cout<<s.top();
        s.pop();
    }


    return 0;
}