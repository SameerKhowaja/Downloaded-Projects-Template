import java.awt.*;
import java.awt.event.*;
import javax.swing.*;
import javax.swing.event.*;

public class Gui extends JFrame{
	private JList leftlist;
	private JList rightlist;
	private JButton movebutton;
        private JLabel head;
	private static String[] fastfoods = {"Pizza", "Zinger Burger", "Chicken Tikkah", "BBQ", "Wings", "Handi", "Roll", "Chicken Lasagna", "Pasta", "Rice", "Biryani", "None of these"};
	
	public Gui(){
		super("Multiple List Select");
		setLayout(new FlowLayout());
                
		leftlist = new JList(fastfoods);
		leftlist.setVisibleRowCount(8);
		leftlist.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
		add(new JScrollPane(leftlist));
		
		movebutton = new JButton("Move ==>");
		movebutton.addActionListener(
				new ActionListener(){
					public void actionPerformed(ActionEvent event){
						rightlist.setListData(leftlist.getSelectedValues());
					}
				}
		);
		add(movebutton);
		
		rightlist = new JList();
		rightlist.setVisibleRowCount(8);
		rightlist.setFixedCellWidth(130);
		rightlist.setFixedCellHeight(20);
		rightlist.setSelectionMode(ListSelectionModel.MULTIPLE_INTERVAL_SELECTION);
		add(new JScrollPane(rightlist));
	}
}