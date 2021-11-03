<<<<<<< HEAD
def solution(numbers):
    answer = 0
    for i in range(1, 10):
        if i not in numbers:
            answer += i
        else:
            pass

    return answer


numbers = [1,2,3,4,6,7,8,0]	

=======
def solution(numbers):
    answer = 0
    for i in range(1, 10):
        if i not in numbers:
            answer += i
        else:
            pass

    return answer


numbers = [1,2,3,4,6,7,8,0]	

>>>>>>> 9fd65556577fbd7dc3cf8ec58b169a0ae0f6de4b
print(solution(numbers))