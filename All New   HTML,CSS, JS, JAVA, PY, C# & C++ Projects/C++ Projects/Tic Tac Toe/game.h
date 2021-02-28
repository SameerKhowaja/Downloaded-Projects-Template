#include<iostream>
using namespace std;
char draw[3][3];
char player1 = 'X', player2 = 'O';
void layout();
void p1();
char p1cw();
void p2();
char p2cw();
int main()
{
	int s,flag=0;
   layout();
   for(s=0;s<5;s++)
   {
	   p1();
	   if (p1cw() == 'X')
	   {
		   cout << "Player1 Wins!" << endl;
		   break;
	   }
	   flag++;
	   if (flag == 5)
		   break;
	   p2();
	   if (p2cw() == 'O')
	   {
		   cout << "Player2 Wins" << endl;
		   break;
	   }
   }
   if (flag == 5)
	   cout << "Game Draw!" << endl;
return 0;
}
void layout()
{
	cout << "Tic Tac Toe!" << endl;
	cout << "Rows And Column You Can Enter" << endl;
	cout << "00 01 02" << endl;
	cout << "10 11 12" << endl;
	cout << "20 21 22" << endl;
	cout << "Tic Tac Toe" << endl;
	cout << "Player1 = X and Player2 = O" << endl;
	int flag = 0;
	for (int i = 0;i < 3;i++)
	{
		for (int j = 0;j < 3;j++)
		{
			draw[i][j] = 'v';
			cout << draw[i][j] << " ";
		}
		cout << endl;
	}

}
void p1()
{
	int a, b;
	k:
		cout << "Player 1 Enter Row And Column: ";
		cin >> a >> b;
		if ((a == 0 && b == 0) || (a == 0 && b == 1) || (a == 0 && b == 2) || (a == 1 && b == 0) || (a == 1 && b == 1) || (a == 1 && b == 2) || (a == 2 && b == 0) || (a == 2 && b == 1) || (a == 2 && b == 2))
		{
			if (draw[a][b] == 'X' || draw[a][b] == 'O')
			{
				cout << "Value is Already Present In This Place. Try Again!" << endl;
				goto k;
			}
			draw[a][b] = player1;

			for (int p = 0;p < 3;p++)
			{
				for (int q = 0;q < 3;q++)
				{
					cout << draw[p][q] << " ";
				}
				cout << endl;
			}
		}
		else
		{
			cout << "Invalid Entry. Try Again!" << endl;
			goto k;
		}


}
char p1cw()
{
	//Horizental Checking
	if (draw[0][0] == 'X' && draw[0][1] == 'X' && draw[0][2] == 'X')
	{
		return 'X';
	}
	else if (draw[1][0] == 'X' && draw[1][1] == 'X' && draw[1][2] == 'X')
	{
		return 'X';
	}
	else if (draw[2][0] == 'X' && draw[2][1] == 'X' && draw[2][2] == 'X')
	{
		return 'X';
	}
	//Digonal Checking
	else if (draw[0][0] == 'X' && draw[1][1] == 'X' && draw[2][2] == 'X')
	{
		return 'X';
	}
	else if (draw[0][2] == 'X' && draw[1][1] == 'X' && draw[2][0] == 'X')
	{
		return 'X';
	}
	//Vertical Checking
	else if (draw[0][0] == 'X' && draw[1][0] == 'X' && draw[2][0] == 'X')
	{
		return 'X';
	}
	else if (draw[0][1] == 'X' && draw[1][1] == 'X' && draw[2][1] == 'X')
	{
		return 'X';
	}
	else if (draw[0][2] == 'X' && draw[1][2] == 'X' && draw[2][2] == 'X')
	{
		return 'X';
	}
	return '/';
}
void p2()
{
	int a, b;
again:
	cout << "Player 2 Enter Row And Column: ";
	cin >> a >> b;
	if ((a == 0 && b == 0) || (a == 0 && b == 1) || (a == 0 && b == 2) || (a == 1 && b == 0) || (a == 1 && b == 1) || (a == 1 && b == 2) || (a == 2 && b == 0) || (a == 2 && b == 1) || (a == 2 && b == 2))
	{
		if (draw[a][b] == 'X' || draw[a][b] == 'O')
		{
			cout << "Value is Already Present In This Place. Try Again!" << endl;
			goto again;
		}
		draw[a][b] = player2;

		for (int r = 0;r < 3;r++)
		{
			for (int t = 0;t < 3;t++)
				cout << draw[r][t] << " ";
			cout << endl;
		}
	}
	else
	{
		cout << "Invalid Entry. Try Again!" << endl;
		goto again;
	}

}
char p2cw()
{
	//Check Win For Player 2
	//Check Winner:
	//Horizental Checking
	if (draw[0][0] == 'O' && draw[0][1] == 'O' && draw[0][2] == 'O')
	{
		return 'O';
	}
	else if (draw[1][0] == 'O' && draw[1][1] == 'O' && draw[1][2] == 'O')
	{
		return 'O';
	}
	else if (draw[2][0] == 'O' && draw[2][1] == 'O' && draw[2][2] == 'O')
	{
		return 'O';
	}
	//Digonal Checking
	else if (draw[0][0] == 'O' && draw[1][1] == 'O' && draw[2][2] == 'O')
	{
		return 'O';
	}
	else if (draw[0][2] == 'O' && draw[1][1] == 'O' && draw[2][0] == 'O')
	{
		return 'O';
	}
	//Vertical Checking
	else if (draw[0][0] == 'O' && draw[1][0] == 'O' && draw[2][0] == 'O')
	{
		return 'O';
	}
	else if (draw[0][1] == 'O' && draw[1][1] == 'O' && draw[2][1] == 'O')
	{
		return 'O';
	}
	else if (draw[0][2] == 'O' && draw[1][2] == 'O' && draw[2][2] == 'O')
	{
		return 'O';
	}

	return '/';
}