# coding: utf-8
from bs4 import BeautifulSoup
from selenium import webdriver
import datetime
import urllib.request
import urllib
import csv

#x-ray flux
url = 'https://www.swpc.noaa.gov/products/goes-x-ray-flux?fbclid=IwAR0fhIxZFgOXFfTvuC3jLn9WspYURfTDuFiIizJukKbceNia9d94NGA9uJE'

#開啟模擬瀏覽器
driver = webdriver.Chrome()
driver.get(url)

#用lxml解析原始碼
soup = BeautifulSoup(driver.page_source, features='lxml')
driver.quit()

#進到<div>，因為圖有兩張，所以是find_all
divs = soup.find_all('div',{'class':"product-grid-cell"})

for div in divs:

    #取得圖檔連結
    href = div.a['href']
    #圖檔名稱
    pic_name = div.img['alt']+'.gif'
    #下載圖片
    data = urllib.request.urlretrieve(href,pic_name)

    

table = soup.find('table',{'id':'event_table'})
trs = table.tbody.find_all('tr')

#'data.csv'是要寫入的檔名，'a'代表append，用'r'會寫掉之前的內容
with open('data.csv', 'a',newline='') as f:
    
    writer = csv.writer(f)
    
    for tr in trs:
        divs = tr.find_all('div')
        a = []
        for div in divs:
            #把資料彙集成一個list
            a.append(div.text)

        #寫入資料
        writer.writerow(a)

    #關閉文件
    f.close()
        
        



