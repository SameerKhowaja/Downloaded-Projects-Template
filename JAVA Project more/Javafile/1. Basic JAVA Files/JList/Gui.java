import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class Gui extends JFrame{
	private JList list;
	private JLabel title;
	private static String[] colornames = {"black", "blue", "red", "green", "light-blue","orange","gray","white","pink","yellow"};
	private static Color[] colors = {Color.BLACK, Color.BLUE, Color.RED, Color.GREEN, Color.CYAN, Color.ORANGE, Color.GRAY, 
										Color.WHITE, Color.PINK, Color.YELLOW};
	
	public Gui(){
		super("JList");
		setLayout(new FlowLayout());
		
		title = new JLabel("TEN NEW COLOURS IN JAVA: ");
		add(title);
		
		list = new JList(colornames);
		list.setVisibleRowCount(10);
		list.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
		add(new JScrollPane(list));
		
		list.addListSelectionListener(
			new ListSelectionListener(){
				public void valueChanged(ListSelectionEvent event){
					getContentPane().setBackground(colors[list.getSelectedIndex()]);
				}
			}
		);

	}
}