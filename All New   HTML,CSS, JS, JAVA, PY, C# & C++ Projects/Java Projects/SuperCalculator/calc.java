import java.util.Scanner;
import javax.swing.*;
public class calc {
	
	public static void main(String args[]){
	menu();
	}
	public static void menu() {
	System.out.println("CALCULATOR");
	System.out.println("(c) Rayyan Inc.");
	System.out.println("SORRY BUT YOU CANNOT USE IT ON SOLOLEARN CODE PLAYGROUND AS YOU WON'T BE ABLE TO USE IT");
	System.out.println("");
	System.out.println("");
	System.out.println("Menu");
	System.out.println("");
	launcher();
	
	}

	public static void help() {
		// TODO Auto-generated method stub
		System.out.println(" HELP ");
		System.out.println("------");
		System.out.println("");
		System.out.println("");
		
		System.out.println("-Type these commands after Enter Input");
		System.out.println("");
		System.out.println("IF YOU GET ANY 'ERROR', PLEASE RESTART THE PROGRAM");
		System.out.println("");
		System.out.println(" Commands ");
		System.out.println("");
		System.out.println("-Type 1 for help");
		System.out.println("-Type 2 for addition");
		System.out.println("-Type 3 for subtraction");
		System.out.println("-Type 4 for multiplication");
		System.out.println("-Type 5 for division");
		System.out.println("-Type 6 for square");
		System.out.println("-Type 7 for cube");
		System.out.println("-Type 8 for exponential calculations");
		System.out.println("-Type 9 for operations on decimals");
		System.out.println("-Type 10 to go to about");
		System.out.println("-Type 11 to try an older version of this calculator");
		System.out.println("-Type 12 to finding perimeter");
		System.out.println("-Type 13 to finding area");
		System.out.println("-Type 14 for return to home");
		System.out.println("");
		System.out.println("");
		System.out.println("Guide on using fractions");
		System.out.println("Enter fraction 1 numerator");
		System.out.println("Enter fraction 1 denominator");
		System.out.println("Enter fraction 2 numerator");
		System.out.println("Enter fraction 2 denominator");
		System.out.println("Specify the operation you want to do");
		System.out.println("");
		System.out.println("");
		System.out.println("Guide on using Power");
		System.out.println("X^Y");
		System.out.println("First enter x value");
		System.out.println("Then enter y value");
		System.out.println("");
		System.out.println("");
		launcher();
		
	}
	public static void square() {
		try{
		System.out.println("Enter number to be squared");
		Scanner s = new Scanner(System.in);
		double r = s.nextInt();
		double x = r * r; 
		System.out.println(x);
		
		launcher();
		}
		catch(Exception e){
			System.out.println("ERROR");
		}
	}
	public static void cube() {
		try{
		System.out.println("Enter number to be cubed");
		Scanner s = new Scanner(System.in);
		double r = s.nextInt();
		
		double result = r * r * r;
		System.out.println(result);
		launcher();
		}
		catch(Exception e){
			System.out.println("ERROR");
		}
	
	}
	public static void about(){
		try{
		System.out.println("This program is developed by Rayyan");
		System.out.println("CALCULATOR 1.0");
		System.out.println("(c)Rayyan Inc.");
		System.out.println("");
		System.out.println("Note:");
		System.out.println("Originally developed in Java, C++ version also available");
		System.out.println("For more information please visit ---");
		
		
		launcher();
		}
		catch(Exception e){
			System.out.println("ERROR");
		}
	}
   public static void launcher(){
	   try{
	   System.out.println("");
	   System.out.println("");
	    System.out.println("Enter Input");
	    Scanner s = new Scanner(System.in);
		System.out.println("Type 1 for help");
		int dee = s.nextInt();
		switch(dee){
		case 1:
			help();
		case 2:
			addition();
		case 3:
			subtraction();
		case 4:
			multiplication();
		case 5:
			division();
		case 6:
			square();
		case 7:
			cube();
		case 8:
			exponents();
		case 9:
			decimal();
		case 10:
			about();
		case 11:
			calc();
		case 12:
			perimeter();
		case 13:
			area();
		case 14:
			menu();
		}
		if(dee > 17){
			System.out.println("ERROR");
		}
		if(dee < 0){
			System.out.println("ERROR");
		}
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
		
   }


	

public static void area() {
	// TODO Auto-generated method stub
	try{
		Scanner s = new Scanner(System.in);
		System.out.println("Enter polygon code");
		System.out.println("1=Square");
		System.out.println("2=Rectangle");
		System.out.println("3=Circle");
		System.out.println("4=Triangle");
		double pi = 3.14;
		int input = s.nextInt();
		switch(input){
		case 1:
			System.out.println("Side =");
			int ui= s.nextInt();
			System.out.println("Area=");
			System.out.println(Math.pow(ui, 2));
		case 2:
			System.out.println("Length=");
			int l = s.nextInt();
			System.out.println("Breadth");
			int b = s.nextInt();
			System.out.println("Area=");
			System.out.println(l*b);
		case 3:
			System.out.println("Radius=");
			int r = s.nextInt();
			System.out.println("Area=");
			System.out.println(r * pi);
		case 4:
			System.out.println("Base=");
			int base=s.nextInt();
			System.out.println("Height=");
			int h=s.nextInt();
			int der=base * h;
			System.out.println("Area=");
			System.out.println(der/2);
		}
	launcher();
	}
	catch(Exception e){
		System.out.println("ERROR");
	}
}
public static void perimeter() {
	// TODO Auto-generated method stub
	try{
		Scanner s = new Scanner(System.in);
		System.out.println("Enter polygon code");
		System.out.println("1=Square");
		System.out.println("2=Rectangle");
		System.out.println("3=Circle");
		System.out.println("4=Triangle");
		double pi = 3.14;
		int input = s.nextInt();
		switch(input){
		case 1:
			System.out.println("Side =");
			int ui= s.nextInt();
			System.out.println("Perimeter=");
			System.out.println(ui * 4);
		case 2:
			System.out.println("Length=");
			int l = s.nextInt();
			System.out.println("Breadth");
			int b = s.nextInt();
			System.out.println("Perimeter=");
			System.out.println(2*(l+b));
		case 3:
			System.out.println("Radius=");
			int r = s.nextInt();
			System.out.println("Circumfernce=");
			System.out.println(2*pi*r);
		case 4:
			System.out.println("Side 1=");
			int si=s.nextInt();
			System.out.println("Side 2=");
			int sii=s.nextInt();
			System.out.println("Side 3=");
			int siii=s.nextInt();
			System.out.println("Perimeter=");
			System.out.println(si+sii+siii);
		}
	launcher();
	}
	catch(Exception e){
		System.out.println("ERROR");
	}
}

public static void decimal(){
	try{
	   Scanner userInputScanner = new Scanner(System.in);
	     // Testing nextLine();
	        System.out.print("\nEnter value #1 ");
	        double a = userInputScanner.nextInt();
	      
	 
	        // Testing nextLine();
	        System.out.print("\nEnter value #2  ");
	        double b = userInputScanner.nextInt();
	 
	        int e = 1;
	        int f = 2;
	        int g = 3;
	        int h = 4;
	        
	        // Testing nextInt();
	        System.out.print("Type a process(addition=1  subtracion=2  multiplication=3  division=4) ");
	        int d = userInputScanner.nextInt();
	        
	        System.out.println("Answer is =");
	        
	        if (d == e) {
	        System.out.println(a + b);
	     }
	     
	     if (d == f) {
	         System.out.println(a - b);
	      }  
	       
	     if (d == g) {
	         System.out.println(a * b);
	      }
	     
	     if (d == h) {
	         System.out.println(a / b);
	      }
	     launcher();
	}
	catch(Exception e){
		System.out.println("ERROR");
	}
   }
   public static void calc(){
	   try{
	   Scanner userInputScanner = new Scanner(System.in);
		
       
       System.out.println("Hi! I am DOX Calculator ");
       
    // Testing nextLine();
       System.out.print("\nEnter value #1 ");
       double a = userInputScanner.nextInt();
     

       // Testing nextLine();
       System.out.print("\nEnter value #2  ");
       double b = userInputScanner.nextInt();

       int e = 1;
       int f = 2;
       int g = 3;
       int h = 4;
       
       // Testing nextInt();
       System.out.print("Type a process(addition=1  subtracion=2  multiplication=3  division=4) ");
       int d = userInputScanner.nextInt();
       
       System.out.println("Answer is =");
       
       if (d == e) {
       System.out.println(a + b);
    }
    
    if (d == f) {
        System.out.println(a - b);
     }  
      
    if (d == g) {
        System.out.println(a * b);
     }
    
    if (d == h) {
        System.out.println(a / b);
     }
      launcher(); 
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
   }
   public static void addition(){
	   try{
	   Scanner userInputScanner = new Scanner(System.in);
	    // Testing nextLine();
	       System.out.print("\nEnter value #1 ");
	       double a = userInputScanner.nextInt();
	     

	       // Testing nextLine();
	       System.out.print("\nEnter value #2  ");
	       double b = userInputScanner.nextInt();
	       System.out.println(a + b);
	       launcher();
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
   }
   public static void subtraction(){
	   try{
	   Scanner userInputScanner = new Scanner(System.in);
	    // Testing nextLine();
	       System.out.print("\nEnter value #1 ");
	       double a = userInputScanner.nextInt();
	     

	       // Testing nextLine();
	       System.out.print("\nEnter value #2  ");
	       double b = userInputScanner.nextInt();
	       System.out.println(a - b);
	       launcher();
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
   }
   public static void multiplication(){
	   try{
	   Scanner userInputScanner = new Scanner(System.in);
	    // Testing nextLine();
	       System.out.print("\nEnter value #1 ");
	       double a = userInputScanner.nextInt();
        // Testing nextLine();
	       System.out.print("\nEnter value #2  ");
	       double b = userInputScanner.nextInt();
	       System.out.println(a * b);
	       launcher();
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
   }
   public static void division(){
	   try{
	   Scanner userInputScanner = new Scanner(System.in);
	    // Testing nextLine();
	       System.out.print("\nEnter value #1 ");
	       double a = userInputScanner.nextInt();
	       // Testing nextLine();
	       System.out.print("\nEnter value #2  ");
	       double b = userInputScanner.nextInt();
	       System.out.println(a / b);
	       launcher();
	   }
		catch(Exception e){
			System.out.println("ERROR");
		}
   }
   
public static void exponents() {
	// TODO Auto-generated method stub
	try{
	Scanner userInputScanner = new Scanner(System.in);
    // Testing nextLine();
       System.out.print("\nEnter value #1 ");
       double a = userInputScanner.nextInt();
       // Testing nextLine();
       System.out.print("\nEnter value #2  ");
       double b = userInputScanner.nextInt();
       System.out.println(Math.pow(a, b));
       launcher();
	}
	catch(Exception e){
		System.out.println("ERROR");
	}

}

}


