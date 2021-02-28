import java.awt.*;
import javax.swing.*;

public class Images extends JFrame {
    
    public static void main(String[] args) {
        DisplayMode dm = new DisplayMode(800, 600, 16, DisplayMode.REFRESH_RATE_UNKNOWN);
        Images i = new Images();
        i.run(dm);
    }
    
    private Screen s;
    private Image bg;
    private Image pics;
    private boolean loaded;
    
    //run method
    public void run(DisplayMode dm){
        getContentPane().setBackground(Color.BLACK);
        setForeground(Color.GREEN);
        setFont(new Font("Arial", Font.PLAIN, 24));
        loaded = false;
        
        s = new Screen();
        try{
            s.setFullScreen(dm, this);
            loadpics();
            try{
                Thread.sleep(5000);
            }catch(Exception ex){}
        }finally{
            s.restoreScreen();
        }
    }
    
    //loadpics method
    public void loadpics(){
        bg = new ImageIcon("background.jpg").getImage();
        loaded = true;
        repaint();
    }
    
    public void paint(Graphics g){
        super.paint(g);
        if(g instanceof Graphics2D){
            Graphics2D g2 = (Graphics2D)g;
            g2.setRenderingHint(RenderingHints.KEY_TEXT_ANTIALIASING, RenderingHints.VALUE_TEXT_ANTIALIAS_ON);
        }
        if(loaded){
            g.drawImage(bg, 0, 0, null);
        }
    }
    
}
