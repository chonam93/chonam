def solution(weights, head2head):
    answer_dic = {}
    id_num = 1
    for idx, h in enumerate(zip(weights, head2head)):
        ha = list(h[1])
        ha[weights.index(h[0])] = 0
        cnt = h[1].count('W')
        win_cnt = 0
        for idx2, win in enumerate(ha):
            if win == 'W' and h[0] < weights[idx2]:
                win_cnt +=1

        total = h[1].count('W') + h[1].count('L')
        
        if total == 0:
            rate = 0
        elif total != 0:
            rate = cnt/total
        answer_dic[idx+1] = (id_num, rate, win_cnt, h[0])
        id_num += 1
    answer = sorted(answer_dic.items(), key=lambda x:(-x[1][1], -x[1][2], -x[1][3], x[1][0]))
    return list(map(lambda x : x[1][0], answer))





weights = [50,82,75,120]		
head2head = ["NLWL","WNLL","LWNW","WWLN"]	

print(solution(weights, head2head))
print(0/5)
# for idx, h in enumerate(zip(weights, head2head)):
#     print(idx, h)
    


# dic = {50: (1, 1, 1), 82: (2, 1, 0), 75: (3, 2, 2), 120: (4, 2, 0)}
# print(dic.items())
# hi = sorted(dic.items(), key=lambda x:-x[1][1])
# print(hi)
# x = list(map(lambda x : x[1][0], hi))
# print(x)