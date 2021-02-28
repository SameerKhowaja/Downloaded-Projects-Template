import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class graphics extends JPanel{
	public void paintComponent(Graphics g){
		super.paintComponent(g);
		this.setBackground(Color.WHITE);
		
		//For Line2D
		g.setColor(Color.BLUE);
		g.drawLine(10, 25, 200, 45);
		
		//Draw Rectangle without filling
		g.setColor(Color.RED);
		g.drawRect(10, 55, 100, 30);
		
		//Draw Oval 
		g.setColor(Color.GREEN);
		g.fillOval(10, 95, 100, 30);
		
		//For Rectangle2D-3D
		g.setColor(Color.ORANGE);
		g.fill3DRect(10, 135, 100, 50, true);
	}
}