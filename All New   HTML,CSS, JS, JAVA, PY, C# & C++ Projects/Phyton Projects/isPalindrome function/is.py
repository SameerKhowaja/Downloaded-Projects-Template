import re

def isPalindrome(TestString):
    
    TestString = TestString.lower()
    TestString = re.sub('[0–9\W]', '', TestString)
    listOfString = list(TestString) 
    reverseList = listOfString[::-1]
    return reverseList == listOfString

#https://en.wiktionary.org/wiki/Appendix:English_palindromes

testList = ['Race car', "No 'x' in Nixon!", '1221', 'no palindrome in this string', 'A man, a plan, a canal: Panama', 'Rise to vote, sir']
for l in testList:
    print(l + ': ' + str(isPalindrome(l)))
    