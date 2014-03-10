#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;

/*
construct heap
has heap size n
support push, pop, adjust heap, create heap operation

when we push an element, we just need adjust heap upwards
*/

class PriorityQueue
{
public:
    PriorityQueue(int n);
    ~PriorityQueue();

    int pop();
    void push(int element);

private:
    int size;
    int *e;

    int count;

    void adjustHeap(int i);
    void createHeap();

};

int PriorityQueue::pop()
{
    if(count<=0)
        throw -1;

    int smallestOne = e[1];
    e[1] = e[count];

    count--;
    adjustHeap(1);

    return smallestOne;
}

void PriorityQueue::push(int element)
{
    if(count>=size)
        throw -1;

    count++;
    e[count] = element;

    int i = count;
    while(i>=1)
    {
        adjustHeap(i);
        i/=2;
    }
}

PriorityQueue::PriorityQueue(int n):size(n),count(0)
{
    e = new int[n+1]; // e[0] is not used
}

PriorityQueue::~PriorityQueue()
{
    delete[] e;
}

void PriorityQueue::adjustHeap(int i)
{
    if(2*i>count)
        return;

    int smallest;

    if(2*i == count || e[2*i]<e[2*i+1])
        smallest = 2*i;
    else
        smallest = 2*i+1;

    if(e[i]<=e[smallest])
        return;
    else
    {
        int tmp = e[smallest];
        e[smallest] = e[i];
        e[i] = tmp;
        adjustHeap(smallest);
    }

    return;

}

void PriorityQueue::createHeap()
{
    for(int i=count/2; i>=1; --i)
    {
        adjustHeap(i);
    }
}

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    int n;
    cin>>n;
    PriorityQueue queue(n);

    int i = n;
    while(i>0)
    {
        int tmp;
        cin>>tmp;
        queue.push(tmp);
        i--;
    }

    stringstream ss;
    i = n;
    while(i>0)
    {
        ss<<queue.pop()<<" ";
        i--;
    }

    string result = ss.str();
    cout<<result.substr(0, result.length()-1);

    return 0;
}