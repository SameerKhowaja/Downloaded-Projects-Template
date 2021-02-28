#include <iostream>
#include <stdio.h>
#include <cstdlib>

using namespace std;

class queue_list
{
private:
    int top;
    int queue_array[10];

public:
    int last;
    queue_list()
    {
        queue_array[0]=top;
        last=0;
    }

    void clear_queue();
    bool isEmpty();
    void enqueue(int a);
    int dequeue();
    void print_me();
    bool isFull();

};

void queue_list::enqueue(int el)
{
   queue_array[last]= el;
   last++;
}

int queue_list::dequeue()
{
    for(int i=0;i<=last;i++)
    {
        queue_array[i]=queue_array[i+1];
    }

    last = (last -1) ;
    return top;
}

void queue_list::print_me()
{
    for(int i=0;i<last;i++)
    {
        cout<<" "<< queue_array[i] <<"\t";
    }
    cout<<endl;

}

void queue_list::clear_queue()
{
    last = 0;
}

int main()
{
    cout<<"================="<<"W E L C O M E"<<"================="<<endl;

    //cout<<"(c)2016 Bodhi "<<"All Rights Reserved"<<endl
 queue_list q1,q2,q3;

 int number=0;
 int q1count=0;
 int q2count=0;
 int q3count=0;
 int value=0;
 bool full=false;
 bool Empty=false;
 int q1exit=0;
 int q2exit=0;
 int q3exit=0;
 int a=0;
 int b=0;
 int c=0;
 int d=0;


 for(;;)
 {
//Data Input
    char data='/0';
    int r =0;
    if(full == true)
    {
        a=33;
        b=66;
        c=99;
        d=100;
    }
    else
    {
        a=10;
        b=20;
        c=25;
        d=100;
    }
        for(int i=0;i<=1000;i++)
        {
            for(int j=0;j<=500000000;j++)
            {
            }
                    r = (rand() % 100);
                    //cout<<r<<" ";
                    if(r<=a && q3.last !=0)
                    {
                        cout<<"Dequeue from 3"<<endl;
                        data ='3';
                        break;
                    }
                    if((r>a) && (r<=b) && q1.last !=0)
                    {
                        cout<<"Dequeue from 1"<<endl;
                        data ='1';
                        break;
                    }
                    if((r>b) && (r<=c) && q2.last !=0)
                    {
                        cout<<"Dequeue from 2"<<endl;
                        data ='2';
                        break;
                    }
                    if((r>c) && (r<=d))
                    {
                        cout<<"Enqueue"<<endl;
                        data ='i';
                        break;
                    }
                    if(Empty==true)
                        break;

        }

    if((data == 'i') && (full == false))
         {
             number++;
             //cout<<number<<endl;

           //Sorting part
            q1count=q1.last;
            q2count=q2.last;
            q3count=q3.last;

            int low=0;
                if(q1count<=q2count)
                   {
                    low=q1count;
                    value=1;
                   }
                else
                {
                    low=q2count;
                    value=2;
                }

                if(low<=q3count)
                    low=low;
                else
                    {
                        low=q3count;
                        value=3;
                    }
            //Enqueue Part

                if((value==1) && (full==false))
                    q1.enqueue(number);
                if((value==2) && (full==false))
                    q2.enqueue(number);
                if((value==3) && (full==false))
                    q3.enqueue(number);

         }

    if((data == '1') && q1.last !=0)
    {
        //full =false;
        q1.dequeue();
        q1exit++;
    }

    if((data == '2') && q2.last !=0)
    {
        //full =false;
        q2.dequeue();
        q2exit++;
    }

    if((data == '3') && q3.last !=0)
    {
        //full =false;
        q3.dequeue();
        q3exit++;
    }

            cout<<"-------------------------------------------------------------------"<<endl;
            q1.print_me();
            cout<<"-------------------------------------------------------------------"<<endl;
            q2.print_me();
            cout<<"-------------------------------------------------------------------"<<endl;
            q3.print_me();
            cout<<"-------------------------------------------------------------------"<<endl;

            if(number==15)
            {
                full = true;
            }

            cout<<q1.last<<" "<<q2.last<<" "<<q3.last<<endl;

        if(q1.last ==0 && q2.last ==0 && q3.last ==0)
                    {
                    //cout<<"empty"<<endl;
                    Empty =true;
                    break;
                    }
}


cout<<"Todays Summary ::"<<endl;
cout<<"Total people = "<<number<<endl;
cout<<"Exit from counter 1 = "<<q1exit<<endl;
cout<<"Exit from counter 2 = "<<q2exit<<endl;
cout<<"Exit from counter 3 = "<<q3exit<<endl;

}
