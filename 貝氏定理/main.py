import os
import time

if __name__ == '__main__':

    while 1:
        
        print("執行:預測資料.py")
        os.system('預測資料.py')
        print("執行:觀測資料.py")
        os.system('觀測資料.py')
        
        for i in range(0,59):
            now = time.ctime(time.time())
            print("the now time is " + str(now) )
            time.sleep(60)

    
