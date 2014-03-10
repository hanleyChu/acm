#include  <iostream>
#include <fstream>
#include <cstdlib>
using namespace std;

class Node
{
public:
    Node *left,*right;
    union Entry
    {
        char optr;
        int opnd;
    }entry;

public:
    float value();
    Node():left(NULL),right(NULL){}

};

float Node::value()
{
        if(left==NULL && right == NULL)
            return this->entry.opnd;
        else
        {
            float a = left->value();
            float b = right->value();
            switch(this->entry.optr)
            {
                case '-': return a-b;
                case '+': return a+b;
                case '*': return a*b;
                case '/': return (float)a/b;
                default:
                    cout<<"wrong operator found";
                    exit(EXIT_FAILURE);
            }
        }
}

void printTree(Node *root, bool isRoot)
{
    if(root->left==NULL && root->right==NULL)
        cout<<root->entry.opnd;
    else
    {
        if(!isRoot)
            cout<<'(';

        printTree(root->left, false);
        cout<<root->entry.optr;
        printTree(root->right, false);

        if(!isRoot)
            cout<<')';
    }
}

Node* findOneTree(Node* root, int nums[])
{
    char optrs[4] = {'+','-','*','/'};

    for(int i=0;i<4;++i)
        root[i+3].entry.opnd = nums[i];

    //test tree one
    root->left = root+1;
    root->right = root+2;
    (root+1)->left = root+3;
    (root+1)->right = root+4;
    (root+2)->left = root+5;
    (root+2)->right = root+6;

    for(int p = 0;p<4;++p)
        for(int q = 0;q<4;++q)
            for(int s = 0;s<4;++s)
            {
                root->entry.optr = optrs[p];
                (root+1)->entry.optr = optrs[q];
                (root+2)->entry.optr = optrs[s];
                
                float value = root->value();
                
                if(value==24)
                {
                    return root;
                }
            }

    

    // test tree two
    root->left = root+1;
    (root+1)->left = root+2;
    (root+2)->left = root+3;
    (root+2)->right = root+4;
    (root+1)->right = root+5;
    (root+0)->right = root+6;

    for(int p = 0;p<4;++p)
        for(int q = 0;q<4;++q)
            for(int s = 0;s<4;++s)
            {
                root->entry.optr = optrs[p];
                (root+1)->entry.optr = optrs[q];
                (root+2)->entry.optr = optrs[s];

                float value = root->value();
                
                if(value==24)
                {
                    return root;
                }
                    
            }

    // test tree tree
    root->right = root+1;
    (root+1)->right = root+2;
    (root+2)->right = root+3;
    (root+2)->left = root+4;
    (root+1)->left = root+5;
    (root+0)->left = root+6;

    for(int p = 0;p<4;++p)
        for(int q = 0;q<4;++q)
            for(int s = 0;s<4;++s)
            {
                root->entry.optr = optrs[p];
                (root+1)->entry.optr = optrs[q];
                (root+2)->entry.optr = optrs[s];

                float value = root->value();
                
                if(value==24)
                {
                    return root;
                }
                    
            }

    return (Node*)NULL;
}


// n denote 0~n-1 elements need to be arranged
Node* findOne(Node* root, int nums[], int n)
{
    // calculate an arrangment
    if(n==0)
    {
        return findOneTree(root, nums);
    }

    // arrange the nums array
    for(int i=0;i<n;++i)
    {
        int copyOfnums[4];
        for(int j=0;j<4;j++)
            copyOfnums[j] = nums[j];

        int tmp = copyOfnums[i];
        copyOfnums[i] = copyOfnums[n-1];
        copyOfnums[n-1] = tmp;

        Node *result = findOne(root, copyOfnums, n-1);
        if(result!=NULL)
        {
            return result;
        }
    }
	
    return (Node*)NULL;
}



int main()
{
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    Node nodes[7];
    int nums[4];
    for(int i=0;i<4;++i)
        cin>>nums[i];

    /*
    for each arrange:
        for each combination of operators:
            value = calculate the root value;
            if value == 25:
                mid_tranverse(root)
                */
    Node *root;
    root = findOne(nodes, nums, 4);
    if(root==NULL)
        cout<<"-1";
    else
        printTree(root, true);

    return 0;
}