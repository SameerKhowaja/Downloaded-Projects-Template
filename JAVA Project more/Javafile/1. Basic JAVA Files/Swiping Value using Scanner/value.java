import java.util.Scanner;

public class value{
	public static void main(String[] args){
		
		Scanner sam = new Scanner(System.in);
		
		int a;
		int b;
		int c;
		
		System.out.print("Enter value A :");
		a = sam.nextInt();
		
		System.out.print("Enter value B :");
		b = sam.nextInt();
		
		System.out.println("");
		
		c = a;
		
		a = b;		//a = 8
		System.out.println("A ==> " + a);
		
		b = c;		//b = 4
		System.out.println("B ==> " + b);
	}
}