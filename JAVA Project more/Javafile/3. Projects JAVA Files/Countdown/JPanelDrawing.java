import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import static javax.swing.JFrame.EXIT_ON_CLOSE;

public class JPanelDrawing extends JFrame
{
	//inner Class
	public class MyJPanel extends JPanel
	{
	    public int x = 100;		//CountDown from 100	
	    public int delay = 1000; 	//milliseconds

	    MyJPanel()
	    {
		 ActionListener counter = new ActionListener() {
			public void actionPerformed(ActionEvent evt) 
			{ 
			      repaint();
			      x--;
			}};
		 new Timer(delay, counter).start();
	    }

	    public void paintComponent(Graphics g)
	    {
		super.paintComponent(g);
		g.drawString(""+x,20,20);
	    }
	
	}

	public static void main(String args [])
	{	      
	  new JPanelDrawing();		
	}

	JPanelDrawing()
	{
	    Container container = getContentPane();
	    MyJPanel panel = new MyJPanel();
	    container.add(panel);	  
	    
	    setDefaultCloseOperation(EXIT_ON_CLOSE);
	    setSize(150,80);
	    setTitle("JPanel Countdown");
	    setVisible(true);
	}
}