//CAT STYLIST APP
//STYLE YOUR CAT AND SHARE IT

// !!! look down for commands !!!
#include <iostream>
#include <string>
using namespace std;

class cat {
private:
int ears, eyes, belly, legs, tail;

string Ears()
{ 
switch(ears)
{ case 1: return "*  *";
case 2: return "' '"; 
case 3: return "? ?";
default:  return "^ ^";  }
}

string Eyes()
{
switch(eyes)
{ case 1: return " # # ";
case 2: return  " % % ";
case 3: return " + + ";
default: return " * * "; }
}

string Tail()
{
switch (tail) {
case 1: return "#";
case 2: return "x";
case 3: return "!";
case 4: return "?";
default: return "*"; }
}

string Belly()
{
switch (belly)
{ case 1: return "0";
case 2: return "%";
default: return "x"; }
}

string Legs()
{
switch (legs) {
case 1: return  "()   ()";
case 2: return  "{}   {}";
case 3: return  ")(   )(";
default: return "[]   []"; }
}
public:
cat()
{
ears = 0;
eyes = 0;
belly = 0;
legs = 0;
tail = 0;
}

void Change(int what)
{
    switch(what)
    {
        case 1: ears++; if(ears > 3) ears = 0;  break;
        case 2: eyes++; if(eyes > 3) eyes = 0; break;
        case 3: tail++; if(tail > 4) tail = 0; break;
        case 4: belly++; if(belly > 2) belly = 0; break;
        case 5: legs++; if(legs > 3) legs = 0; break;
    }
}

void Draw()
{
char bs = 47;
cout << "  " << Ears() << endl;
cout << "(" << Eyes() << ")" << "     " << Tail() << endl;
cout << "(  " << Belly () << "  )" << "    " << bs << endl;
cout << Legs() << "   " << bs << endl;
}
};

int main()
{
/*HEEEY! LOOK HERE
HERE ARE THE INPUT COMMANDS
1 - change ears
2 = change eyes
3 - change tail
4 - change belly
5 - change legs

use spaces to seperate commands

COPY THESE CATS AND SHARE WITH YOUR FRIENDS!!!
*/

bool show_commands = false; //type in false instead of true if you don't want to see a list of commands with the input


//very complicated cat generating mechanism
cat me;
int cmd;

while(true) {
me.Draw();
if(show_commands) cout << endl << "1 - change ears" << endl << "2 = change eyes" << endl << "3 - change tail" << endl << "4 - change belly" << endl << "5 - change legs";
cin >> cmd;
me.Change(cmd);
cout << endl << endl << endl;
}
return 0;
}