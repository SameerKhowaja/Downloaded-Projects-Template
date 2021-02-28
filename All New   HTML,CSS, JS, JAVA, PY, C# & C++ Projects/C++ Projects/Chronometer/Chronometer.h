#include <iostream>
#include <stdlib.h>
#include <windows.h>
using namespace std;

int main()
{

    int segs=0;
    int mins=0;
    int hors=0;
    int dias=0;

    for (int alfa=1; alfa<=8; alfa++)
    {

        cout << "Cron\xa2metro\n\n\n\n" <<endl;

        if (alfa==8){alfa=0;}
        if (alfa==0){cout << "0 1 0\n0 \x18 0\n0 0 0" << '\a'; segs++;}
        if (alfa==1){cout << "0 0 1\n0 \x2f 0\n0 0 0" ;}
        if (alfa==2){cout << "0 0 0\n0 \x1a 1\n0 0 0" ;}
        if (alfa==3){cout << "0 0 0\n0 \x5c 0\n0 0 1" ;}
        if (alfa==4){cout << "0 0 0\n0 \x19 0\n0 1 0" ;}
        if (alfa==5){cout << "0 0 0\n0 \x2f 0\n1 0 0" ;}
        if (alfa==6){cout << "0 0 0\n1 \x1b 0\n0 0 0" ;}
        if (alfa==7){cout << "1 0 0\n0 \x5c 0\n0 0 0" ;}
        if (segs==60){segs=0;mins++;cout<<'\a';}
        if (mins==60){mins=0;hors++;cout<<'\a';}
        if (hors==24){hors=0;dias++;cout<<'\a';}

        cout << "\n\n\n\n\nSegs: " << segs;
        cout << "\n\nMins: " << mins;
        cout << "\n\nHoras: " << hors;
        cout << "\n\nD\xa1\x61s: " << dias;
        cout << "\n\n\n\n\nXephyrian";

        Sleep(105);

        system("cls");

    }


return 0;
}
