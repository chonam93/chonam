<<<<<<< HEAD
def solution(s):
    answer = 0
    stack = []
    
    for i in s:
        if len(stack) == 0:
            stack.append(i)
        elif stack[-1] == i:
            stack.pop()
        elif stack[-1] != i:
            stack.append(i)
    if len(stack) > 0:
        return answer
    else:
        return 1

s = 'baabaa'
print(solution(s))
=======
def solution(s):
    answer = 0
    stack = []
    
    for i in s:
        if len(stack) == 0:
            stack.append(i)
        elif stack[-1] == i:
            stack.pop()
        elif stack[-1] != i:
            stack.append(i)
    if len(stack) > 0:
        return answer
    else:
        return 1

s = 'baabaa'
print(solution(s))
>>>>>>> 9fd65556577fbd7dc3cf8ec58b169a0ae0f6de4b
