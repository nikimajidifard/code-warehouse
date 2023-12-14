def dfs(adjency,i,visited,stack):
    visited[i] = 1
    for j in range(len(adjency[i])):
        if not visited[adjency[i][j]]:
            visited[adjency[i][j]] = 1
            dfs(adjency,adjency[i][j],visited,stack)
    stack.append(i)

def result(adjency):
    stack =[]
    visited=[None]*len(adjency)
    for i in range(len(adjency)):
        if not visited[i]:
            dfs(adjency,i,visited,stack)
    adjre = [[] for _ in range(len(adjency))]
    for i in range(len(adjency)):
        for j in range(len(adjency[i])):
            adjre[adjency[i][j]].append(i)

    visited = [None]*len(adjency)
    c=0
    while len(stack) !=0:
        el = stack.pop()
        if not visited[el]:
            dfs(adjre,el,visited,[])
            c=c+1
    return c

def main():
    n = int(input())
    adjency = [[] for _ in range(n)]
    while True:
        try:
            x,y= map(int,input().split())
            adjency[x-1].append(y-1)
        except:
            break
    print(result(adjency))
main()
