def solution(skill, skill_trees):
    answer = 0
    skill_dic = {j:i for i ,j in enumerate(skill)}
    for i in skill_trees:
        check_dic = {}

        cnt = 0
        check = 0
        for j in i:
            if j in skill:
                check_dic[j] = cnt
                cnt += 1
        for k in skill_dic:
            if skill_dic[k] != check_dic[k]:
                check += 1
            elif check == 1:
                break
        if check == 0:
            answer += 1

    return answer


skill = "CBD"	
skill_trees = ["BACDE", "CBADF", "AECB", "BDA"]	
print(solution(skill, skill_trees))