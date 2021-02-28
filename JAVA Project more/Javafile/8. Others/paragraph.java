import java.util.Scanner;

public class paragraph {
	public static void main(String[] args){
	Scanner sam = new Scanner(System.in);
	
	System.out.println("Enter your Name: ");
	String name = sam.nextLine();
	
	System.out.println("Enter your Age: ");
	String age = sam.nextLine();
	
	System.out.println("Enter your Favourite Colour: ");
	String colour = sam.nextLine();
	
	System.out.println("Enter your Class: ");
	String clas = sam.nextLine();
	
	System.out.println("Enter your School/College/University Name: ");
	String scu = sam.nextLine();
	
	System.out.println("Enter your Aim: ");
	String aim = sam.nextLine();
	
	System.out.println("Enter your Favourite Subject: ");
	String subject = sam.nextLine();
	
	System.out.println("Combining your Information into a Paragraph");
	System.out.println("");
	
	System.out.println("My name is " + name +". I am "+ age + "years old. My favorite colour is " + colour +". I am in " + clas +", studing in " + scu +". My dream is to be a good " + aim +". My favorite subject is " + subject + ". I love JAVA.");
	
	}
}
