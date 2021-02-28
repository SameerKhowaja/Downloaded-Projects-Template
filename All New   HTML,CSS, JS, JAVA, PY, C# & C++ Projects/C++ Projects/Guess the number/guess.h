#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;
int b,a, number;
int main() {
    cout<<"Let's play game!\nGuess 1 number from 1 to 20\n";
    cout<<"You have 3 lives to guess \n";
    cout<<"Good luck!\n";
    srand(time(0));
    
    a= 1 + (rand() % 20) ;
    for (int i=3; i>=1;i--){
     cout<<"Lives: "<<i<<endl;
     cin>>number;
     if (number>=a-2 && number<=a+2) cout<<"Almost there\n"; else
     if (number>=a-5 && number<=a+5) cout<<"Still too far, dude\n";else
     cout<<"Too far\n";
     if (number==a){
         cout<<"Congratulation!!!!\n";
         break;
     }
}   cout<<"The correct answer is "<<a;

    return 0;
}