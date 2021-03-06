#計算歷史溫度平均機率

import datetime


def avg():
    count = 0
    f = open('history_data.txt', 'r')
    dic = {}
    
    for i in range(0,50):
        dic[str(i)] = 0
            
    for line in f.readlines():
        line = line.split(' ')
        date = line[1]
        temp = line[4]
        
        if temp == '':
            temp = -1

        date = datetime.datetime.strptime(date, '%Y%m%d')

        count += 1


        for i in range(0,50):
            
            if abs(float(temp)-i) < 0.5:
                dic[str(i)] += 1
                break

         
    for i in range(0,50):

        dic[str(i)] = dic[str(i)]/count

    f.close()
    
    
    return dic


def month(month = 1):

    count = 0
    f = open('history_data.txt', 'r')
    dic = {}
    for i in range(0,50):
        dic[str(i)] = 0
            
    for line in f.readlines():
        line = line.split(' ')
        date = line[1]
        temp = line[4]
        
        if temp == '':
            temp = -1

        date = datetime.datetime.strptime(date, '%Y%m%d')
        
        if date.month == month:
            count += 1

        for i in range(0,50):

            if abs(float(temp)-i) < 0.5 and date.month == month:
                dic[str(i)] += 1
                break
            
    for i in range(0,50):

        dic[str(i)] = dic[str(i)]/count


    f.close()
    
    return dic


