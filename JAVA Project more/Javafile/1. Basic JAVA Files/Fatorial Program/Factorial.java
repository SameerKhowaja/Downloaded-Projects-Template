//Factorial Program...!
import javax.swing.*;

public class Factorial {
    public static void main(String[] args) {
        long n = Long.parseLong(JOptionPane.showInputDialog(null, "Don't use Factorial sign(!) \n Enter Number: ", "Factorial Program", JOptionPane.QUESTION_MESSAGE));
        
        if(n>59){
            JOptionPane.showMessageDialog(null, "Limit  of  59! \n -Use Number less than 60! \n\n\n Made By SAMEER KHOWAJA",  "Fatorial Program", JOptionPane.WARNING_MESSAGE);
            System.exit(0);
        }
        else{    
            JOptionPane.showMessageDialog(null, "Factorial  of  " + n + "!  is  ==>  " + fact(n) + "\n\n\n Made By SAMEER KHOWAJA",  "Fatorial Program", JOptionPane.INFORMATION_MESSAGE);   
            System.exit(0);
        }
    }
    
    public static long fact(long n){
        if(n<=1)
            return 1;
        else
            return n * fact(n-1);
    }
    
}
