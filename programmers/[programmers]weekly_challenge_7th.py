def solution(enter, leave):
    answer = []
    for idx, i in enumerate(enter):
        cnt = 0
        li = []
        check = leave.index(i)
        for idx2, j in enumerate(leave):
            check2 = enter.index(j)
            if idx2 >= idx and (idx2 < check or idx > check):
                cnt += 1
                li.append(check2)
            try:
                if check2 > idx and max(li) > check2:
                    cnt += 1
            except:
                pass
        
        answer.append(cnt)



    return answer



enter = [1,4,2,3]	
leave = [2,1,3,4]	
print(solution(enter, leave))