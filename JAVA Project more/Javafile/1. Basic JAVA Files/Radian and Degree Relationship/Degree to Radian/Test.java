import javax.swing.*;

//Degree ==> Radian
public class Test { 
   public static void main(String args[]) {
	  double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Converting to Radian... \n Enter Number: ", "Degree ==> Radian", JOptionPane.PLAIN_MESSAGE));   

      JOptionPane.showMessageDialog(null, "Radian: " + Math.toRadians(x) , "Degree ==> Radian", JOptionPane.PLAIN_MESSAGE);  
   }
}