#include <iostream>
#include <fstream>
#include <sstream>
#include <map>
using namespace std;


/*
    parse input string into map1 map2(key = power, value=coef)
    for key1,value1 in map1:
        for key2,value2 in map2:
            value = value1*value2
            key = key1+key2

            if key in map3:
                value = map3.get(key)+value;
            map3.put(key,value)

    sort map3 by key desc
    print map3

    for key1,value1 in map1:
        if key1 in map2:
            value = map2.get(key1)+value1
        else
            value = value1
        map2.put(key1, value)

    sort map2 by key desc
    print map2
    */
int main()
{
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    map<int,int> map1;
    map<int,int> map2;
    map<int,int> map3;

    int n;
    cin>>n;
    while(n)
    {
        int power;
        int coef;
        cin>>coef;
        cin>>power;
        map1.insert(map<int, int>::value_type(power, coef));
        --n;
    }

    cin>>n;
    while(n)
    {
        int power;
        int coef;
        cin>>coef;
        cin>>power;
        map2.insert(map<int, int>::value_type(power, coef));
        --n;
    }

    for(map<int, int>::iterator iter1 = map1.begin();iter1!=map1.end();++iter1)
    {
        for(map<int,int>::iterator iter2 = map2.begin();iter2!=map2.end();++iter2)
        {
            int power = iter1->first + iter2->first;
            int coef = iter1->second * iter2->second;

            int coef_value;
            map<int,int>::iterator iter = map3.find(power);
            if(iter == map3.end())
                coef_value = coef; // not found then set value for  the first time
            else
                coef_value = iter->second + coef; // if found , increament by the value

            map3[power] = coef_value;
        }
    }

    // output the multiple result
    stringstream ss;
    for(map<int,int>::reverse_iterator iter = map3.rbegin();iter!=map3.rend();++iter)
    {
        if(iter->second != 0)
            ss<<iter->second<<" "<<iter->first<<" ";
    }

    string multStr = ss.str();
    if(!multStr.empty())
        cout<<multStr.substr(0,multStr.length()-1);
    else
        cout<<"0 0";

    //  calculate the acumulate result and output it
    for(map<int,int>::iterator iter = map1.begin();iter!=map1.end();++iter)
    {
        map<int,int>::iterator map2Iter = map2.find(iter->first);
        //not found
        if(map2Iter == map2.end())
        {
            map2[iter->first] = iter->second;
        }
        else
        {
            map2[iter->first] = iter->second +map2Iter->second;
        }
    }

    cout<<endl;

    ss.str("");
    if(map2.empty())
    {
        ss<<"0 0 ";
    }
    else
    {
        for(map<int,int>::reverse_iterator iter = map2.rbegin();iter!=map2.rend();++iter)
        {
            if(iter->second != 0)
                ss<<iter->second<<" "<<iter->first<<" ";
        }
    }

    string plusStr = ss.str();
    if(!plusStr.empty())
        cout<<plusStr.substr(0,plusStr.length()-1);
    else
        cout<<"0 0";

    return 0;
}