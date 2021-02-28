#include<iostream>
using namespace std;
int main()
{
	int n = 6;
	for( int k = 0; k < 6; k++ )
	{
		cout<<k<<endl;
		for( int i = -6; i <= 6; i++)
		{
			for ( int j = -6; j <= 6; j++)
			{
				int d = ( i < 0 ? -i : i) + ( j < 0 ? -j : j);
				 d == n  ||( d > n  &&  ( !i || !j ) )  ?  cout << "*" : cout<< ".";
			}
			cout << '\n';
		}
		--n;
	}
	return 0;
}
 
 

