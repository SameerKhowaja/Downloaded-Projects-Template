/*Abdullah Abdulrahman
project PostNet
5/27/16
**this program will generate a postnet from the user input and will format it to a seprate file***/

#include <iostream>
#include <iomanip>
#include <fstream>
#include <ctime>

using namespace std;

int CheckdigitCalc (int, int, int, int, int); 		//function protoyping	
string digit2word( int digit );				//function prototyping
void WriteToFile (string, string, string, string, int, int, int, int, int, string);		//Function Prototyping
void pause(int dur);   						//function prototyping

int Counter;  					//global const

void Menu(){
		Counter ++;
			if (Counter > 1) {
		cout << " Welcome to the Mailing Label Printing System\n"
				 << "\n 1 - Single Mailing"
				 << "\n 2 - formatt my mailing to a seperate .txt file."
				 << "\n 3 -- Quit\n"
				 << "\n Enter your choice: ";
			}

		if (Counter < 2){
		    	Counter = 2;
				cout << " Welcome to the Mailing Label Printing System\n"
				 << "\n 1 - Single Mailing"
				 << "\n 3 -- Quit\n"
				 << "\n Enter your choice: "; 	
		}
}

int main () {

	// string varibles
	string  Name,
			FirstLine,
			Address,
			NewLine,
			Street,
			City,
			State,
			FinalResult,
			result;
	//integer variables
	int zip1, zip2, zip3, zip4, zip5, CheckDigit, Stnum, sum, num, Choice = 1 ;

// output sartes here by desplaying the info asking the user for information
		cout << "program by: Abdullah Abdulrahman\nproject PostNet\n5-27-2016" 
			<<"\n**this program will generate a postnet from the user input**\n\n" << endl;
	while (Choice == 1 || Choice == 2 || Choice == 3){
			Menu();
			cin >> Choice;
			cout <<endl;
		while (Choice != 1 && Choice != 2 && Choice != 3) {		// makes sure the user input is correct
			cout << " Invalid choice! PLease try again\n\n";
			Menu();
			cin >> Choice;
		}
	
	
			cin.ignore();		// ignore the \n stored in the keyboard's buffer
	if (Choice == 1){
		
		sum = 0;
		num = 0;
		FinalResult = "";
		
		cout << " Enter your full Name followed by a [Enter]: ";
			getline(cin, Name);    // the getline function used in this block of input/output is so the user can input srings and space charecters as much as they want
		
		cout << " Enter your Address followed by a [Enter]: ";
			getline(cin, Address);
		
		cout << " Enter City Follwoed by a [Enter]: ";
			getline(cin,City);
		
		cout << " Enter your state followed by a [Enter]: ";
			getline(cin,State);
		
		cout << " Enter your zip code then hit [Enter]: ";
			cin >> sum; //take the zip code numbers and store each number in a variable
			
			num = sum %  10;
      			zip5 = num;
				sum = sum / 10 ;
			num = sum %  10;
      			zip4 = num;
				sum = sum / 10 ;
			num = sum %  10;
     			zip3 = num;								// these statment used to pull the digits out single digits from a zipcode.
				sum = sum / 10 ;
			num = sum %  10;
    			zip2 = num;
				sum = sum / 10 ;
			num = sum %  10;
      			zip1 = num;
				sum = sum / 10 ;
			
			// this if statmet is placed here to catch error in case the user didnt seperate the numbers
		if (zip1 > 10 || zip2 > 10 || zip3 > 10 || zip4 > 10 || zip5 > 10){
			cout << " one or more of the digits you entered are incorrect,"
				<< "please read the instructions and try again.\n" <<endl;	
				
			cout << " Enter your zip code then hit [Enter]: ";
			cin >> sum;
					num = sum %  10;
      			zip5 = num;
				sum = sum / 10 ;
			num = sum %  10;
      			zip4 = num;
				sum = sum / 10 ;
			num = sum %  10;
     			zip3 = num;								// these statment used to pull the digits out single digits from a zipcode.
				sum = sum / 10 ;
			num = sum %  10;
    			zip2 = num;
				sum = sum / 10 ;
			num = sum %  10;
      			zip1 = num;
				sum = sum / 10 ;
		}
	
	CheckDigit = CheckdigitCalc(zip1, zip2, zip3, zip4, zip5);   		//pass the zips to the function for calculation
			
	FinalResult += digit2word(zip1);
	FinalResult += digit2word(zip2);
	FinalResult += digit2word(zip3);
	FinalResult += digit2word(zip4);
	FinalResult += digit2word(zip5);
	FinalResult += digit2word(CheckDigit);	
		
	
		 cout << " **************************"<< "\n" << endl;
	
		 cout << " " << Name << "\n "<< Address << "\n " << City << "   " << State << setw(2) << zip1 << zip2 
			 << zip3 << zip4 << zip5 << "\n" << endl; // the final output formatted similart to  the sample out put
	
		 cout << " |" << FinalResult << "|\n\n"; // prints the zipcode and check digit similar to sample output
		 
			FinalResult = "";     //clears the variable incase the user wants another input
	}
	
			if (Choice == 2)
			{
				cout << "printing..................." << endl;
				WriteToFile (Name, Address, City, State, zip1, zip2, zip3, zip4, zip5, FinalResult);
				pause(3);
				cout << "\nDONE!\n\n" << endl;
				return 0;
			}
				if (Choice == 3){ 															 // terminates the program when the sure enters 3
				cout << "Thank you, closing program.";
			return 0;
					}
	}									//end of the first while loop
	return 0;						 // terminates the program
}									//main function braket
/*****************************************************end of main function*/
string digit2word( int digit ) {
  string result;
  		switch(digit) // switching between accepted digits depending on the given parameter
{
	case 1:
		result = ":::||";
		
	break;
	
	case 2:
		result = "::|:|";

	break;

	case 3:
		result = "::||:";

	break;
	
	case 4:
		result = ":|::|";
	
	break;
	
	case 5:
		result = ":|:|:";
	
	break;
	
	case 6:
		result = ":||::";

	break;
	
	case 7:
		result = "|:::|";
		
	break;
	
	case 8:
		result = "|::|:";
		
	break;

	case 9:
		result = "|:|::";
		
	break;
	
	case 0:
		result = "||:::";
		
	break;
	
	case 10:
		if (digit == 10){				//in case the check digit is 10 it will print out 0
			result = "||:::";
		
		}
	 break;
	 	 
	default: // in case the argument didn’t fall in any of the above cases
		result = "wrong information"; // means failure
	break;
	}		//end of switch statment
  return result;
}
/*********************************************************************************end of digit2string function*/
int CheckdigitCalc (int zip1, int zip2, int zip3, int zip4, int zip5){
	int CheckDigit;
	
	CheckDigit = (zip1 + zip2 + zip3 + zip4 + zip5)%10; // to calculate he check digit
			CheckDigit = 10-CheckDigit;
			
	return CheckDigit;
}
/**********************************************************************************end of CheckDigitalc function*/
void WriteToFile (string Name, string Address, string City, string State, int zip1, int zip2, int zip3, int zip4, int zip5, string
 FinalResult) {
	ofstream myfile;
  myfile.open ("Your PostNet.txt");
  myfile <<" " << Name << "\n "<< Address << "\n " << City << "   " << State << setw(2) << zip1 << zip2 
		 << zip3 << zip4 << zip5 << "\n" << endl;
  myfile << " |" << FinalResult << "|\n\n";
  myfile.close();

}
/***********************************************************************************end of WriteToFile function*/
void pause(int dur)
{
int temp = time(NULL) + dur;

while(temp > time(NULL));
}
