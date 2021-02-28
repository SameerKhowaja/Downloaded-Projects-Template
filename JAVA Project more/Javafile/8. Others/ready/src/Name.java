import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Name extends JFrame implements MouseListener{
    
    public JButton play, exit;
    public JLabel label;
	public JTextField name;
    JFrame frm;

    public Name(){
        frm = new JFrame();
        frm.setBounds(300, 50, 500, 500);
        frm.setDefaultCloseOperation(3);
        frm.setLayout(null);
        frm.setTitle("KBC Game...!");
        frm.getContentPane().setBackground(Color.BLACK);

        name = new JTextField();
        name.setBounds(100,100,350,45);
        name.setFont(new Font("Gill Sans", 6, 25));
        name.setBackground(Color.GREEN);
        name.setForeground(Color.BLACK);
        frm.add(name);
        
        play = new JButton("OK!");
        play.setBounds(100,200,130,45);
        play.setFont(new Font("Gill Sans", 7, 26));
        play.setBackground(Color.YELLOW);
        play.setForeground(Color.BLACK);
        frm.add(play);
        
        play.addMouseListener(this);
		frm.setVisible(true);
    }
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==play){  
            Play sam = new Play();
            sam.Letsplay();
            frm.setVisible(false);
        }
    }
    
    
    public static void main(String[] args) {
       Name k = new Name();
    }
    
}
