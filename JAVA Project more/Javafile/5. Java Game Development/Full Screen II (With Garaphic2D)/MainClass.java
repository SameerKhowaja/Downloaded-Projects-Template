import java.awt.*;
import javax.swing.*;

public class MainClass extends JFrame {
    
    public static void main(String[] args) {
        DisplayMode dm = new DisplayMode(800, 600, 16, DisplayMode.REFRESH_RATE_UNKNOWN);
        MainClass mc = new MainClass();
        mc.run(dm);
    }
    
    public void run(DisplayMode dm){
        getContentPane().setBackground(Color.BLACK);
        setForeground(Color.GREEN);
        setFont(new Font("Arial", Font.PLAIN, 24));
        
        Screen s = new Screen();
        try{
            s.setFullScreen(dm, this);
            try{
                Thread.sleep(5000);
            }catch(Exception ex){}
        }finally{
            s.restoreScreen();
        }
    }
    
    public void paint(Graphics g){
        if(g instanceof Graphics2D){
            Graphics2D g2 = (Graphics2D)g;
            g2.setRenderingHint(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
        }
        
        super.paint(g);
        g.drawString(" I am Sameer Khowaja Virus of Computer :)", 400, 200);
        g.drawString(" Please Wait...! Crashing you hard disk ", 400, 250);
        g.drawString(" Please Wait...! Hacking your system...!", 400, 300);
        g.drawString(" In 59 sec, Virus will be all over your system", 400, 350);
        g.drawString(" Making your System unusable..............", 400, 400);
    }
    
}
