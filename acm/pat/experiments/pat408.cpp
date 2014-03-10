#include <iostream>
#include <fstream>
#include <string>
#include <cstring>
#include <map>
#include <stack>

using namespace std;

class FileNode
{
public:
    string name;
    bool is_file;
    int layer;

    FileNode(const string &name, bool is_file, int layer):name(name),is_file(is_file),layer(layer){}
};

struct Comparator
{
    int operator(FileNode f1, FileNode f2) const
    {
        int r = (int)f1.is_file - (int)f2.is_file;

        if(r == 0)
            return f1.name.compare(f2.name);
        else
            return r;
    }
};

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    int n;
    cin>>n;

    // define the tree
    FileNode root("root", false,0);
    map<FileNode, void, Comparator> rootContent;

    while(n>0)
    {
        string str;
        getline(cin, str);

        char *parts;
        map<FileNode, void, Comparator> *cur = &rootContent;
        parts = strtok(parts,"\\");
        int i=1;
        while(parts!=NULL)
        {
            const char *p = parts;
            FileNode newNode(string(p),false,i);

            map<FileNode, void, Comparator>::iterator it = (*cur).find(newNode);
            // found
            if(it!=(*cur).end())
            {
                cur = &(it->second);
            }
            else
            {
                map<FileNode, void, Comparator> content;
                (*cur)[newNode] = content;
                cur = &content;
            }

            parts = strtok(NULL, "\\");
            i++;
        }

        n--;
    }

    stack<pair<FileNode, void>> s;
    s.push(pair<FileNode, void>(root,rootContent));

    while(!s.empty())
    {
        pair<FileNode,void> p = s. top();
        s.pop();

        for(int i=p.first.layer;i>0;--i)
            cout<<" ";
        cout<<p.first.name;

        if(!p.first.is_file)
        {
            for(map<FileNode, void, Comparator>::iterator it = p.second.begin(); it != p.second.end(); ++it)
                s.push(pair<FileNode,void>(it->first, it->second));
        }
    }


    return 0;
}