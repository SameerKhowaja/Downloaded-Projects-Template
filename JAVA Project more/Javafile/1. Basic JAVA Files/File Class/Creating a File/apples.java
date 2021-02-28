import java.util.*;

class apples{
	public static void main(String[] args){
		final Formatter x;
		
		try{
			x = new Formatter("sam.txt");
			System.out.println("You created a file");
		}
		catch(Exception e){
			System.out.println("You got an Error");
		}
	}
}