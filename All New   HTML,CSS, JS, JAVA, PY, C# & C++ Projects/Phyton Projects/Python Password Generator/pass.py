##imports##
import random
import os
import sys
import time
import re
##end imports##
def addToClipBoard(text):
    command = 'echo ' + text.strip() + '| clip'
    os.system(command)
rand1 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand2 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand3 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'])
rand4 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand5 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand6 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand7 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand8 = random.choice(['!','@','#','$','%','*','(',')','-','_','+','=','`','~','?',',','"',':',';','\' ','/'])
rand9 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand10 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand11 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])
rand12 = random.choice(['A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','!','@','#','$','%','*','(',')','-','_','+','='])

randommin = rand1 + rand2 + rand3 + rand4 + rand5 + rand6 + rand7 + rand8
random1 = rand1 + rand2 + rand3 + rand4 + rand5 + rand6 + rand7 + rand8 + rand9
random2 = rand1 + rand2 + rand3 + rand4 + rand5 + rand6 + rand7 + rand8 + rand9 + rand10
random3 = rand1 + rand2 + rand3 + rand4 + rand5 + rand6 + rand7 + rand8 + rand9 + rand10 + rand11
randommax = rand1 + rand2 + rand3 + rand4 + rand5 + rand6 + rand7 + rand8 + rand9 + rand10 + rand11 + rand12
username = input("username: ")
print("8-12")
passwordlength = input("passwordlength: ")
if passwordlength == "8":
    print (username + "'s password is: " + randommin)
    addToClipBoard(randommin)
    print("password as been added to your clipboard")
    input()
if passwordlength == "9":
    print(username + "'s password is: " + random1)
    addToClipBoard(random1)
    print("password as been added to your clipboard")
    input()

if passwordlength == "10":
    print(username + "'s password is: " + random2)
    addToClipBoard(random2)
    print("password as been added to your clipboard")
    input()
if passwordlength == "11":
    print(username + "'s password is: " + random3)
    addToClipBoard(random3)
    print("password as been added to your clipboard")
    input()
if passwordlength == "12":
    print(username + "'s password is: " + randommax)
    addToClipBoard(randommax)
    print("password as been added to your clipboard")
    input()
