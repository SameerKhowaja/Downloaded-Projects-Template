import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Play extends JFrame  implements MouseListener{
    JFrame frm2;
	 public JLabel label;
	 public JButton btnplay;

 
    public void Letsplay(String str){
		
        frm2 = new JFrame();
        frm2.setBounds(200, 20, 500, 500);
        frm2.setDefaultCloseOperation(3);
        frm2.setLayout(null);
		frm2.getContentPane().setBackground(Color.BLACK);
        frm2.setTitle("KBC Game...!");

		
		//JOptionPane.showMessageDialog(null, "InfoBox: " + str);
        label = new JLabel("Welcome " + str);
        label.setBounds(100,20,350,45);
        label.setFont(new Font("Gill Sans", 15, 25));
        label.setForeground(Color.WHITE);
        frm2.add(label);
        
        btnplay = new JButton("Play!");
        btnplay.setBounds(100,100,339,44);
        btnplay.setFont(new Font("Gill Sans", 5, 25));
        btnplay.setBackground(Color.BLACK);
        btnplay.setForeground(Color.WHITE);
        frm2.add(btnplay);
        
        btnplay.addMouseListener(this);
		frm2.setVisible(true);
       
    }
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==btnplay){  
            System.exit(0);
            
        }
    }
}
