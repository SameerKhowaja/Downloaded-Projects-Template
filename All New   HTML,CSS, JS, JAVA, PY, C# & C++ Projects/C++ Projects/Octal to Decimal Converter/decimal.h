#include<iostream>
#include<math.h>

using namespace std;

int quotient;
int rem;
int num;
int mul;

 int main(){

 int count = 0;
 int outnum;
 int finoutnum;
 int div;
 int initnum;

 cout << ("Input Decimal integer: ");
 cin >> num;
 count = 0;
 finoutnum = 0;
 initnum = num;

 while(num !=0) {

quotient = (num / 8);
rem = (num % 8);
 mul = pow(10, count);
count = count +1;
 outnum = (rem * mul);
 finoutnum = (finoutnum + outnum);
 num = quotient;
  }
cout << "The decimal number " << initnum << " is " << finoutnum << " in octal." << endl;
 }