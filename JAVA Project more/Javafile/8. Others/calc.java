import java.util.Scanner;

class calc {
  public static void main(String args[]) {
    Scanner sameer = new Scanner(System.in);
     
    double fnum, snum, aans, sans, dans, mans;
    	
    System.out.println("Enter your first number: ");
    fnum = sameer.nextDouble();
    System.out.println("Enter your second number: ");
    snum = sameer.nextDouble();
    
    /*
     aans  = Addition Answer
     sans  = Subtract Answer
     dans  = Divide Answer
     mans  = Multiply Answer
     */
    
    aans = fnum + snum;
    sans = fnum - snum;
    dans = fnum / snum;
    mans = fnum * snum;
    
    System.out.println(" ");
    System.out.println("Binary Operator Answers");
    System.out.println(" ");
    
    System.out.print("Addition operator: ");
    System.out.println(aans);
    
    System.out.print("Subtract operator: ");
    System.out.println(sans);
    
    System.out.print("divide operator: ");
    System.out.println(dans);

    System.out.print("Multiply operator: ");
    System.out.println(mans);
  }
} 

