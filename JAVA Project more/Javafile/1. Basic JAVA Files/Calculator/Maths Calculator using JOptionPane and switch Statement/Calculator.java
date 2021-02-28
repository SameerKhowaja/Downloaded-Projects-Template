import javax.swing.*;

public class Calculator {
    public static void main(String[] args) {
        double a;
        double b;
        String opr;
  
        
        //For var a
        a = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter First Number: ", "First Number", JOptionPane.QUESTION_MESSAGE));
        
        if(a<-2147483648 || a>2147483647){
            JOptionPane.showMessageDialog(null, "Error: It has a minimum value of -2,147,483,648 and a maximum value of 2,147,483,647",  "ERROR", JOptionPane.WARNING_MESSAGE);   
            System.exit(0);
        }
        
        
        //For var b
        b = Double.parseDouble(JOptionPane.showInputDialog(null, "Enter Second Number: ", "Second Number", JOptionPane.QUESTION_MESSAGE));
        if(b<-2147483648 || b>2147483647){
            JOptionPane.showMessageDialog(null, "Error: It has a minimum value of -2,147,483,648 and a maximum value of 2,147,483,647",  "ERROR", JOptionPane.WARNING_MESSAGE);   
            System.exit(0);
        }
        
        
        //For Operators
        opr = JOptionPane.showInputDialog(null, "Maths Operators for DMAS Rule Only:  ", "Maths Operators i.e: / * + -", JOptionPane.QUESTION_MESSAGE);
        switch (opr){
            case "/":
                JOptionPane.showMessageDialog(null, "Answer ==>  " + (a/b) ,  "Division", JOptionPane.INFORMATION_MESSAGE);
                break;
            case "*":
                JOptionPane.showMessageDialog(null, "Answer ==>  " + (a*b) ,  "Multiplication", JOptionPane.INFORMATION_MESSAGE);
                break;
            case "+":
                JOptionPane.showMessageDialog(null, "Answer ==>  " + (a+b) ,  "Addition", JOptionPane.INFORMATION_MESSAGE);
                break;
            case "-":
                JOptionPane.showMessageDialog(null, "Answer ==>  " + (a-b) ,  "Subtraction", JOptionPane.INFORMATION_MESSAGE);
                break;
            case "^":
                JOptionPane.showMessageDialog(null, "Answer ==>  " + Math.pow(a,b) ,  "Power", JOptionPane.INFORMATION_MESSAGE);
                break;
            default:
                JOptionPane.showMessageDialog(null, "Error: Use these DMAS & POWER Operators only \n i.e: \n /  = Division \n *  = Multiplication \n +  = Addition \n -  = Subtraction \n ^ =  Power", "ERROR", JOptionPane.WARNING_MESSAGE);   
                System.exit(0);
                break;
        } 
        
    }
}