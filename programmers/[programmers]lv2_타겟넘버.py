<<<<<<< HEAD
def solution(numbers, target):
    if numbers == []:
        if target == 0:
            return 1
        else:
            return 0
    else:
        return solution(numbers[1:], target+numbers[0]) + solution(numbers[1:], target-numbers[0])


numbers = [1, 1, 1, 1, 1]	
target = 3
=======
def solution(numbers, target):
    if numbers == []:
        if target == 0:
            return 1
        else:
            return 0
    else:
        return solution(numbers[1:], target+numbers[0]) + solution(numbers[1:], target-numbers[0])


numbers = [1, 1, 1, 1, 1]	
target = 3
>>>>>>> 9fd65556577fbd7dc3cf8ec58b169a0ae0f6de4b
print(solution(numbers, target))