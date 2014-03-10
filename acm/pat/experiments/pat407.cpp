#include <iostream>
#include <fstream>
#include <climits>
#include <cstring>

using namespace std;

/*
new a table c[1~n,1~n]

//initialize table c with INT_MAX and diagonal elements is 0
for i = 1~n, j=1~n
    c[i, j] = INT_MAX
for i = 1~n
    c[i,i]=0

// fill the table with minimum cost
for l = 2~n
    for i = 1~n-l+1
        j = i+l
        extra_cost = calculate_cost(i,j)
        for k = i~j-1
            new_cost = c[i,k]+c[k+1,j]+extra_cost
            if c[i,j]>new_cost
                c[i,j] = new_cost

c[1,n] is the minimun cost of the specific wood
*/

int calculate_cost(int i, int j, int a[])
{
    int sum=0;
    for(int k=i;k<=j;++k)
        sum+=a[k];

    return sum;
}

// void printTrackTable(int a[],int **t, int **c, int i,int j)
// {
//     if(i==j)
//         return;

//     int k = t[i][j];
//     for(int m = i;m<=k;++m)
//         cout<<a[m]<<" ";
//     cout<<"|"<<" ";
//     for(int m = k+1;m<=j;++m)
//         cout<<a[m]<<" ";

//     cout<<" ---> "<<c[i][j]<<endl;

//     printTrackTable(a,t,c,i,k);
//     printTrackTable(a,t,c,k+1,j);
// }

int get_min_cost(int a[], int n, int **c)
{
    // fill table with max int
    for(int i =0;i<n;++i)
        for(int j=0;j<n-i;++j)
            c[i][j] = INT_MAX;
    // fill diagonal elements with 0 cost
    for(int j=0;j<n;++j)
        c[j][j-j] = 0;

    for(int l = 2;l<=n;++l)
    {
        for(int i = 0;i<=n-l;++i)
        {
            int j = i+l-1;
            int extra_cost = calculate_cost(i,j,a);
            for(int k=i;k<=j-1;++k)
            {
                int new_cost = c[i][k-i]+c[k+1][j-(k+1)]+extra_cost;
                if(new_cost<c[i][j-i])
                {
                    c[i][j-i] = new_cost;
                }
            }
        }
    }

    return c[0][n-1];
}

void find_min_cost_on_perms(int a[], int n, int **c)
{

   int *p = new int[n+1];
   int i, j, tmp; // Upper Index i; Lower Index j

   for(i = 0; i < n; i++)   // initialize arrays; a[N] can be any type
   {
      p[i] = i;
   }
   p[n] = n; // p[N] > 0 controls iteration and the index boundary for i
   
   int min_cost = get_min_cost(a, n, c);

   i = 1;   // setup first swap points to be 1 and 0 respectively (i & j)
   while(i < n)
   {
      p[i]--;             // decrease index "weight" for i by one
      j = i % 2 * p[i];   // IF i is odd then j = p[i] otherwise j = 0
      tmp = a[j];         // swap(a[j], a[i])
      a[j] = a[i];
      a[i] = tmp;
      
      int new_cost = get_min_cost(a, n, c);
      if(min_cost>new_cost)
      {
        min_cost = new_cost;
       }

      i = 1;              // reset index i to 1 (assumed)
      while (!p[i])       // while (p[i] == 0)
      {
         p[i] = i;        // reset p[i] zero value
         i++;             // set new index value for i (increase by one)
      } // while(!p[i])
   } // while(i < N)

   cout<<min_cost;

   delete[] p;
}

int main()
{
    std::ios::sync_with_stdio(false);
    ifstream ifs("test");
    cin.rdbuf(ifs.rdbuf());

    int n;
    cin>>n;
    int *a = new int[n];
    for(int i=0;i<n;++i)
        cin>>a[i];

    //allocate the cost table c[][]
    int **c = new int*[n];
    for(int i = 0;i<n;++i)
        c[i] = new int[n-i];

    find_min_cost_on_perms(a, n, c);

    // free
    for(int i = 0;i<n;++i)
        delete[] c[i];
    delete[] c;
    delete[] a;
}

