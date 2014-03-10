#include <iostream>
#include <fstream>
#include <sstream>
#include <string>
using namespace std;

int main()
{
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    string s1,s2;
    getline(cin,s1);
    getline(cin,s2);

    stringstream ss1(s1);
    stringstream ss2(s2);

    int a,b;
    ss1>>a;
    ss2>>b;

    stringstream ss;

    if(a==-1 || b==-1)
    {
        cout<<"NULL";
    }
    else
    {
        while(true)
        {
            if(a<b)
            {
                while(a<b && a!=-1)
                {
                    ss1>>a;
                    if(a==b)
                    {
                        ss<<a<<" ";
                        while(a==b)ss1>>a;
                    }
                }

                if(a==-1)
                    break;
            }
            else if(a>b)
            {
                while(a>b && b!=-1)
                {
                    ss2>>b;
                    if(a==b)
                    {
                        ss<<b<<" ";
                        while(a==b)ss2>>b;
                    }
                }

                if(b==-1)
                    break;
            }
            else
            {
                ss<<a<<" ";
                ss1>>a;
                ss2>>b;
            }
        }

        string result = ss.str();
        if(result.empty())
            cout<<"NULL";
        else
            cout<<result.substr(0, result.length()-1);
    }

    return 0;
}