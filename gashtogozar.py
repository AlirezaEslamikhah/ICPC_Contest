temp = input().split()
n =(int)(temp[0]) 
m = (int)(temp[1])

main = []
for i in range(n):
    main.append([])
for i in range(m):
    temp = input().split()
    main[(int)(temp[0])].append((int)(temp[1]))
    main[(int)(temp[1])].append((int)(temp[0]))

heights = [ 0 for i in range(n)]
visited = [False for i in range(n)]

def dfs(x):
    for i in main[x]:
        if visited[i] == False:
            visited[i] = True
            heights[i] = heights[x] + 1
            dfs(x)

dfs(1)
sar_ghotr = heights.index(max(heights))

heights.clear()
visited.clear()
heights = [0 for i in range(n+1)]
visited = [False for i in range(n+1)]

dfs(sar_ghotr)

max_heights = max(heights)
sar_ghotr2 = heights.index(max_heights)

if (max_heights <= m):
    print(max_heights+1)
else:
    print(m)
