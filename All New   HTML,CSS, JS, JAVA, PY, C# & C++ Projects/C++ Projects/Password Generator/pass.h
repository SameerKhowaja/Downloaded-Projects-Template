#include <iostream>
#include <cstdlib>
#include <time.h>

using namespace std;


//function prototype
int main();
int option();
int quit();
void passgen(int opt);


//Global arrays/variables
char wordItensNoCaps[26]= {'q','w','e','r','t','y','u','i','o','p','a','s','d','f','g','h','j','k','l','z','x','c','v','b','n','m'};
char wordItensCaps[26]= {'Q','W','E','R','T','Y','U','I','O','P','A','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M'};
char numbers[10] = {'1','2','3','4','5','6','7','8','9','0'};
char specials[7] = {'#','%','+','*','-','_','|'};



//function declaration
int main(){
    cout << "Hello,\nYou are now entering my PassWord Generator\nHope you like it\n\n";
    passgen(option());
};

int option(){
    
    int choosen =0;
    int caps = 0;
    
    cout << "What type of password would you like?\n\n\t"<<
    "1 - Letters only\n\t"<<
    "2 - Numbers only\n\t"<<
    "3 - Specials only\n\t"
    "4 - Letters + Numbers\n\t"<<
    "5 - Letters + Specials\n\t"<<
    "6 - Numbers + Specials\n\t"<<
    "7 - Letters + Numbers + Specials\n\t"<<
    "0 - Quit\n\n"<<
    
    "What option do you want?  ";
    cin >> choosen;
    cout << "\n";
    
    if (choosen==0){
        quit();
    }
    
    if (choosen==1||choosen==4||choosen==5||choosen==7){
        cout << "Do you want Capitalized letters?\n\n\t"<<
        "1 - Yes, I only want capitalized letters\n\t"<<
        "2 - Yes, I want capitalized and non capitalized letters (Recommended, most secure)\n\t"<<
        "3 - No, I just want non capitals\n\n"<<
        
        "What type do you choose? ";
        cin >>caps;
    }
    
    return ((choosen*10)+caps);
    
    
}

//Generates the password

