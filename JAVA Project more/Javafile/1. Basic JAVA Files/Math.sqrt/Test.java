import javax.swing.*;

public class Test{ 
	public static void main(String[] args){
	    double x = Double.parseDouble(JOptionPane.showInputDialog("Enter a Number: "));
		double y = Math.sqrt(x);
		
		JOptionPane.showMessageDialog(null, "Answer is:  "+y, "Square root", JOptionPane.PLAIN_MESSAGE);
	}
}