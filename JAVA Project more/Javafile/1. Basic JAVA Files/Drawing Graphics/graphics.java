import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class graphics extends JPanel{
	public void paintComponent(Graphics g){
		super.paintComponent(g);
		this.setBackground(Color.WHITE);
		
		//For Red Text
		g.setColor(Color.RED);
		g.drawString("Drawing Rectange in JAVA", 25, 40);
	
		//For Blue Rectange
		g.setColor(Color.BLUE);
		g.fillRect(25, 65, 100, 30);
		
		g.setColor(Color.WHITE);
		g.drawString("BLUE", 45, 80);
		
		//For RGB(Purple) Rectange
		g.setColor(new Color(190, 81, 215));
		g.fillRect(25, 120, 100, 30);
		
		g.setColor(Color.WHITE);
		g.drawString("RGB(Purple)", 42, 135);
	}
}