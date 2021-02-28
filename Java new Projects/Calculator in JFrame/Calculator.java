import javax.swing.JFrame;

public class Calculator {
    public static void main(String[] args) {
        CalculatorGUI window = new CalculatorGUI("Basic Calculator");
        window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        window.setSize(300, 400);
        window.setFocusable(true);
        window.setVisible(true);
    }
}