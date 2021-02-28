import java.awt.*;
import javax.swing.*;

public class MainFile {
    
    public static void main(String args[]){
        DisplayMode displayMode = new DisplayMode(800, 600, 16, DisplayMode.REFRESH_RATE_UNKNOWN);
        MainFile mf = new MainFile();
        mf.run(displayMode);
    }
    
    private Screen screen;
    private Image bg;
    private Animation a;
    
    //load pic from computer to java and add scene
    public void loadPics(){
        bg = new ImageIcon("background.jpg").getImage();
        Image face1 = new ImageIcon("one.jpg").getImage();
        Image face2 = new ImageIcon("two.jpg").getImage();
        Image face3 = new ImageIcon("three.jpg").getImage();
        
        a = new Animation();
        a.addScene(face3, 250);
        a.addScene(face1, 250);
        a.addScene(face2, 250);
    }
    
    //main engine to run
    public void run(DisplayMode dm){
        screen = new Screen();
        
        try{
            screen.setFullScreen(dm, new JFrame());
            loadPics();
            movieLoop();
        }finally{
            screen.restoreScreen();
        }
    }
    
    //main MovieLoop();
    public void movieLoop(){
        long startingTime = System.currentTimeMillis();
        long cumTime = startingTime;
        
        while(cumTime - startingTime < 5000){
            long timePassed = System.currentTimeMillis() - cumTime;
            cumTime += timePassed;
            a.update(timePassed);
            
            Graphics g = screen.getFullScreenWindow().getGraphics();
            draw(g);
            g.dispose();
            
            try{
                Thread.sleep(20);
            }catch(Exception ex){}
        }
    }
    
    public void draw(Graphics g){
        g.drawImage(bg, 0, 0, null);
        g.drawImage(a.getImage(), 0, 0, null);
    }
}
