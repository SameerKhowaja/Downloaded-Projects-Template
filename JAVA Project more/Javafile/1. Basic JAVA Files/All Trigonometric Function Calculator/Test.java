import javax.swing.*;

public class Test {

   public static void main(String args[]) {

      double x = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter any Number to Find The Value of All Trigonometric Function: ", "Trigonometric Function Calculator in Radians", JOptionPane.PLAIN_MESSAGE));
      
	  //Assigning Trigonometric Values to Variables Respectively... 
	  double sine 		= Math.sin(Math.toRadians(x));
	  double cosine 	= Math.cos(Math.toRadians(x));
	  double tangent 	= Math.tan(Math.toRadians(x));
	  double cot	 	= 1 / Math.tan(Math.toRadians(x));
	  double sec 		= 1 / Math.cos(Math.toRadians(x));
	  double cosec 		= 1 / Math.sin(Math.toRadians(x));

	  JOptionPane.showMessageDialog(null, "The values of " + x + " are : \n \n Sine ==> " + sine + "\n Cosine ==> " + cosine + "\n Tangent ==> " + tangent + "\n Cot ==> " + cot + "\n Sec ==> " + sec + "\n Cosec ==> " + cosec , "Trigonometric Function Calculator in Radians", JOptionPane.PLAIN_MESSAGE);
   }
}