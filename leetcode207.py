def Solution(numCourses, prerequisites):
    indeg = [0] * numCourses
    adj_list = [[] for course in range(numCourses)]
        
    for pre in prerequisites:
        adj_list[pre[1]].append(pre[0])
        indeg[pre[0]] += 1

    queue = []
    for i in range(numCourses):
        if indeg[i] == 0:
            queue.append(i)
        
    visited = 0
    while queue:
        node = queue.pop(0)
        visited += 1
        for neighbor_node in adj_list[node]:
            indeg[neighbor_node] -= 1
            if indeg[neighbor_node] == 0:
                queue.append(neighbor_node)
        
    if visited == numCourses:
        return True
    else:
        return False

if __name__ == "__main__":

    n = input() 
    strings = n.split(', ')
    numCourses = int(strings[0])

nested_list = []
for element in strings[1]:
    for number in element:
        if number.isnumeric() == True:
           nested_list.append(int(number))

nlist = []
for index in range(0, len(nested_list), 2):
    new_element = []
    for number in nested_list[index:index + 2]:
        new_element.append(number)
    nlist.append(new_element)

print(Solution(numCourses,nlist))

  
            