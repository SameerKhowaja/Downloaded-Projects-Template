# include <iostream>
# include <cstdlib>
# include <string>
#include <conio.h>
using namespace std;
int main(){
	
	
	
	
	// Muhammed ALi Khaskia 
	// Facebook.com/mo1994
	// Mohamedalik88@gmail.com
	//2013
	
	
	
	
	
	
	
	unsigned int num ;
	int right , left,r1,l1,r2,l2,l3,r3,l4,r4,l5,r5,n ;
	
	int k;
	string ones[]={"-" ,"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve",
	" thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"};
	 
	string  tens[]={"twenty","thirty" ,"foutry", "fifty", "sixty", "seventy" ,"eighty" ,"ninety"};
    string  hun[]= {"one hundred","two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred"};
    string  thou[]= {"one Thousand","two Thousand", "three Thousand", "four Thousand", "five Thousand", "six Thousand", "seven Thousand", "eight Thousand", "nine Thousand"};
    string  tens2[]={"twenty","thirty" ,"foutry", "fifty", "sixty", "seventy" ,"eighty" ,"ninety"};
    string  tens3[]={"ten thousand","eleven Thousand", "twelve Thousand"," thirteen Thousand", "fourteen Thousand", "fifteen Thousand", "sixteen Thousand", "seventeen Thousand", "eighteen Thousand", "nineteen Thousand", "twenty Thousand"};
    string  mil[]={"one million", "two million", "three million", "four million", "five million", "six million", "seven million", "eight million", "nine million", "ten million"};
         system("color 80");




	
//do{
	

    cout << "Enter A Number From 1 To 999999 "<<endl;
    cin >> num;
    cout<<"\nyou enterd\t"<<num<<endl<<endl;
    
    system("color 91");
    
   if (num < 0 ){cout << " it is negative";}
   else if (num>0 && num <=19){cout <<"the number is : \t" << ones[num]<<endl;}
   
   
   else if (num >=20 && num <=99){
   	right = num % 10 ;
   	left = num / 10  ;
   	cout <<"the number is : \t" << tens[left-2] <<"-"<< ones[right]<<endl;}
   	
  	

   	
   	
  else if (num >=100 && num <=999){
  	
  	    
	   	l1 = num / 100;
	   	r1 = num %100;         
	   	
	   	right = r1 % 10 ;
        left = r1 / 10  ;
        if (right==0) {cout <<"the number is : \t"<< hun[l1-1]<<endl;}
        else if (left==0) {cout <<"the number is : \t"<< hun[l1-1]<<" and "<<ones[right]<<endl;}
        else if (left==1){cout <<"the number is : \t"<< hun[l1-1]<<" and "<<ones[right+10]<<endl;}
        else
		cout <<"the number is : \t"<< hun[l1-1]<<" and "<<tens[left-2]<<" "<<ones[right]<<endl;
     }
   	
   	else if (num>=1000 &&num <=9999){
	   	
   	     l2 = num / 1000;
	   	r2 = num %1000;
	   	
	   	l1 = r2 / 100;
	   	r1 = r2 %100;
	   	
	   	right = r1 % 10 ;
        left = r1 / 10  ;
        
        
         if (left==1 && l1==0  ){cout <<"the number is: \t "<<thou[l2-1]<<" and "<<ones[right+10]<<endl;}
         
          else if (l1==0 ) {cout <<"the number is: \t "<<thou[l2-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
         
        else if (l1==0 && left==0) {cout <<"the number is: \t "<<thou[l2-1]<<" "<<ones[right]<<endl;}
        else if (left==0) {cout <<"the number is: \t "<<thou[l2-1]<<" and "<<hun[l1-1]<<endl;}
           else if (left==1){cout <<"the number is: \t "<<thou[l2-1]<<" and "<<hun[l1-1]<<"and"<<ones[right+10]<<endl;}
          else
        cout <<"the number is: \t "<<thou[l2-1]<<" and "<<hun[l1-1]<<" and "<<tens[left-2]<<" "<<ones[right]<<endl;
        
	}
		 	

     	else if (num >=10000 && num <20000){
	   	
	   
	   	l3= num / 10000;
	   	r3 = num % 10000;
	   	
	   	l2 = r3 / 1000;
	   	r2 = r3 %1000;
	   	
	   	l1 = r2 / 100;
	   	r1 = r2 %100;
	   	
	   	right = r1 % 10 ;
        left = r1 / 10  ;
        //if (l1==0 && l2==0){cout <<"the number is: \t " <<tens3[l2]<<" "<<ones[right]<<endl;}
         if (left==1 && l1==0  ){cout <<"the number is: \t " <<tens3[l2] <<" and "<<ones[right+10]<<endl;}
  	  	else if (l2==0){cout <<"the number is: \t " <<"ten thousand" <<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
		else if(l1==0){cout <<"the number is: \t " <<tens3[l2] <<" "<<ones[right]<<endl;}
		else if (left==0){cout <<"the number is: \t " <<tens3[l2] <<" and "<<hun[l1-1]<<" and "<<ones[right]<<endl;}
		 else if (left==1){cout <<"the number is: \t " <<tens3[l2] <<" and "<<hun[l1-1]<<" and "<<ones[right+10]<<endl;}
         else
	   	cout <<"the number is: \t " <<tens3[l2] <<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;} 
     	

   	else if (num >=20000 && num <=99999){
	   	
	   
	   	l3= num / 10000;
	   	r3 = num % 10000;
	   	
	   	l2 = r3 / 1000;
	   	r2 = r3 %1000;
	   	
	   	l1 = r2 / 100;
	   	r1 = r2 %100;
	   	
	   	right = r1 % 10 ;
        left = r1 / 10  ;
         
        if (left==1 && l1==0  ){cout <<"the number is: \t " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<ones[right+10]<<endl;}
        
       else if (left==0){cout <<"the number is: \t " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" "<<"and"<<" "<<ones[right]<<endl;}
       else if (l1==0){cout <<"the number is: \t " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
       else if (l2==0){cout <<"the number is: \t " <<tens2[l3-2] <<" thosand "<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
       else if (l1==0 && l2==0 ){cout <<"the number is: \t " <<tens2[l3-2]<<"thousand" <<tens[left-2]<<" "<<ones[right]<<endl;}
	   else if (left==1){cout <<"the number is: \t " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" and "<<ones[right+10]<<endl;}
       else
	   	cout <<"the number is: \t " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;} 
   	   
   	   
   	   
   	else if (num >100000 && num <=999999){
	   	l4=num / 100000;
	   	r4=num % 100000;
	   
	   	l3= r4 / 10000;
	   	r3 = r4 % 10000;
	   	
	   	l2 = r3 / 1000;
	   	r2 = r3 %1000;
	   	
	   	l1 = r2 / 100;
	   	r1 = r2 %100;
	   	
	   	right = r1 % 10 ;
        left = r1 / 10  ;
	   	
	   	
	   	
	   	if (left==1 && l1==0  ){cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<ones[right+10]<<endl;}
   	   else if (left==0){cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" "<<" and "<<" "<<ones[right]<<endl;}
       else if (l1==0){cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}	
       else if (l2==0){cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}	
       else if (l3==0){cout <<"the number is: \t "<<hun[l4-1]<<" and " <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}	
       else if (left==1  ){cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" and "<<ones[right+10]<<endl;}
       else if (l3==1  ){cout <<"the number is: \t "<<hun[l4-1]<<" and " <<ones[l2+10] <<" thousand"<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
	   
       else
	   	cout <<"the number is: \t "<<hun[l4-1]<<" " <<tens2[l3-2] <<" "<< thou[l2-1]<<" and "<<hun[l1-1]<<" "<<tens[left-2]<<" "<<ones[right]<<endl;}
	   	
	   
	else
	cout<<"\nerror- please enter a number between 1 and 999999"<<endl;   
	    
	    	
   system("color 80");
   //cout <<"\n\n\n if you want to do it again press 1 or 0 to Exit  \n";
  // cin>>k;
   //}
   //while(k == 1);
	//cout<<"Bye\n\n";
	cout<<"\nThanks :) \n\n";

   
}