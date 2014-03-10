#include <cstdio>
#include <string>
#include <map>

using namespace std;

class Node
{
public:
    Node *next;
    Node *pre;
    string *next_id;
    int v;
    string *id;

    Node(int v, string *id, string *next_id);
};

Node::Node(int v, string *id, string *next_id):v(v),id(id),next_id(next_id),next(NULL),pre(NULL){}

int main()
{
	freopen( "F:/GitHub/acm/pat/advance/test", "r", stdin );
    // input
    char id[6];
    int n;
    int k;
    scanf("%s %d %d", id, &n, &k);

    string head_id(id);
    map<string, Node*> m;

    int i = n;
    char next_id_cstr[6];
    int v;

    string *cur_id;
    string *next_id;
    while(i>0)
    {
        scanf("%s %d %s", id, &v, next_id_cstr);
        cur_id = new string(id);
        next_id = new string(next_id_cstr) ;
        m[*cur_id] = new Node(v, cur_id, next_id);
        i--;
    }

    for(map<string, Node*>::iterator it = m.begin();it!=m.end();it++)
    {
        Node *cur_node = it->second;
        Node *next_node = NULL;
       map<string, Node*>::iterator r_it = m.find(*(cur_node->next_id));

       if(r_it!=m.end())
       {
            next_node = r_it->second;
        }
        next_node->pre = cur_node;
        cur_node->next = next_node;
    }

    Node *head = m.find(head_id)->second;
    while(head!=NULL)
    {
        printf("%s %d %s", head->id->c_str(), head->v, head->next_id->c_str());
        head = head->next;
    }

}