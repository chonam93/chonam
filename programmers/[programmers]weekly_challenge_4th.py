<<<<<<< HEAD
# [programmers]weekly_challenge_4th
# 직업군 추천하기

# 개발자가 사용하는 언어와 언어 선호도를 입력하면 그에 맞는 직업군을 추천해주는 알고리즘을 개발하려고 합니다.
# 직업군 언어 점수를 정리한 문자열 배열 table, 개발자가 사용하는 언어를 담은 문자열 배열 languages, 
# 언어 선호도를 담은 정수 배열 preference가 매개변수로 주어집니다. 
# 개발자가 사용하는 언어의 언어 선호도 x 직업군 언어 점수의 총합이 가장 높은 직업군을 return 하도록 solution 함수를 완성해주세요. 
# 총합이 같은 직업군이 여러 개일 경우, 이름이 사전 순으로 가장 빠른 직업군을 return 해주세요.



def solution(table, languages, preference):
    answer_dic = {}
    for i in table:
        li_i = i.split()
        li_i.reverse()
        dic_lan = {}
        for idx, lan in enumerate(li_i):
            dic_lan[lan] = idx + 1
        sumli = []
        for idx2, j in enumerate(languages):
            if j in dic_lan.keys():
                sumli.append(dic_lan[j] * preference[idx2])
            else:
                sumli.append(0)
        answer_dic[li_i[5]] = sum(sumli)

    answer = sorted(answer_dic.items(), key = lambda x: (-x[1], x[0]))

    return answer[0][0]

##다른 사람 풀이
# def solution(table, languages, preference):
#     score = {}
#     for t in table:
#         for lang, pref in zip(languages, preference):
#             if lang in t.split():
#                 score[t.split()[0]] = score.get(t.split()[0], 0) +  (6 - t.split().index(lang)) * pref
#     return sorted(score.items(), key = lambda item: [-item[1], item[0]])[0][0]


table = ["SI JAVA JAVASCRIPT SQL PYTHON C#", "CONTENTS JAVASCRIPT JAVA PYTHON SQL C++",
         "HARDWARE C C++ PYTHON JAVA JAVASCRIPT", "PORTAL JAVA JAVASCRIPT PYTHON KOTLIN PHP", "GAME C++ C# JAVASCRIPT C JAVA"]

languages = ["PYTHON", "C++", "SQL"]

preference = [7, 5, 5]

solution(table, languages, preference)
=======
# [programmers]weekly_challenge_4th
# 직업군 추천하기

# 개발자가 사용하는 언어와 언어 선호도를 입력하면 그에 맞는 직업군을 추천해주는 알고리즘을 개발하려고 합니다.
# 직업군 언어 점수를 정리한 문자열 배열 table, 개발자가 사용하는 언어를 담은 문자열 배열 languages, 
# 언어 선호도를 담은 정수 배열 preference가 매개변수로 주어집니다. 
# 개발자가 사용하는 언어의 언어 선호도 x 직업군 언어 점수의 총합이 가장 높은 직업군을 return 하도록 solution 함수를 완성해주세요. 
# 총합이 같은 직업군이 여러 개일 경우, 이름이 사전 순으로 가장 빠른 직업군을 return 해주세요.



def solution(table, languages, preference):
    answer_dic = {}
    for i in table:
        li_i = i.split()
        li_i.reverse()
        dic_lan = {}
        for idx, lan in enumerate(li_i):
            dic_lan[lan] = idx + 1
        sumli = []
        for idx2, j in enumerate(languages):
            if j in dic_lan.keys():
                sumli.append(dic_lan[j] * preference[idx2])
            else:
                sumli.append(0)
        answer_dic[li_i[5]] = sum(sumli)

    answer = sorted(answer_dic.items(), key = lambda x: (-x[1], x[0]))

    return answer[0][0]

##다른 사람 풀이
# def solution(table, languages, preference):
#     score = {}
#     for t in table:
#         for lang, pref in zip(languages, preference):
#             if lang in t.split():
#                 score[t.split()[0]] = score.get(t.split()[0], 0) +  (6 - t.split().index(lang)) * pref
#     return sorted(score.items(), key = lambda item: [-item[1], item[0]])[0][0]


table = ["SI JAVA JAVASCRIPT SQL PYTHON C#", "CONTENTS JAVASCRIPT JAVA PYTHON SQL C++",
         "HARDWARE C C++ PYTHON JAVA JAVASCRIPT", "PORTAL JAVA JAVASCRIPT PYTHON KOTLIN PHP", "GAME C++ C# JAVASCRIPT C JAVA"]

languages = ["PYTHON", "C++", "SQL"]

preference = [7, 5, 5]

solution(table, languages, preference)
>>>>>>> 9fd65556577fbd7dc3cf8ec58b169a0ae0f6de4b
