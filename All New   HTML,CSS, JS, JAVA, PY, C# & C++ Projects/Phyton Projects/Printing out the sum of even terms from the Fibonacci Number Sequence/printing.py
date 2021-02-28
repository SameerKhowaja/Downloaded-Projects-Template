import sys
#Script which retreives the sum of the even terms of the fibonacci numbers.

#Exception, notIntInput, is thrown in the case of when the inputs are not integers (from the user end).
class wrongInputError(Exception):
	pass; 

#Prints the contents of an array with a header_message.
def printContentsOfArray(header_message, array):
	print(header_message);
	for item in array:
		print(item);
#Converts contents in a string array into an Int(eger) array.
def stringToIntArray(array):
	intArray = [];
	for item in array:
		if not array.index(item) == 0:
			intArray.append(int(item))
	return intArray;
#Find the Fibonacci Number Sequence using the 1st two terms along with a sensible limit.
def findFibonacciNumberSequence(firstElement,secondElement,limit):
	fibonacciArray =[];
	fibonacciArray.insert(0,firstElement);
	fibonacciArray.insert(1,secondElement);
	printContentsOfArray("",fibonacciArray);
	element = secondElement;
	currentIndex = 1;
	while(element <= limit):
		element = fibonacciArray[currentIndex] + fibonacciArray[currentIndex-1];
		print(element);
		if(element<=limit):
			fibonacciArray.append(element);
		currentIndex = currentIndex +1;
	return fibonacciArray;

#Check whether a number is even or not.
def checkNumberIsEvenOrNot(number):
	#Even
	if((number % 2)==0):
		return 0;
	#Odd
	else:
		return 1;
#Check whether a collection of numbers is even or not.
def checkArrayContentsEvenElements(array):
	oddArray =[];
	evenArray=[];
	togetherArray=[];
	for item in array:
		checkerVariable = checkNumberIsEvenOrNot(item);
		if (checkerVariable == 0):
			evenArray.append(item);
		else:
			oddArray.append(item);
	#Store both the evenArray and oddArray in togetherArray.
	togetherArray.append(evenArray);
	togetherArray.append(oddArray);
	return togetherArray;

#Check the consistency of the inputs inserted by the user using this program.
def checkConsistencyOfInputs(checkInputs):
	tempVar = int(checkInputs[1]) + int(checkInputs[2]);
	if(len(checkInputs) >= 5):
		raise wrongInputError("Too many Arguments");
	if(int(checkInputs[1]) >= int(checkInputs[2])):
		raise wrongInputError("Input 1 is bigger than Input 2");
	if (tempVar > int(checkInputs[3])):
		raise wrongInputError("Third Element of the Fibonacci sequence cannot be taken");
	
#Main function - main(clp).
def main(clp):
	printContentsOfArray("Printing Command Line Parameters", clp);
	fibonacciArray = findFibonacciNumberSequence(clp[0],clp[1],clp[2]);
	printContentsOfArray("Printing contents of Fibonacci Array",fibonacciArray);
	contents = checkArrayContentsEvenElements(fibonacciArray);
	printContentsOfArray("Even terms of Fibonacci Array: ",contents[0]);
	return sum(contents[0]);

#The first two terms of the sequence are given by the command line parameters given by the user.
try:
    inputArray = ['input.py',1,2,10000];
    checkConsistencyOfInputs(inputArray);
    commandLineParameters = stringToIntArray(inputArray);
    printContentsOfArray("Command Line Parameters: ",commandLineParameters);
    sumFib = main(commandLineParameters)
    print("The total of even Fibonacci numbers from: "+str(inputArray[1])+" to: "+str(inputArray[2])+" is given by: "+str(sumFib));
except ValueError:
	print("Ill value given as system parameters for this program");
except wrongInputError:
	print("Inappropriate values inserted into the program");
