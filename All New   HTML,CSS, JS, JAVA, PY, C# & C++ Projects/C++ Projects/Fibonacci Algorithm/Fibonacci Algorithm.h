#include <iostream>
using namespace std;

int main() {
    
    int previous, next, fib;
    int i, num;
    
    cout<<"* A Program To Calculate Fibonacci Numbers *\n"<<endl;
    
    cout<<"Give a number: ";
    cin>>num;
    
        if(num == 0 || num == 1)
        {
            cout<<"\The Fibonacci of number "<<num<<" is "<<num<<"."<<endl;
            return 0;
        }
        
        previous= 0;
        next= 1;
        
        for(i=2;i<=num;i++)
        {
            fib = previous+next;
            previous = next;
            next = fib;
        }
    
    cout<<"\nThe Fibonacci of "<<num<<" is "<<fib<<endl;
    
    return 0;
}