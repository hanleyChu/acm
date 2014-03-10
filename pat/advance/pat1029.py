a=[]
b=[]
f = open("test", "rU")
for x in f.readline().split():
    a.append(int(x))
for x in f.readline().split():
    b.append(int(x))

n = a[0]
m = b[0]
k = (m+n+1)/2
c = 0
i=1
j=1
while c<k and i<=n and j<=m:
    if a[i]<b[j]:
        median = a[i]
        i+=1
    else:
        median = b[j]
        j+=1
    c+=1

if c==k:
    print median
else:
    if i>n:
        while c<k:
            j+=1
            c+=1
        print b[j]
    else:
        while c<k:
            i+=1
            c+=1
        print a[i]
f.close()
print '1234'[1:-1]