void passgen(int opt){
    int size;
    int rnd=0;
    int actualSize=0;
    cout << "What size do you want? (larger than 15 is recommended) ";
    cin >> size;
    cout<< "\n";
    switch (opt){
        
        
        //letters only + capitals
        case 11:
        {
            srand(time(0));
            while (actualSize<size){
                rnd = (rand()%26);
                cout << wordItensCaps[rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters only + capitals + non capitals
        case 12:
        {
            
            const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(wordItensCaps));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                else {
                    mergedArray[x]=wordItensCaps [x-sizeof(wordItensNoCaps)];
                }    
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
            
        }
        break;
        
            
        //letters only non capitals
        case 13:
        {
            srand(time(0));
            while (actualSize<size){
                rnd = (rand()%26);
                cout << wordItensNoCaps[rnd];
                actualSize++;
            };
        }
        break;
        
        //Numbers only
        case 20:
         {
            srand(time(0));
            while (actualSize<size){
                rnd = (rand()%10);
                cout << numbers[rnd];
                actualSize++;
            };
        }
        break;
        
        //specials only
        case 30:
         {
            srand(time(0));
            while (actualSize<size){
                rnd = (rand()%7);
                cout << specials[rnd];
                actualSize++;
            };
        }
        break;
        
        //letters + numbers + capitals
        case 41: 
        {
            const int sizeMerged = (sizeof(wordItensCaps)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensCaps)){
                    mergedArray[x]=wordItensCaps[x];
                }
                else {
                    mergedArray[x]= numbers [x-sizeof(wordItensCaps)];
                }    
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters+ numbers + non-capitals + capitals 
        case 42: 
        {
            const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(wordItensCaps)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                if (x<=(sizeof(wordItensNoCaps)+ sizeof(wordItensCaps))) {
                    mergedArray[x]=wordItensCaps [x-sizeof(wordItensNoCaps)];
                }
                else{
                    mergedArray[x] = numbers [x-(sizeof(wordItensNoCaps)+sizeof(wordItensCaps))];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //Letters + numbers + non-capitals
        case 43:
        {
            const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
               
                else{
                    mergedArray[x] = numbers [x-sizeof(wordItensNoCaps)];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters + specials + capitals
        case 51:
        {
            const int sizeMerged = (sizeof(wordItensCaps)+sizeof(specials));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensCaps)){
                    mergedArray[x]=wordItensCaps[x];
                }
                else{
                    mergedArray[x] = specials[x-sizeof(wordItensCaps)];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        //letters + specials + capitals + non-capitals
        case 52:
        {
             const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(wordItensCaps)+sizeof(specials));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                if (x<=(sizeof(wordItensNoCaps)+ sizeof(wordItensCaps))) {
                    mergedArray[x]=wordItensCaps [x-sizeof(wordItensNoCaps)];
                }
                else{
                    mergedArray[x] = specials [x-(sizeof(wordItensNoCaps)+sizeof(wordItensCaps))];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        //letters+specials+non-capitals
        case 53:
        {
            const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(specials));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                else{
                    mergedArray[x] = specials [x-sizeof(wordItensNoCaps)];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        //numbers + specials
        case 60:
        {
            const int sizeMerged = (sizeof(specials)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(specials)){
                    mergedArray[x]=specials[x];
                }
                else{
                    mergedArray[x] = numbers [x-sizeof(specials)];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters+ numbers+specials + capitals
        case 71: 
        {
            const int sizeMerged = (sizeof(specials)+sizeof(wordItensCaps)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensCaps)){
                    mergedArray[x]=wordItensCaps[x];
                }
                if (x<=(sizeof(wordItensCaps)+ sizeof(specials))) {
                    mergedArray[x]= specials [x-sizeof(wordItensCaps)];
                }
                else{
                    mergedArray[x] = numbers [x-(sizeof(wordItensCaps)+sizeof(specials))];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters + numbers + specials + non-capitals + capitals
        case 72:
        {
             const int sizeMerged = (sizeof(wordItensNoCaps)+sizeof(wordItensCaps)+sizeof(numbers)+sizeof(specials));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                if (x<=(sizeof(wordItensNoCaps)+ sizeof(wordItensCaps))) {
                    mergedArray[x]=wordItensCaps [x-sizeof(wordItensNoCaps)];
                }
                if (x <=(sizeof(wordItensNoCaps)+ sizeof(wordItensCaps)+sizeof(numbers))){
                    mergedArray[x] = numbers [x-(sizeof(wordItensNoCaps)+sizeof(wordItensCaps))];
                }
                else {
                    mergedArray[x] = specials [x-(sizeof(wordItensNoCaps)+sizeof(wordItensCaps)+sizeof(numbers))];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;
        
        
        //letters+numbers+specials+ non-captitals
        
        case 73:
        {
            const int sizeMerged = (sizeof(specials)+sizeof(wordItensNoCaps)+sizeof(numbers));
            char mergedArray[sizeMerged];
            srand(time(0));
            
            
            for(int x=0;x<sizeMerged;x++){
                if (x<=sizeof(wordItensNoCaps)){
                    mergedArray[x]=wordItensNoCaps[x];
                }
                if (x<=(sizeof(wordItensNoCaps)+ sizeof(specials))) {
                    mergedArray[x]= specials [x-sizeof(wordItensNoCaps)];
                }
                else{
                    mergedArray[x] = numbers [x-(sizeof(wordItensNoCaps)+sizeof(specials))];
                }
        
            }
            
            while (actualSize<size){
                rnd = (rand()%sizeMerged);
                cout << mergedArray [rnd];
                actualSize++;
            };
        }
        break;

	
   }

	cout <<"\nDo you want to generate a new password?(y/n) ";
	char option0;
	cin >> option0;
	if (option0=='y'|| option0=='Y'){
	        cout<< "\nFrom the same type?(y/n) ";
		char option2;
		cin >> option2;
		if (option2=='y'|| option2=='Y'){
			passgen(opt);		
		} else {
			option();
		}
	
	} else {
		quit();
	}
    
} 


//forces the aplication to quit
int quit (){
    return 0;
}





