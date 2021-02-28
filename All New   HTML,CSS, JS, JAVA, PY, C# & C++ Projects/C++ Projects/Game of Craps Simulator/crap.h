// Autor: Brayan Kelly Balbune
// Date: 27/5/2016
// project name:craps_game.c
// Simulating the game of craps.

#include <iostream>
#include <cstdlib>
#include <ctime>

using namespace std;
// enumaration constants represent game status
enum Status { CONTINUE, WON, LOST };

int roll_dice( void ); // function prototype

int main( void )
{
	int sum; // sum of rolled dice
	int my_point; // player must make this point to winn
    enum Status game_status; // contain CONTINUE, WOM or LOST
    
    // randomize random number generator using current time
    srand( time( NULL ) );
	sum = roll_dice(); //fist roll of the dice
	
	// determinate game status based on sum of dice
	switch( sum ) {
		
		// wind of first roll
		case 7: // 7 is winner 
	    case 11: // 11 is winner
	        game_status = WON; // game has been won
	        break;
	    
	    // lose on first roll
	    case 2: // is a loser
	    case 3: // is a loser
	    case 12: // is a loser
	    	game_status = LOST; // game has been lost
	    	break;
	    
	    // remember point
	    default:
	    	game_status = CONTINUE; // player should keep rolling
	    	my_point = sum; // remember the point
	    	cout << "Point is " << my_point << endl;
	    	break;
	}
	
	// while game not complete
	while ( CONTINUE == game_status ) { // player should keep rol
		sum = roll_dice(); // roll dice again
		
		// determinate game status
		if ( sum == my_point ) { // win by making point
			game_status = WON; // game over, player won
		} 
		else {
			if ( 7 == sum ) { // lose rolling 7
				game_status = LOST; // game over, player lost
			} 
		}
	}
	
	// display won or lost message
	if ( WON == game_status ) { // did player win?
		cout << "Player wins " << endl;
	}
	else { // player lost
		cout << "Player loses " << endl;
	}
	
	return 0;
}

// roll dice, calculate sum and display results
int roll_dice( void )
{
	int die1 = 0; // first die
	int die2 = 0; // secoond die
	int work_sum = 0; // sum of die
	
	die1 = 1 + ( rand() % 6 ); // pick random die1 value
	die2 = 1 + ( rand()  % 6); // pick random die1 value
	work_sum = die1 + die2; // sum die1 and die2
	
	cout <<  "Player rolled " << die1 << " + " << die1 
		 << " = " << work_sum << endl;
		
	return work_sum;
}