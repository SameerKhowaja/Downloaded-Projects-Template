import javax.swing.*;

public class table { 
   public static void main(String args[]) {
        int number;
        int product;
       
	//Enter require number
        number = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter Number: ", "Enter Value to Find the Table", JOptionPane.QUESTION_MESSAGE));

    JOptionPane.showMessageDialog(null, "Table of " + number + " is: \n\n" + 
            
            number + " x 1 = " + number * 1 + "\n" + 
            number + " x 2 = " + number * 2 + "\n" +
            number + " x 3 = " + number * 3 + "\n" +
            number + " x 4 = " + number * 4 + "\n" +
            number + " x 5 = " + number * 5 + "\n" +
            number + " x 6 = " + number * 6 + "\n" +
            number + " x 7 = " + number * 7 + "\n" +
            number + " x 8 = " + number * 8 + "\n" +
            number + " x 9 = " + number * 9 + "\n" +
            number + " x 10 = " + number * 10 + "\n"
            
            , "MATHS TABLE", JOptionPane.INFORMATION_MESSAGE);
   }
}