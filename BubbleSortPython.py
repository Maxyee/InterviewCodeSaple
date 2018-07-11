list = [800,11,50,771,649,770,240, 9]
n = len(list)
temp = 0

for i in range(n):
    for j in range(n - 1):
        if list[j] > list[j+1]:
                temp = list[j+1]
                list[j+1] = list[j]
                list[j] = temp

for z in range(n):
    print(list[z])
