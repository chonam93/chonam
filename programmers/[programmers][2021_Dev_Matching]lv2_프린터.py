def solution(priorities, location):
    answer = 0
    stack = priorities.copy()
    li = [i for i in range(len(priorities))]
    pri_lo = list(zip(priorities, li))
    
    for idx, i in enumerate(priorities):
        try:
            max_pri = max(priorities[idx:])
        except:
            max_pri = i
        if i < max_pri:
            stack = stack[1:]
            stack.append(i)
        else:
            pass
    


    return answer




priorities = [1, 2, 3, 2]	
location = 2
print(solution(priorities, location))



