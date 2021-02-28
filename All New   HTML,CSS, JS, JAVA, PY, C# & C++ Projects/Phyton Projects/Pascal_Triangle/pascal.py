def getRow(rowIndex):
    pr = [1]
    for i in range(rowIndex):
        r = [1]
        for j in range(1,i+1):
            r.append(pr[j-1] + pr[j])
            
        r.append(1)
        pr = r
    return pr

# Give the triangle hight
h = 5

for i in range(h):
    print(' ' * (h - i), ' '.join(str(x) for x in getRow(i)))