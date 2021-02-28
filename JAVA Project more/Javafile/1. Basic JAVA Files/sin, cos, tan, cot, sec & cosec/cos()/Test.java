import javax.swing.*;

public class Test {

   public static void main(String args[]) {

      double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Number to find value of Cosine: ", "Cosine", JOptionPane.PLAIN_MESSAGE));
      double y = Math.cos(Math.toRadians(x));

	  JOptionPane.showMessageDialog(null, "Answer is:  "+y, "Cosine", JOptionPane.PLAIN_MESSAGE);
   }
}