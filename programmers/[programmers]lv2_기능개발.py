import math
def solution(progresses, speeds):
    answer = []
    sub = []
    for p, s in zip(progresses, speeds):
        day = math.ceil((100 - p) / s)
        sub.append(day)
    
    while True:
        try:
            test = sub[0]
        except:
            break
        cnt = 0 
        for i in range(len(sub)):
            if test == 0:
                break
            elif test >= sub[i]:
                cnt += 1
            else:
                break
        del sub[:cnt]
        answer.append(cnt)

    return answer
progresses = [93, 30, 55]
speeds = [1, 30, 5]	
print(solution(progresses, speeds))
