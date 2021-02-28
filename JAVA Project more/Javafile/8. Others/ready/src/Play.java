import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Play extends Name{
    JFrame frm3;
    
    public void Letsplay(){
        frm3 = new JFrame();
        frm3.setBounds(250, 10, 0, 0);
        frm3.setDefaultCloseOperation(3);
        frm3.setLayout(null);
        frm3.setTitle("Congratulation...!");
        
        //bacgrd
        JPanel pan = new JPanel();
        JLabel jlb = new JLabel();
        jlb.setIcon(new ImageIcon(getClass().getResource("pak.jpg")));
     
        pan.add(jlb);

        frm3.setContentPane(jlb);
        frm3.setResizable(true);
        frm3.pack();
        frm3.setVisible(true);
        
        //more
		label = new JLabel("Welcome");
        label.setBounds(10,10,130,45);
        label.setFont(new Font("Gill Sans", 10 + Font.BOLD , 30));
        label.setForeground(Color.WHITE);
        frm3.add(label);
		
        exit = new JButton("Next!");
        exit.setBounds(100,200,130,45);
        exit.setFont(new Font("Gill Sans", 10 + Font.BOLD , 30));
        exit.setBackground(Color.MAGENTA);
        exit.setForeground(Color.WHITE);
        frm3.add(exit);
        
        frm3.setVisible(true);
        frm.setVisible(false);
        exit.addMouseListener(this);
    }
    
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
        
        if(ob==exit){
            Play1 pa = new Play1();
			pa.Letsplay1();
			frm3.setVisible(false);
    }
}
    
}

