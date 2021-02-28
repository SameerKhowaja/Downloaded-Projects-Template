import java.util.Scanner;
import java.util.concurrent.TimeUnit;

public class KisaTheMedium {

    static Scanner in = new Scanner(System.in);
    static String message;
    static int max=1001;
    static int min=0;
    static boolean lieDetector = false;
    static boolean over = false;
    static final String equal = "=";

    public static void main(String[] args){

        System.out.println("Hello, I am Kisa.");
        wait(1);
        System.out.println("We are going to play a game!");
        wait(2);
        System.out.println("You will think of a number and I will try to guess it by asking a few questions.\n");
        wait(2);
        System.out.println("Now hold on, not just any number! It has to be between 1 and 1000");
        System.out.println("including those. And don't even try to play any tricks on me! ONLY INTEGERS!\n");
        wait(6);
        System.out.println("Press ENTER when you are ready.");
        System.out.print("Shall we begin? ");

        message = in.nextLine();

        int i=1;
        while (!over || !lieDetector){

            if (lieDetector){
                System.out.println("Hey! You lied to me! How could you...");
                break;
            }
            else if (over) {
                System.out.println("Ha! I found it! Your number is "+(max+min)/2);
                break;
            }

            System.out.println("\n-------------------------------------------------------------");
            System.out.println("\nQuestion "+i+": ");
            System.out.println("Is your number greater than "+(max+min)/2+", less or equal?");
            if (i==1) System.out.println("You can use '>', '<' and '=' to answer.");
            i++;

            KisasMagic();
        }
        System.out.print("Thanks for playing!");
        wait(5);
    }

    public static void wait(int x){
        try{
            TimeUnit.SECONDS.sleep(x);
        }catch (Exception e){
            System.out.println("Oops, I crashed");
        }
    }

    public static void KisasMagic(){

        System.out.print("Input here: ");
        message = in.nextLine();

        if ((max+min)/2==1000 && !message.equals(equal)) lieDetector=true;
        if ((max+min)/2==1 && !message.equals(equal)) lieDetector=true;
        if (max-min==1 && !message.equals(equal)) lieDetector=true;

        switch (message){
            case "<" : max = (max+min)/2;
                break;
            case ">" : min = (max+min)/2;
                break;
            case "=" : over = true;
                break;
            default: System.out.println("Please check your input, something is amiss and my brain almost crashed.");
        }
    }
}