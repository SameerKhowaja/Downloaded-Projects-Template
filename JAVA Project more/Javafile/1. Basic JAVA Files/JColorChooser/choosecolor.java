import java.awt.*;
import java.awt.event.*;
import javax.swing.*;

public class choosecolor extends JFrame{
	private JButton b;
	private Color color = (Color.WHITE);
	private JPanel panel;
	
	public choosecolor(){
		super("JColorChooser");
		panel = new JPanel();
		panel.setBackground(color);
		
		b = new JButton("Choose a Color");
		b.addActionListener(
			new ActionListener(){
				public void actionPerformed(ActionEvent event){
					color = JColorChooser.showDialog(null, "Pick your Color", color);
					
					//If color is not choosed so what is default
					if(color==null)
						color=(Color.WHITE);
					
					panel.setBackground(color);
				}
			}
		);
		
		add(panel, BorderLayout.CENTER);
		add(b, BorderLayout.SOUTH);
		setSize(500, 300);
		setVisible(true);
	}
}