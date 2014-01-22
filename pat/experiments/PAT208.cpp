#include <iostream>
using namespace std;

class TNode
{
public:
    union
    {
        int opnd;
        char optr;
    }op;

    TNode *left = NULL;
    TNode *right = NULL;

    float value();

    static void in_order_tranverse();
    static float operate(char optr, int a, int b);

};

float TNode::value()
{
    if(this->left == NULL && this->right == NULL)
        return this->opnd;
    else 
        return operate(optr, left->value(), right->value());
}

static void TNode::in_order_tranverse(const TNode &root)
{
    if(root.left == NULL && root.right == NULL)
        cout<<root.opnd;
    else
    {
        cout<<'(';
        TNode::in_order_tranverse(root.left);
        cout<<this->optr;
        TNode::in_order_tranverse(root.right);
        cout<<')';
    }

}


static float TNode::operate(char optr, int a, int b)
{
    switch(optr)
    {
        case '*': return a*b;
        case '/': return (float)a/b;
        case '-': return a-b;
        case '+': return a+b;

        default: return 0;
    }
}

bool solve_tree_one(TNode (&optr_nodes)[3], int num[], int n)
{
    static char optrs[4] = {'*','/','+','-'};
    // we solve the problem on the spesific number permutation
    if(n==1)
    {
        // declare the nodes corresponding to num array
        TNode opnd_nodes[4];
        for(int i=0; i<4; ++i)
            opnd_nodes[i] = num[i];

        // assign to the tree
        // tree type one
        optr_nodes[1].left = opnd_nodes[0];
        optr_nodes[1].right = opnd_nodes[1];
        optr_nodes[2].left = opnd_nodes[2];
        optr_nodes[2].right = opnd_nodes[3];

        // tranverse all the operators' permutation, return true if anyone satisify
        for(int i=0; i<4; ++i)
            for(int j=0; j<4;++j)
                for(int k=0; k<4;++k)
                    if(optr_nodes[0].value()==24)
                        return true;
        return false;
    }

    for(int i=0; i<n; ++i)
    {
        // copy the original permutation
        int t_num[4];
        for(int j=0; j<4;++j)
            t_num[j] = num[j];

        // swap the ith node with last node, then sort the 1~n-1 nodes recursively
        int tmp;
        tmp = t_num[i];
        t_num[i] = t_num[n];
        t_num[n] = tmp;

        // return if any permutation satisfy
        if(solve_tree_one(optr_nodes, t_num, n-1))
            return true;
    }

    return false;
}

int main()
{
    // input a, b, c, d
    int num[4]; // operand 
    TNode optr_nodes[3]; //operator nodes
    cin>>num[0]>>num[1]>>num[2]>>num[3];

    // construct tree ,type one
    optr_nodes[0].left = optr_nodes[1];
    optr_nodes[0].right = optr_nodes[2];
    solve_tree_one(optr_nodes, num, 4);

    // construct tree , type two
    optr_nodes[0].left = optr_nodes[1];
    optr_nodes[1].left = optr_nodes[2];
}