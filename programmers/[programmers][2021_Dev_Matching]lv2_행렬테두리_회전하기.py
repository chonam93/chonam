def solution(rows, columns, queries):
    answer = []
    matrix = []
    num = 1
    for i in range(rows):
        li = []
        for j in range(columns):
            li.append(num)
            num += 1
        matrix.append(li)

    queries[]
    print(matrix)
    return answer
    

rows = 6
columns = 6
queries = [[2,2,5,4],[3,3,6,6],[5,1,6,3]]	
print(solution(rows, columns, queries))