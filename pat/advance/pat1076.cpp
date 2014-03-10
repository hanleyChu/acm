#include <cstring>
#include <iostream>
#include <fstream>
#include <list>
#include <stack>

using namespace std;

class Person
{
public:
    int level;
    int visited;
    list<Person*> followers;
	int num;

    Person();
};

Person::Person():level(-1),visited(false)
{
}


int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("E:/project/github/acm/pat/advance/test");
    cin.rdbuf(ifs.rdbuf());

    int n,l;
    cin>>n>>l;
    Person *persons = new Person[n+1];

	//for(int i=1;i<=n;i++)
 //   {
	//	persons[i].num = i;
 //   }

    for(int i=1;i<=n;++i)
    {
        int k;
        cin>>k;
        while(k>0)
        {
            int f;
            cin>>f;
            persons[f].followers.push_back(&persons[i]);
            k--;
        }
    }

    int m;
    cin>>m;
    list<Person*> stack;
    int count;
    while(m>0)
    {
        int q;
        cin>>q;

        // clear
        count = 0;
        stack.clear();
        for(int i=1;i<=n;i++)
        {
            persons[i].visited = false;
            persons[i].level = 0;
            persons[i].num = i;
        }

        //1 init root
        persons[q].visited = true;
        persons[q].level = 0;
        stack.push_back(&persons[q]);
        while(!stack.empty())
        {
            Person *p = stack.back();
            stack.pop_back();

            int nextLevel = p->level+1;
            if(nextLevel<=l)
            {
                for(list<Person*>::iterator it = p->followers.begin();it!=p->followers.end();it++)
                {
                    //2 if not visited, visit it and set level and visited
                    if((*it)->visited == false)
                    {
                        count++;
                        (*it)->level = nextLevel;
                        (*it)->visited = true;

                        //3 push it
                        stack.push_back(*it);
                    }
                }
            }
        }

        cout<<count<<endl;

        m--;
    }

    delete[] persons;
    return 0;
}