import javax.swing.*;

//Radian ==> Degree 
public class Test { 
   public static void main(String args[]) {
	  double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Converting to Degree... \n Enter Number: ", "Radian ==> Degree", JOptionPane.PLAIN_MESSAGE));   

      JOptionPane.showMessageDialog(null, "Degree: " + Math.toDegrees(x) , "Radian ==> Degree", JOptionPane.PLAIN_MESSAGE);  
   }
}