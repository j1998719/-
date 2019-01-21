
# coding: utf-8

from selenium import webdriver
from bs4 import BeautifulSoup
import datetime
from xlsx import *

url='https://weather.com/zh-TW/weather/hourbyhour/l/Taipei+Taiwan+TWXX0021:1:TW'
hourly_data= '預測資料.xlsx'


year=datetime.datetime.now().year
month=datetime.datetime.now().month
day=datetime.datetime.now().day

now=datetime.datetime.now()
oneday = datetime.timedelta(1)
    
hourly = Xlsx(hourly_data)
hourly.save()


def soup(url):
    driver= webdriver.Chrome()
    driver.get(url)
    soup = BeautifulSoup(driver.page_source,'lxml')
    driver.quit()
    
    return soup

def source(url):


       
    Soup = soup(url)
    
    trs = Soup.find_all( 'tr')

    i=0
    for tr in trs:
        span = tr.find('span',{'class':"dsx-date"})
        td = tr.find('td', {'class':'temp'})
        try:
            
            text=str(year)+str(month).zfill(2)+str(day).zfill(2)+span.text
            strpt= datetime.datetime.strptime(text, '%Y%m%d%H:%M')
            
            if strpt < now:

                strpt += oneday


            temp = td.span.text[0:2]
   
            #hourly.Sheetwrite('臺北市',[strpt,temp])
            print('輸入: ', [strpt,temp])
            i=i+1
                
                
            
                
                
        except AttributeError:
            print('pass')

    print('輸入',i,'筆資料')
    print('end')





hourly = Xlsx(hourly_data)
hourly.save()

if __name__ == '__main__':
    hourly = Xlsx(hourly_data)
    source(url)
    hourly.save()






