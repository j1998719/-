# coding: utf-8
from bs4 import BeautifulSoup
import urllib.request
from selenium import webdriver
import datetime
from xlsx import *

save_data = '觀測資料.xlsx'
save = Xlsx(save_data)


url = 'https://www.cwb.gov.tw/V8/C/W/OBS_County.html?ID=63'

driver = webdriver.Chrome()
driver.get(url)

soup = BeautifulSoup(driver.page_source, features='lxml')

tbody = soup.find('tbody',{'id':'stations'})
trs = tbody.find_all('tr')

year = str(datetime.datetime.now().year)

for tr in trs:
    th = tr.th
    name = th.next_element
    sp = th.text.split(name)
    date = sp[1]
    
    date = year + date
    date = datetime.datetime.strptime(date, '%Y%m/%d%H:%M')

    if not th.nextSibling.text == '-':
        temp = float(th.nextSibling.text)
    else:
        temp = -99

    save.Sheetwrite('臺北市',[name, date, temp])
    
       
driver.quit()
save.save()
print('done')




