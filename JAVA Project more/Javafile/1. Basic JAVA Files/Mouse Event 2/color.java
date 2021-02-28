import java.awt.*;
import javax.swing.*;
import java.awt.event.*;

public class color extends JFrame implements MouseListener{
	public JButton button;
	public static void main(String args[]){
		new color();
	}

	color(){
		button = new JButton("No Mouse Event Captured");
		button.setOpaque(true);
		button.addMouseListener(this);
		add(button);

		setSize(300, 250);
		setTitle("JButton Color On Press");
		setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		setVisible(true);
	}
	//Overridden Methods from MouseListener Interface
	//These methods are called automatically when corresponding mouse
	//event occurs 
	/////////////////////////////////////////////////
	public void mouseEntered(MouseEvent e){
	    button.setText("Mouse Entered");
	    button.setBackground(Color.CYAN);
	}
	
	public void mouseExited(MouseEvent e){
	    button.setText("Mouse Exited");	    
	    button.setBackground(Color.WHITE);	    
	}	
	public void mouseClicked(MouseEvent e){
		
	}
	public void mousePressed(MouseEvent e){
		
	}	
	public void mouseReleased(MouseEvent e){
		
	}
}