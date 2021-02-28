    #include<iostream>        //header file(s)
    using namespace std;

    float cost;               //declaring cos as a global variable

    void bill()               //function to print bill
    {  float dis=cost+(cost*14.01);
       float f_cost= cost + ((cost*14.10)/100)-((cost*10)/100);
        cout<<"------------------------------------------------------------------------------"<<endl;
        cout<<"                                  SKY MEGASTORE                               "<<endl;
        cout<<"------------------------------------------------------------------------------"<<endl;
        cout<<"Counter No. 1                          Agent Name: Mst. Parin Shah            "<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"Price of the item bought:              Rs"<<cost<<endl;
        cout<<"Service tax charged:                   14.01%"<<endl;
        cout<<"Amount:                                Rs"<<dis<<endl;
        cout<<"------------------------------------------------------------------------------"<<endl;
        cout<<""<<endl;
        cout<<"Our special discount:                  10.00%"<<endl;
        cout<<"Final amount:                          "<<f_cost<<endl;
        cout<<""<<endl;
        cout<<""<<endl;
        cout<<"Thank you for shopping. Do visit again."<<endl;
        cout<<"-------------------------------------------------------------------------------"<<endl;
    }

    void home_decor()          //function for home essentials

    { int ch;
    	cout<<"Welcome to the Home Decor Section"<<endl;
    	cout<<"What would you like to buy"<<endl;
    	cout<<"1. Living Room"<<endl;
    	cout<<"2. Kitchen"<<endl;
    	cout<<"3. Bedroom"<<endl;
        cin>>ch;
        switch (ch)
        {
            case 1: int ch1;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Sofa set                             Rs 21000.00"<<endl;
                    cout<<"2. Television Unit                      Rs 12000.00"<<endl;
                    cin>>ch1;
                    if(ch1==1)
                       cost=21000.00;
                    else if(ch1==2)
                       cost=12000.00;
                    break;
            case 2: int ch2;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Dining Table set                     Rs 24000.00"<<endl;
                    cout<<"2. Modular Cabinets                     Rs 50000.00"<<endl;
                    cin>>ch2;
                    if(ch2==1)
                       cost=24000.00;
                    else if(ch2==2)
                       cost=50000.00;
                    break;
            case 3: int ch3;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Double Bed with Side Table           Rs 24000.00"<<endl;
                    cout<<"2. 4-door Cupboards                     Rs 50000.00"<<endl;
                    cin>>ch3;
                    if(ch3==1)
                       cost=24000.00;
                    else if(ch3==2)
                       cost=50000.00;
                    break;
            default:cout<<"Wrong Choice!"<<endl;
                    cout<<"Please re-enter"<<endl;
        }
    }

    void cosmetics()          //function for cosmetics
    {  int ch;
        cout<<"Welcome to the Cosmetics section"<<endl;
    	cout<<"What would you like to buy"<<endl;
    	cout<<"1. Eye Liners"<<endl;
    	cout<<"2. Lipsticks"<<endl;
    	cout<<"3. Festive Special Combos"<<endl;
        cin>>ch;
        switch (ch)
        {
            case 1: int ch1;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Black                                Rs 210.00"<<endl;
                    cout<<"2. Colorful                             Rs 230.00"<<endl;
                    cin>>ch1;
                    if(ch1==1)
                       cost=210.00;
                    else if(ch1==2)
                       cost=230.00;
                    break;
            case 2: int ch2;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Moisturizing Lipstick                Rs 820.00"<<endl;
                    cout<<"2. Set of 18                            Rs 1500.00"<<endl;
                    cin>>ch2;
                    if(ch2==1)
                       cost=820.00;
                    else if(ch2==2)
                       cost=1500.00;
                    break;
            case 3: int ch3;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Wedding Box(set of 8)                Rs 2400.00"<<endl;
                    cout<<"2. Makeup Base Foundation Combo         Rs 1800.00"<<endl;
                    cin>>ch3;
                    if(ch3==1)
                       cost=2400.00;
                    else if(ch3==2)
                       cost=1800.00;
                    break;
            default:cout<<"Wrong Choice!"<<endl;
                    cout<<"Please re-enter"<<endl;
        }
    }

    void electronics()         //function for electronics
    {  int ch;
        cout<<"Welcome to the Electronics Section"<<endl;
    	cout<<"What would you like to buy"<<endl;
    	cout<<"1. Mobiles "<<endl;
    	cout<<"2. Cameras "<<endl;
    	cout<<"3. Television Sets"<<endl;
    	cin>>ch;
        switch (ch)
        {
            case 1: int ch1;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. ePhone 6s                            Rs 41450.00"<<endl;
                    cout<<"2. Nookia phone                         Rs 1200.00"<<endl;
                    cin>>ch1;
                    if(ch1==1)
                       cost=21450.00;
                    else if(ch1==2)
                       cost=1200.00;
                    break;
            case 2: int ch2;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Standard SLRs                        Rs 13500.00"<<endl;
                    cout<<"2. Special DSLRs                        Rs 126000.00"<<endl;
                    cin>>ch2;
                    if(ch2==1)
                       cost=13500.00;
                    else if(ch2==2)
                       cost=126000.00;
                    break;
            case 3: int ch3;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Sky OLED 3D TVs                      Rs 139000.00"<<endl;
                    cout<<"2. Shyam-Singh smart TVs                Rs 49999.00"<<endl;
                    cin>>ch3;
                    if(ch3==1)
                       cost=139000.00;
                    else if(ch3==2)
                       cost=49999.00;
                    break;
            default:cout<<"Wrong Choice!"<<endl;
                    cout<<"Please re-enter"<<endl;
        }
    }

    void childcare()      //function for child essentials
    {  int ch;
        cout<<"Welcome to the Child Care Section"<<endl;
    	cout<<"What would you like to buy"<<endl;
    	cout<<"1. Trams"<<endl;
    	cout<<"2. Clothes"<<endl;
    	cout<<"3. Toys"<<endl;
    	cin>>ch;
        switch (ch)
        {
            case 1: int ch1;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Standard trams                       Rs 21000.00"<<endl;
                    cout<<"2. Special twin trams                   Rs 1200.00"<<endl;
                    cin>>ch1;
                    if(ch1==1)
                       cost=21000.00;
                    else if(ch1==2)
                       cost=1200.00;
                    break;
            case 2: int ch2;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. For Girls"<<endl;
                    cout<<"2. For Boys"<<endl;
                    cin>>ch2;
                    if(ch2==1)
                    {int g;
                     cout<<"Please select the type: "<<endl;
                     cout<<"1. Casuals                              Rs 749.00"<<endl;
                     cout<<"2. Party Wear                           Rs 1299.00"<<endl;
                     cin>>g;
                     switch(g)
                     {
                        case 1: cost=749.00;
                         break;
                        case 2: cost=1299.00;
                         break;
                     }
                    }
                    else if(ch2==2)
                    {int b;
                     cout<<"Please select the type: "<<endl;
                     cout<<"1. Casuals                              Rs 649.00"<<endl;
                     cout<<"2. Party Wear                           Rs 1399.00"<<endl;
                     cin>>b;
                     switch(b)
                     {
                        case 1: cost=649.00;
                         break;
                        case 2: cost=1399.00;
                         break;
                     }
                    }
                    break;
            case 3: int ch3;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Baby Soft Suckers                    Rs 79.00"<<endl;
                    cout<<"2. Swinging Beds                        Rs 2599.00"<<endl;
                    cin>>ch3;
                    if(ch3==1)
                       cost=79.00;
                    else if(ch3==2)
                       cost=2599.00;
                    break;
            default:cout<<"Wrong Choice!"<<endl;
                    cout<<"Please re-enter"<<endl;
        }

    }

    void offers()
    {  int ch;
        cout<<"Welcome to the Special Offers Section"<<endl;
    	cout<<"What would you like to buy"<<endl;
    	cout<<"1. Budget Watches "<<endl;
    	cout<<"2. Handpicked Headphones"<<endl;
    	cin>>ch;
        switch (ch)
        {
            case 1: int ch1;
                    cout<<"Please select a model: "<<endl;
                    cout<<"1. Men's Analog Black Dial watch        Rs 299.00"<<endl;
                    cout<<"2. Jelly Slim Black LED watch           Rs 95.00"<<endl;
                    cout<<"3. Semi-Transparent Couple Combo        Rs 1599.00"<<endl;
                    cin>>ch1;
                    if(ch1==1)
                       cost=299.00;
                    else if(ch1==2)
                       cost=95.00;
                    else if(ch1==3)
                       cost=1599.00;
                    else
                       cout<<"Wrong Choice!"<<endl;
                       cout<<"Please re-enter"<<endl;

            case 2: int ch2;
                    cout<<"Please select a category: "<<endl;
                    cout<<"1. Noise Cancellation Headphones"<<endl;
                    cout<<"2. Professional Audio"<<endl;
                    cin>>ch2;
                    if(ch2==1)
                       { int g1;
                        cout<<"Please select a model"<<endl;
                        cout<<"1. Tony wireless Hi-Res Audio       Rs 21990.00"<<endl;
                        cout<<"2. Dose QuietComfort for Android    Rs 25300.00"<<endl;
                        cin>>g1;
                        switch(g1)
                        { case 1: cost=21990.00;
                          break;
                          case 2: cost=25300.00;
                          break;
                          default:cout<<"Wrong Choice!"<<endl;
                                  cout<<"Please re-enter"<<endl;
                        }
                       }
                    else if(ch2==2)
                       { int b1;
                         cout<<"Please select a model"<<endl;
                         cout<<"1. Sannheiser Pro Studio Monitor    Rs 7999.00"<<endl;
                         cout<<"2. Audio-Tachnica Professional      Rs 15499.00"<<endl;
                         cin>>b1;
                          switch(b1)
                        { case 1: cost=7999.00;
                          break;
                          case 2: cost=15499.00;
                          break;
                          default:cout<<"Wrong Choice!"<<endl;
                                  cout<<"Please re-enter"<<endl;
                        }
                       }
              break;
             default:cout<<"Wrong Choice!"<<endl;
                     cout<<"Please re-enter"<<endl;

        }
    }

    void disp()
    {
    int choice;
     cout<<"What would you like to buy"<<endl;
     cout<<"1. Home Decor"<<endl;
     cout<<"2. Cosmetics"<<endl;
     cout<<"3. Electronics"<<endl;
     cout<<"4. Child Care"<<endl;
     cout<<"5. Sky Mall's Special Offers"<<endl;
     cin>>choice;
     switch(choice)
     {
      case 1:
       home_decor();
       break;
      case 2:
       cosmetics();
       break;
      case 3:
       electronics();
       break;
      case 4:
       childcare();
       break;
      case 5:
       offers();
       break;
      default:
       cout<<"Sorry this facility is not available currently."<<endl;
       cout<<"Please visit after a few days."<<endl;
       break;
      }
    bill();

    }

    void re()
    {
      char a;
      cout<<"\n\n\nDo you want to buy more(y/n)?"<<endl;
      cin>>a;
      if(a=='y'||a=='Y')
       disp();
      else if(a=='n'||a=='N')
        cout<<"DO VISIT AGAIN"<<endl;
      else
        cout<<"Thank you"<<endl;
    }
    int main()
    {
      cout<<"Welcome to Sky Megastore"<<endl;
      disp();
      re();
      return 0;
    }
