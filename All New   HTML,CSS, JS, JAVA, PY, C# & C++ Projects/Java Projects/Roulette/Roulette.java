import java.util.*;

public class Program
{
	public static void main(String[] args) {
	    System.out.println("Place your bet");
      Scanner in=new Scanner(System.in);
      int bet=in.nextInt();
      if(bet<=36)
      {
    	  Random num=new Random();
          int ch=num.nextInt(36)+1;
          if(bet==ch)
    	      System.out.println("you won $20");
          else
    	      System.out.println("you lost !!!" +ch);
      } 
      else
    	  System.out.println("enter valid number");
	}
		
	}
}