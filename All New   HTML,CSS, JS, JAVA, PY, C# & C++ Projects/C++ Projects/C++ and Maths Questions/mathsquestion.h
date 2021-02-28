#include <iostream>

using namespace std;

//Start off by declaring and initializing main variables.
int initialchoice;
int mathsq1;
int mathsq2;
float mathsq3;
int mathsq4;
int mathsq5;
int mathstotalscore = 0;
string cppq1;
int cppq2;
string cppq3;
string cppq4;
string cppq5;
int cpptotalscore = 0;
//Functions need to be declared and initialized in reverse order (Last question first, second-to-last
//question second, etc, etc.)
void cppfinalscore() {
     cout<< "The test is over!" << endl << "You scored " <<  cpptotalscore  << " of a possible maximum of 5 points." << endl;
    if (cpptotalscore == 0){
        cout<< "Did you fail on purpose? :)"<<endl;
    }
    else if (cpptotalscore == 1) {
        cout<< "...Well, it wasn't a total catastrophe. Swat up some more and try again."<<endl;
    }
    else if (cpptotalscore == 2) {
        cout<< "Not great, but not bad either. Don't give up!"<<endl;
    }
    else if (cpptotalscore == 3) {
        cout<< "Not too shabby! Keep it up!"<<endl;
    }
    else if (cpptotalscore == 4) {
        cout<< "Hey, pretty good! You should be proud of yourself!"<<endl;
    }
    else {
        cout<<"Cheater. :)"<<endl;
    }
}

void cppq5check() {
    if (cppq5 == "heap" || cppq5 == "Heap") {
        cpptotalscore = cpptotalscore + 1;
        cout<<"Correct!"<<endl<<endl;
        cppfinalscore();
    }
    else {
        cout<<"Incorrect."<<endl<<endl;
        cppfinalscore();
    }
}

void cppquestion5() {
    cout<<"Final question:"<<endl<<"Memory in C++ programs are divided into two sections: Stack and...?"<<endl;
    cin>>cppq5;
    cppq5check();
}

void cppq4check() {
    if (cppq4 == "Protected" || cppq4 == "protected") {
        cpptotalscore = cpptotalscore + 1;
        cout<<"Correct!"<<endl<<endl;
        cppquestion5();
    }
    else {
    cout<<"Incorrect."<<endl<<endl;
    cppquestion5();
    }
}

void cppquestion4() {
    cout<<"Question 4:"<<endl<<"What are the names of the three class restriction types?"<<endl<<"Public, private and...?"<<endl;
    cin>>cppq4;
    cppq4check();
}

void cppq3check() {
    if (cppq3 == "fstream" || cppq3 == "<fstream>") {
        cpptotalscore = cpptotalscore + 1;
        cout<<"Correct!"<<endl<<endl;
        cppquestion4();
    }
    else {
        cout<<"Incorrect."<<endl<<endl;
        cppquestion4();
    }
    
}

void cppquestion3() {
    cout<<"Question 3:"<<endl<<"What is the name of the library that allows reading and writing to files?"<<endl;
    cin>>cppq3;
    cppq3check();
}

void cppq2check() {
    if (cppq2 == 2) {
        cpptotalscore = cpptotalscore + 1;
        cout<<"Correct!"<<endl<<endl;
        cppquestion3();
    }
    else {
        cout<<"Incorrect."<<endl<<endl;
        cppquestion3();
    }
}

void cppquestion2() {
    cout<<"Question 2:"<<endl<<"How many values can a boolean (bool) variable hold?" <<endl;
    cin>>cppq2;
    cppq2check();
}

void cppq1check() {
    if ( cppq1 == "cout" ) {
            cpptotalscore = cpptotalscore + 1;
            cout<<"Correct!"<<endl<<endl;
            cppquestion2();
    }
    else {
        cout <<"Incorrect."<<endl<<endl;
        cppquestion2();
    }
}

