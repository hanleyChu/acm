#include  <iostream>
#include <fstream>
#include <cstring>
#include <cassert>
#include <cstdlib>
#include <iomanip>

#include <stack>

using namespace std;

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    string str;
    std::getline(cin, str);

    char *p = (char *)str.c_str();
    const char *cur;

    // all input string into a stack
    stack<const char*> inputStrs;
    cur = strtok(p, " ");
    while(cur!=NULL)
    {
        inputStrs.push(cur);
        cur = strtok(NULL," ");
    }

    //pop them in reverse order and calculate result
    stack<float> stk; 
    while(!inputStrs.empty())
    {
        cur = inputStrs.top();
        inputStrs.pop();
        // if length is 1 and is in * / - +, this is a operator
        if(strlen(cur)==1 && strchr("*/-+", *cur)!=NULL)
        {
            // in c++ , top is equal to peek but pop is equal to remove
            float a = stk.top();
            stk.pop();
            float b = stk.top();
            stk.pop();

            float r;
            switch(*cur)
            {
                case '-': r=a-b;break;
                case '+': r=a+b;break;
                case '/': 
                    if(b==0)
                    {
                        cout<<"ERROR";
                        return 0;
                    }
                    else
                    {
                        r=a/b;
                        break;
                    }
                case '*': r=a*b;break;
                default:
                    assert(false);
            }
            stk.push(r);
        }
        else
        {
            float num = atof(cur);
            stk.push(num);
        }
    }

    cout<<fixed<<setprecision(1)<<stk.top();
    return 0;

}