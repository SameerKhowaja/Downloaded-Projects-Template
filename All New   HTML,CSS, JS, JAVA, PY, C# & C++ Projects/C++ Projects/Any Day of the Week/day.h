#include <iostream>
#include <ctime>
using namespace std;


/*
 * This code uses Tomohiko Sakamoto's algorithm
*/
int DayOfWeek(int day, int month, int year)
{
    int t[12] = {0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
	year -= month < 3;
	return ((year + year/4 - year/100 + year/400 + t[month-1] + day)%7);
}


int main() {
    
    string Days[7] = {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};
    
    time_t now = time(0);
    tm *ltm = localtime(&now);
    
    int year = 1900 + ltm->tm_year;
    int month = 1+ltm->tm_mon;
    int day = ltm->tm_mday;
    
    bool done = false;
    
    cout << "Today is a " << Days[DayOfWeek(day, month, year)] << "." << endl;
    
    while(!done){
        cout << "Enter DD/MM/YYYY to see what day it is on that date: ";
        cin >> day >> month >> year;
        
        cout << day << "/" << month << "/" << year << " is a " << Days[DayOfWeek(day, month, year)] << "." << endl << endl;
        
        char in = ' ';
        
        while(tolower(in) != 'y' || tolower(in) != 'n'){
            cout << "Try another date? (Y/N): ";
            cin >> in;
            if(tolower(in) == 'n')
            {
                done = true;
                break;
            }
            else if(tolower(in) == 'y')
                break;
        }
        
        
        
    }
    
	return 0;
}