void cppquestion1() {
    cout<< "Question 1:"<<endl<<"What is the command used to output text to the console?" <<endl;
    cin>>cppq1;
    cppq1check();
}

void mathsfinalscore() {
    cout<< "The test is over!" << endl << "You scored " <<  mathstotalscore  << " of a possible maximum of 5 points." << endl;
    if (mathstotalscore == 0){
        cout<< "Did you fail on purpose? :)"<<endl;
    }
    else if (mathstotalscore == 1) {
        cout<< "...Well, it wasn't a total catastrophe. Swat up some more and try again."<<endl;
    }
    else if (mathstotalscore == 2) {
        cout<< "Not great, but not bad either. Don't give up!"<<endl;
    }
    else if (mathstotalscore == 3) {
        cout<< "Not too shabby! Keep it up!"<<endl;
    }
    else if (mathstotalscore == 4) {
        cout<< "Hey, pretty good! You should be proud of yourself!"<<endl;
    }
    else {
        cout<<"Cheater. :)"<<endl;
    }
}

void mathsq5check() {
    if (mathsq5 == 24) {
        mathstotalscore = mathstotalscore + 1;
        cout<< "Correct!"<< endl << endl;
        mathsfinalscore();
    }
    else {
        cout<<"Incorrect." << endl << endl;
        mathsfinalscore();
    }
}

void mathsquestion5() {
    cout <<"Final question: What is the answer to the following?" << endl;
    cout <<"(3 X 2)(1+3)" << endl;
    cin>>mathsq5;
    mathsq5check();
}

void mathsq4check() {
    if (mathsq4 == 9) {
        mathstotalscore = mathstotalscore + 1;
        cout<< "Correct!"<< endl << endl;
        mathsquestion5();
    }
    else
    {
         cout<< "Incorrect." << endl << endl;
         mathsquestion5();
    }
}

void mathsquestion4() {
    cout <<"Question 4:" << endl << "What is 36 divided by 4?"<<endl;
    cin>>mathsq4;
    mathsq4check();
}

void mathsq3check() {
    if (mathsq3 == 2.5)
    {
    mathstotalscore = mathstotalscore + 1;
    cout<< "Correct!"<< endl << endl;
    mathsquestion4();
    }
     else {
         cout<< "Incorrect." << endl << endl;
         mathsquestion4();
     }
}

void mathsquestion3() {
    cout <<"Question 3:" << endl << "What is the following equation, given in decimal form?" << endl;
    cout <<"5" << endl;
    cout <<"-" << endl;
    cout <<"2" << endl;
    cin>>mathsq3;
    mathsq3check();
}

void mathsq2check() {
    if (mathsq2 == 3) {
    mathstotalscore = mathstotalscore + 1;
    cout<< "Correct!"<< endl << endl;
    mathsquestion3();
    }
    else {
         cout<< "Incorrect." << endl << endl;
         mathsquestion3();
    }
}

void mathsquestion2() {
    cout<<"Question 2:" << endl << "What is the square root of 9?" << endl;
    cin>>mathsq2;
    mathsq2check();
}

void mathsq1check() {
if (mathsq1 == 14) {
    mathstotalscore = mathstotalscore + 1;
    cout<< "Correct!"<< endl << endl;
    mathsquestion2();
}
else {
    cout<< "Incorrect." << endl << endl;
    mathsquestion2();
    }
}

void mathsquestion1() {
	cout<< "Question 1:" << endl <<"What is 9 + 5?" << endl;
	cin>>mathsq1;
	mathsq1check();
}

//And finally, we initialize the program:

int main() {
    cout<<"Welcome! Please choose a category:"<<endl<<endl;
    cout<<"1: Maths"<<endl;
    cout<<"2: C++"<<endl<<endl;
    cin>>initialchoice;
    if (initialchoice == 1) {
        mathsquestion1();
    }
    if (initialchoice == 2) {
        cppquestion1();
    }
    return 0;
}