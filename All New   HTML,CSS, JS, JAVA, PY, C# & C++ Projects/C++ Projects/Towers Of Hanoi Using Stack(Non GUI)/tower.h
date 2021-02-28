/*Rules Of This Mathematical Puzzle Or Game 
1. Only one disk can be moved at a time.
2. Each move consists of taking the upper 
disk from one of the stacks and placing it 
on the top of another stack i.e. the disk can 
be moved if it is the topmost disk of the 
stack.
3. No disk may be placed on the top of smaller 
disk.
The minimum number of moves required to 
solve Towers Of Hanoi puzzle is ((2^n)-1) 
moves, where n is the number of disks.*/
#include<iostream>
#include<math.h>
using namespace std;
class stack
{ public:
int a[49],top;
stack()
{ top=-1; }
void push(int ele)
{ top++;
a[top]=ele;
}
int pop()
{ int ret=a[top], *p;
   p=&a[top];
   top--;
   *p=0;
   return ret;
}
};
int max(int b,int c,int d)
{ int big=b;
   if(big<c)		big=c;
   else if(big<d)	big=d;
   return big;
}
stack r[3];
void display(stack r[3])
{ int t=max(r[0].top,r[1].top,r[2].top);
   while(t>=0)
	{cout<<r[0].a[t]<<" "<<r[1].a[t]<<" "<<r[2].a[t]<<endl;
	  t--;	
	}
}
void towers(int n,int f,int t,int aux)
{	if(n==1)
 		{cout<<"Move 1 From Tower "<<f<<" To Tower "<<t<<"."<<endl;
	  	  int g=r[f-1].pop();		r[t-1].push(g);
  	      display(r);	
  	      return ;
		}
towers(n-1,f,aux,t);
cout<<"Move "<<n<<" From Tower "<<f<<" To Tower "<<t<<endl;
int h=r[f-1].pop();		r[t-1].push(h);
display(r);
towers(n-1,aux,t,f);
}
int main()
{int n;
cout<<"Rules Of Solving The Towers Of Hanoi Problem"<<endl; 
cout<<"1. Only one disk can be moved at a time."<<endl;
cout<<"2. Each move consists of taking the upper "<<endl;
cout<<"disk from one of the stacks and placing it "<<endl;
cout<<"on the top of another stack i.e. the disk can "<<endl;
cout<<"be moved if it is the topmost disk of the stack."<<endl;
cout<<"3. No disk may be placed on the top of smaller disk."<<endl;
cout<<"The minimum number of moves required to "<<endl;
cout<<"solve Towers Of Hanoi puzzle is ((2^n)-1)"<<endl; 
cout<<"moves, where n is the number of disks."<<endl;
cout<<"Enter The Number Of Disks:"<<endl;
cin>>n;
for(int i=n;i>0;i--)
r[0].push(i);
display(r);
towers(n,1,3,2);
return 0;
}
