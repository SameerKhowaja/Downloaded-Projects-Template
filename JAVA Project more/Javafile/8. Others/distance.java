// we are making distance formula: 
import java.util.Scanner;
Public Class distance {
	
	Public Static void(String[] args) {
		Scanner input = new Scanner(System.in);
		double ans1;	//Internal
		double ans2;	//External
		double x1,m2;	//x-axis
		double y1,y2;	//y-axis
		double m1,m2;	//midpoint
		
		/*
		There are two types of Divisions
		1. Internal Division
		2. External Division
		*/
		
		System.out.println("DISTANCE FORMULA");
		System.out.println("");
		
		double mid1 = m1 + m2;
		double mid2 = m1 - m2;
		
		// X
		double ans11 = m1 * x2;
		double ans12 = m2 * x1;
		
		double x = ans11 + ans12;
		
		// Y
		double ans13 = m1 *	y2;
		double ans14 = m2 * y1;
		
		double y = ans13 + ans14;
		
		
		//Entering Values...
		System.out.print("Value x1: ");
		x1 = input.nextDouble();
		
		System.out.print("Value x2: ");
		x2 = input.nextDouble();
		
		System.out.print("Value y1: ")
		y1 = input.nextDouble();
		
		System.out.print("Value y2: ")
		y2 = input.nextDouble();
		
		System.out.print("Value m1: ")
		m1 = input.nextDouble();
		
		System.out.print("Value m2: ")
		m2 = input.nextDouble();
		
		
		//Printing
		System.out.println("For Internal");
		System.out.println("Ans is: " + "(" + x/mid1 + ", " + y/mid + ")");
	}
}