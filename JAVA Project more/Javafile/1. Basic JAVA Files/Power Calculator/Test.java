import javax.swing.*;

public class Test { 
   public static void main(String args[]) {
	
	//Co-efficient 
	double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Co-efficient: ", "Co-efficient", JOptionPane.PLAIN_MESSAGE));
     
	//Power
	double y = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Power: ", "Power", JOptionPane.PLAIN_MESSAGE));

    JOptionPane.showMessageDialog(null, "Your Answer is:  " + Math.pow(x, y), "Answer", JOptionPane.PLAIN_MESSAGE);
   }
}