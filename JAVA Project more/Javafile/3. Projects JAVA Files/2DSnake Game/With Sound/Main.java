import javax.swing.JFrame;
import java.awt.Color;

public class Main {
    
    public static void main(String[] args) {
        JFrame obj = new JFrame();
        Gameplay gameplay = new Gameplay();
        
        obj.setTitle("JAVA GAME DEVELOPER (SAMEER KHOWAJA)");
        obj.setBounds(10, 10, 905, 700);
        obj.setBackground(Color.DARK_GRAY);
        obj.setResizable(false);
        obj.setLocationRelativeTo(null);
        obj.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        obj.add(gameplay);
        obj.setVisible(true);
    }
    
}
