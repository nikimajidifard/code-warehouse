def IsPossible(l):
    l.sort()
    s=""
    while(len(l))>0:
        if s == "NO":
            break
        if k<=len(l):
            for i in range(k):
                l.remove(l[0])
        elif k> len(l):
            l.remove(l[0])
        for i in range(len(l)):
            l[i]=l[i]-1
            if(l[i]==0 or l[i]==-1):
                s="NO"
                break
    if(len(l)==0):
        s="YES"
    return s

nk=input().split()
n=int(nk[0])
k=int(nk[1])

num=0
l=[]
for i in range(n):
    s=input().split()
    s[0]=int(s[0])
    s[1]=int(s[1])
    num=s[1]-s[0]
    l.append(num)

print(IsPossible(l))