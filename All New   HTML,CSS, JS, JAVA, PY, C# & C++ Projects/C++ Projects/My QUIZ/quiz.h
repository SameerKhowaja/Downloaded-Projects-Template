#include <iostream>

#include <string>

using namespace std;


void print_correct(){
    
    cout<<"\ncorrect! nice going!\n\n"; /* this is a function to print comments*/
}

void print_wrong(){
    cout<<"\nwrong, try again!\n"<<endl;/* this is a function to print a comment*/
}
int number=0; /*integers: number is the number of questions and used to give score out of number of questions*/
int score=0; /*score is number of correct answers out of total number*/

int vote(int S,int N,int T,int t,int P,int F,int J){  /*function to give final vote*/
int vote(int S=score,int N=number,int T=0,int t=0,int P=0,int F=0,int J=0);

    T=N/2; /*T is half the number of questions*/

    if (S>T){

    J=P; /*J is good pass*/
}
    if (S<T){

    J=F; /*J is fail*/
}

    if (S==T){

    J=t; /*J is border pass*/

    return J;

}




}
void printArray(string arr[],int size) {  /*function to print to possible answers */

    for(int x=0; x<size; x++) {

    cout <<arr[x]<< endl;
}

}




int main()

{

    string mystring;

    cout<<"\n\nwhat's your name? "; /* user asked to enter name*/

    cin>>mystring; /*user enters name*/

    cout << "\n\nHello "<<mystring<<"!\n\n"<<endl; /*programme greets user by name*/

int age=10;

    cout<<"how old are you? "<<mystring<<"?  "; /*user  asked to give age*/

    cin>>age; /*user enters age*/

if (age<=10){

   cout<<"\n\nWOW! you're young!! \n\n"<<endl; /* next lines use if statements to make comments on age*/
}

if(age>10 && age<60){   /*IF statements*/

   cout<<"\n\nthat's a nice age!  "<<endl;
}
if (age>=60){

    cout<<"\n\nWOW!! you are an old goat aren't you!  "<<endl;
}
//next char values used to set Char values for answer. User can use capital or small letters for answer. There are 4 possible answers and two variations

char a='a';
char A='A';
char B='B';
char b='b';
char c='c';
char C='C';
char d='d';
char D='D';
char x;//this char is used for the the user input



cout << "\n\nThis is a mini quiz. You have 3 attempts for each question!\n\n";


string Q1= "Q.1. where is London?";

string A1a= " a) In France ";
string A1b=" b) In Germany ";
string A1c=" c) In Italy ";
string A1d=" d) In England ";

string Q2="Q.2. Which river passes through London?";

string A2a= " a) The Thames ";
string A2b=" b) The river Seven ";
string A2c=" c) The Rocky river ";
string A2d=" d) The Rhine ";

string Q3="Q.3. where is Rome?";

string A3a= " a) In France ";
string A3b=" b) In England ";
string A3c=" c) In Italy ";
string A3d=" d) In Germany ";

string Q4="Q.4. Which river is found in Italy?";

string A4a=" a) Amazon ";
string A4b=" b) Tevere ";
string A4c=" c) Thames ";
string A4d=" d) Nile ";



string question1[1]={Q1}; /* this is an array to hold the question*/
string answer1[4]={A1a,A1b,A1c,A1d}; /*this is an array using strings. it is used to store the possible answers */

string question2[1]={Q2};
string answer2[4]={A2a,A2b,A2c,A2d};

string question3[1]={Q3};
string answer3[4]={A3a,A3b,A3c,A3d};

string question4[1]={Q4};
string answer4[4]={A4a,A4b,A4c,A4d};


// question 1111111111111111111111111111111111111111111111111

int y=0;

	cout<<"\n\n"<<question1[0]<<"\n\n"<<endl; /* prints out the question calling data stored as array*/

++number;

	printArray(answer1,4); /*calls function to print possible answers stored in array*/

	cout<<"\n\nanswer: ";

	cin>>x; /*user enters an option*/

++y;

while (!(x==d||x==D)&&y<3){  /*this is a while  loop to evaluate the answer given. if answer is not correct then next line*/


    print_wrong(); /*function to print out that the answer is wrong and user must try again for total 2 attempts*/

    cout<<"\nanswer: "; /* user  tries again*/

    cin>> x; /*next attempt*/

++y; /*this acts a counter*/

}

if(!(x==d||x==D)){  /* this is an if loop to check third attempt*/

    cout<<"\nwrong again!\n\n"<<endl; /*if conditions not met then user told the answer is wrong again and next question is asked*/

}

if((x==d||x==D)){ /*if answer is correct then score below is increased by one point*/

++score;

    print_correct();  /*function to print that the answer is correct*/

}

// question 222222222222222222222222222222222222222222222222222

cout<<"\n\n"<<question2[0]<<"\n\n"<<endl;

++number;

	printArray(answer2,4);

	cout<<"\n\nanswer: ";

	cin>>x;

y=0; /*sets y counter back to zero for next question*/

++y;

while (!(x==a||x==A)&&y<3){  /*this is a while  loop*/


    print_wrong(); /*function*/

    cout<<"\nanswer: ";

    cin>> x;

++y; /*this acts a counter for number of chances*/

}

if(!(x==a||x==A)){  /* this is an if loop*/

    cout<<"\nwrong again!\n\n"<<endl;

}

if((x==a||x==A)){

++score;

    cout<<"\ncorrect! well done!\n\n";


}

// question 333333333333333333333333333333333333333333333

y=0;

    cout<<"\n\n"<<question3[0]<<"\n\n"<<endl;

++number;

	printArray(answer3,4);

	cout<<"\n\nanswer: ";

	cin>>x;


++y;

while (!(x==c||x==C)&&y<3){  /*this is a while  loop*/


    print_wrong(); /*function*/

    cout<<"\nanswer: ";

    cin>> x;

++y; /*this acts a counter*/

}

if(!(x==c||x==C)){  /* this is an if loop*/

    cout<<"\nwrong again!\n\n"<<endl;

}

if((x==c||x==C)){

++score;


    cout<<"\ncorrect! keep going!\n\n";

}


// question 4444444444444444444444444444444444444444444444444444444

 y=0;

    cout<<"\n\n"<<question4[0]<<"\n\n"<<endl;

++number;

printArray(answer4,4);

	cout<<"\n\nanswer: ";

	cin>>x;


++y;

    while (!(x==b||x==B)&&y<3){  /*this is a while  loop*/


    print_wrong(); /*function*/

    cout<<"\nanswer: ";

    cin>> x;

++y; /*this acts a counter for number of chances to answer correctly*/

}

if(!(x==b||x==B)){  /* this is an if loop*/

    cout<<"\nwrong again!\n\n"<<endl;

}

if((x==b||x==B)){

++score;


    cout<<"\ncorrect!!\n";

}



    cout<<"your score was "<<score<<" out of " <<number<<"\n"<<endl;


int vote(int S=score,int N=number,int T=0,int t=2,int P=4,int F=1,int J=0);/* passes values to the function */

switch(vote()){  /*switch statement using result of function*/

    case (4):

        cout<<"your the best!\n\n";

        break;

    case(3):

        cout<<"very good!\n\n";

        break;

    case (2):

        cout<<"Not so good!\n\n";

        break;

    case (1):

        cout<<"go back to school you donkey!\n\n";

        break;

    case (0):

        cout<<"go back to school you donkey!\n\n";

        break;

}

return 0;

}
