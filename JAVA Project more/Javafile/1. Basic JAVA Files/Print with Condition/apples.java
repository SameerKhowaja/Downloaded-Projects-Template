import javax.swing.*;

public class apples {
    public static void main(String[] args) {
        int number1;
        int number2;
        
        number1 = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter First Number: ", "Printing From", JOptionPane.QUESTION_MESSAGE));
        number2 = Integer.parseInt(JOptionPane.showInputDialog(null, "Enter Second Number: ", "Printing To", JOptionPane.QUESTION_MESSAGE));
    
        for(int i = number1; i<=number2; i++){
            //JOptionPane.showMessageDialog(null, i, "Printing Numbers", JOptionPane.INFORMATION_MESSAGE);
            System.out.println(i);
        }
    }
    
}
