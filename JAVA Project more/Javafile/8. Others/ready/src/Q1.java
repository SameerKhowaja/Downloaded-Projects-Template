import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Play1 extends Name{
    JFrame frm3;
    public void Letsplay1(){
		frm3=new JFrame();
        frm3.setBounds(300, 50, 500, 500);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("KBC Game...! (Question No:10)");
        frm3.getContentPane().setBackground(Color.WHITE);
      
        play = new JButton("OK!");
        play.setBounds(100,200,130,45);
        play.setFont(new Font("Gill Sans", 7, 26));
        play.setBackground(Color.YELLOW);
        play.setForeground(Color.BLACK);
        frm3.add(play);
		
        frm3.setVisible(true);
        frm.setVisible(false);
        play.addMouseListener(this);
    }
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==play){  
            System.exit(0);
            
        }
    }
}
