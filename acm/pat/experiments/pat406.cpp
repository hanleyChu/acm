#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

/*
strut Node
{
    int v;
    Node* l;
    Node *r;
}
if n=1 then output it 
if input[1]>=input[0], mirrorBinaryTree = true
    else mirrorBinaryTree = false
recurisively construct binary tree,
less than root is left subtree
greater than or equal with root is right subtree
if not abide by this rule, this is not a binary tree
*/

class Node
{
public:
    int value;
    Node *r,*l;

    Node();
    Node(int v, Node *r, Node*l);

    void post_order_tranverse(stringstream &ss);

    static Node* construct_tree(Node *root, int n, bool isMirrorTree);
};

Node::Node():value(0),r(NULL),l(NULL){}
Node::Node(int v, Node *r, Node*l):value(v),r(r),l(l){}

void Node::post_order_tranverse(stringstream &ss)
{
    if(this->l!=NULL)
    {
        this->l->post_order_tranverse(ss);
    }
    if(this->r!=NULL)
    {
        this->r->post_order_tranverse(ss);
    }

    ss<<this->value<<' ';
}

/*
* the array start point with following n nodes element is used for tree constrction
*/
Node*  Node::construct_tree(Node *start, int n, bool isMirrorTree)
{
    if(n==1)
        return start;

	Node *p = start+1;
    int i = 1;

    if(isMirrorTree == false)
    {
        while(i<n && p->value<start->value)
        {
            ++i;
            ++p;
        } 

        // check if they can construct a binary tree
        int j = i;
        while(j<n)
        {
            if(start[j].value<start[0].value)
                throw -1;
            j++;
        }
	}
	else
	{
		while(i<n && p->value>=start->value)
        {
            ++i;
            ++p;
        } 

        // check if they can construct a binary tree
        int j = i;
        while(j<n)
        {
            if(start[j].value>=start[0].value)
                throw -1;
            j++;
        }
	}

    // reach the end
    if(i==n)
    {
        start->l = construct_tree(start+1, i-1, isMirrorTree);
    }
	else if(i==1)
	{
		start->r = construct_tree(start+1, n-1, isMirrorTree);
	}
    else
    {
        start->l = construct_tree(start+1, i-1, isMirrorTree);
        start->r = construct_tree(start+i, n-i, isMirrorTree);
    }
   

    return start;
}



int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    stringstream ss;

    int n;
    cin>>n;
    if(n==1)
    {
        int in;
        cin>>in;
        cout<<"YES"<<endl;
        cout<<in;
        return 0;
    }

    Node *root = new Node[n];
    bool isMirrorTree = false;

    int i=0;
    while(i<n)
    {
        cin>>root[i].value;
		i++;
    }

    if(root[1].value>=root[0].value)
        isMirrorTree = true;
    else
        isMirrorTree = false;

    //construct tree
    try
    {
        Node::construct_tree(root, n, isMirrorTree);
        cout<<"YES"<<endl;
        root->post_order_tranverse(ss);
        string result = ss.str();
        cout<<result.substr(0, result.length()-1);
    }
    catch(int &value)
    {
        if(value == -1)
            cout<<"NO";
    }

    delete[] root;
    return 0;
}