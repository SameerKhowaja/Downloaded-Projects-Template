import javax.swing.*;

public class Test {

   public static void main(String args[]) {

      double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Number to find value of Cosec: ", "Cosec", JOptionPane.PLAIN_MESSAGE));
      double y = Math.sin(Math.toRadians(x));
	  double z = 1 / y;

	  JOptionPane.showMessageDialog(null, "Answer is:  "+z, "Cosec", JOptionPane.PLAIN_MESSAGE);
   }
}