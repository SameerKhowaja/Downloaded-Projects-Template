#include<iostream> 
using namespace std;

int main() 

{ 

int a[5][5],b[5][5],t[5][5],i,j,k,l,m,n,z,c[5][5],x,y; //declarations 

 

  

//User inputs 

cout<<"enter the order of the matrix > "; 

cin>>x; 

//Matrix1 

cout<<endl<<"enter the 1st matrix elements > "; 

for(i=0;i<x;i++) 

{ 

for(j=0;j<x;j++) 

{ 

cin>>a[i][j]; 

} 

} 

//Matrix2 

cout<<endl<<"enter the 2nd matrix elements > "; 

for(i=0;i<x;i++) 

{ 

for(j=0;j<x;j++) 

{ 

cin>>b[i][j]; 

} 

} 

  

//Sum Calculation 

cout<<endl<<"SUM...."<<endl; 

for(i=0;i<x;i++) 

{ 

for(j=0;j<x;j++) 

{ 

cout<<" "<<a[i][j]+b[i][j]; 

} 

cout<<endl; 

} 

  

//User Input 

cout<<"enter the order of the 4 matrices > "; 

cin>>k; 

cin>>l; 

cin>>m; 

cin>>n; 

cout<<endl<<"enter the 1st matrix elements > "; 

for(i=0;i<k;i++) 

{ 

for(j=0;j<l;j++) 

{ 

cin>>a[i][j]; 

} 

} 

cout<<endl<<"enter the 2nd matrix elements > "; 

for(i=0;i<m;i++) 

{ 

for(j=0;j<n;j++) 

{ 

cin>>b[i][j]; 

} 

} 

  

//Product Calculation 

if(l==m) 

{ 

for(i=0;i<k;i++) 

{ 

for(j=0;j<n;j++) 

{ 

c[i][j]=0; 

for(z=0;z<l;z++) 

{ 

c[i][j]=c[i][j]+(a[i][z]*b[z][j]); 

} 

} 

}               } 

else 

{ 

cout<<"invalid data...."; 

} 

  

//Display Result 

cout<<endl<<"PRODUCT..."<<endl; 

for(i=0;i<k;i++) 

{ 

for(j=0;j<n;j++) 

{ 

cout<<" "<<c[i][j]; 

} 

cout<<endl; 

} 

  

//User Input 

cout<<"enter the order of the matrix > "; 

cin>>x; 

cin>>y; 

cout<<endl<<"enter the matrix elements     > "; 

for(i=0;i<x;i++) 

{ 

for(j=0;j<y;j++) 

{ 

cin>>a[i][j]; 

} 

} 

cout<<"matrix..."<<endl; 

for(i=0;i<x;i++) 

{ 

for(j=0;j<y;j++) 

{ 

cout<<" "<<a[i][j]; 

} 

cout<<endl; 

} 

  

//Transpose 

cout<<endl<<"transpose..."<<endl; 

for(i=0;i<y;i++) 

{ 

for(j=0;j<x;j++) 

{ 

t[i][j]=a[j][i]; 

} 

} 

for(i=0;i<y;i++) 

{ 

for(j=0;j<x;j++) 

{ 

cout<<" "<<t[i][j]; 

} 

cout<<endl; 

} 

  

//User Input 

cout<<endl<<"enter the elements of a 3*3 matrix > "; 

for(i=0;i<3;i++) 

{ 

for(j=0;j<3;j++) 

{ 

cin>>a[i][j]; 

} 

} 

  

//Calculation of Determinant 

z=(a[0][0]*(a[1][1]*a[2][2])-(a[2][1]*a[1][2]))-(a[0][1]*(a[1][0]*a[2][2])-(a[2][0]*a[1][2]))+(a[0][2]*(a[1][0]*a[2][1])-(a[2][0]*a[1][1])); 

cout<<endl<<"determinant = "<<z; 

  

//To check if it is a singular matrix 

if(z==0) 

{ 

cout<<endl<<"this is a singular matrix..."; 

} 

else 

{ 

cout<<endl<<"this is not a singular matrix..."; 

} 

return 0;

} 
