import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class Gui extends JFrame{
    private JPanel mousepanel;
    private JLabel statusbar;
    
    public Gui(){
        super("Mouse Events");
        
        mousepanel = new JPanel();
        mousepanel.setBackground(Color.WHITE);
        add(mousepanel, BorderLayout.CENTER);
        
        statusbar = new JLabel("Default");
        add(statusbar, BorderLayout.SOUTH);
        
        Handlerclass handler = new Handlerclass();
        mousepanel.addMouseListener(handler);
        mousepanel.addMouseMotionListener(handler);
    }
    private class Handlerclass implements MouseListener, MouseMotionListener{
       
        //These are Mouse Listener Events
        public void mouseClicked(MouseEvent event){
            statusbar.setText(String.format("Clicked at %d, %d", event.getX(), event.getY()));
        }
        public void mousePressed(MouseEvent event){
            statusbar.setText("You Pressed down the Mouse");
        }
        public void mouseReleased(MouseEvent event){
            statusbar.setText("You Released the Mouse");
        }
        public void mouseEntered(MouseEvent event){
            statusbar.setText("You Entered the area");
            mousepanel.setBackground(Color.RED);
        }
        public void mouseExited(MouseEvent event){
            statusbar.setText("The Mouse has left the Window");
            mousepanel.setBackground(Color.WHITE);
        }
        
        //These are Mouse Motion Listener Event
        public void mouseDragged(MouseEvent event){
            statusbar.setText("You are Dragging the Mouse");
        }
        public void mouseMoved(MouseEvent event){
            statusbar.setText("You Moved the Mouse");
        }
    }
}
