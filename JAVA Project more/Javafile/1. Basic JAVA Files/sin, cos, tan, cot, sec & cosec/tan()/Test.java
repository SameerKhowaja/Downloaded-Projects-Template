import javax.swing.*;

public class Test {

   public static void main(String args[]) {

      double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Number to find value of Tangent: ", "Tangent", JOptionPane.PLAIN_MESSAGE));
      double y = Math.tan(Math.toRadians(x));

	  JOptionPane.showMessageDialog(null, "Answer is:  "+y, "Tangent", JOptionPane.PLAIN_MESSAGE);
   }
}