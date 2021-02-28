import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.io.*; 
import java.lang.Thread;

public class Name extends JFrame implements MouseListener, ActionListener{
    
    public JButton btnplay, about, exit;
    public JLabel  label2;
	public String str = "";
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
        
        btnplay = new JButton("OK!");
        btnplay.setBounds(100,200,130,45);
        btnplay.setFont(new Font("Gill Sans", 7, 26));
        btnplay.setBackground(Color.YELLOW);
        btnplay.setForeground(Color.BLACK);
        frm.add(btnplay);
        
		btnplay.addActionListener(this);
        btnplay.addMouseListener(this);
		frm.setVisible(true);
    }
    
    public void mousePressed(MouseEvent event){}
    public void mouseReleased(MouseEvent event){}
    public void mouseEntered(MouseEvent event){}
    public void mouseExited(MouseEvent event){}
    
	
	public void actionPerformed(ActionEvent e){
		Object ob=e.getSource();
		//str=name.getText();
			//JOptionPane.showMessageDialog(null, "InfoBox: " + str);
	//	Play sam = new Play();
     //       sam.Letsplay(str);
	 
	 if(ob==btnplay){ 
		str=name.getText();
			JOptionPane.showMessageDialog(null, "InfoBox: " + str);
			Thread thread1 = new Thread (){
				public void run () {
				for(int a=1; a<=4; a++){
			
				btnplay.setBackground(Color.green);
				try{
				Thread.sleep(2000);
				}catch(Exception exc){}
			if(a==1){
			Play sam = new Play();
            sam.Letsplay(str);
            frm.setVisible(false);
            //name.setVisible(true);
			}
				
				}
				}
			};
			thread1.start();
			
		}
		
	}
	
	
    //In Use
    public void mouseClicked(MouseEvent e) {
        Object ob = e.getSource();
      
    }
    
    
    public static void main(String[] args) {
       Name k = new Name();
    }
    
}
