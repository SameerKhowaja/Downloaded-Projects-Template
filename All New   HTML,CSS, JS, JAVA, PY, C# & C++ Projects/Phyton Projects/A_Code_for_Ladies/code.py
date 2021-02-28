def main():
    age = input("How old are you?\t");
    age = int(age);
    gender = input("<Girl> or <Boy>?\t");
    relationship = input("Are you <single>, <in_relationship> or <married>?\t")
    print();
    if gender == "Girl":
        if age >= 18 and age < 30:
            if relationship == "single":
                print("Have you got any plans for the weekend?");
            elif relationship == "in_relationship" or relationship == "married":
                print("He'll never know ;)");
            else:
                error();
        elif age < 18:
            if relationship == "married":
                print("You're pretty young for beeing married");
            elif relationship == "single":
                print("Well, I guess I know some nice guys in your age");
            elif relationship == "in_relationship":
                print("OK");
            else:
                error();
        else:
            print("I'm pretty sure I'm to young for you");
    elif gender == "Boy":
        print("Sorry, not interested :)");
    else:
        error();

def error():
    print("Something went wrong. Please check your entry");
    main();
main();