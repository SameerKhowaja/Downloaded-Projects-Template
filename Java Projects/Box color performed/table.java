import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.event.*;
class table extends JFrame{

JFrame frm;
JComboBox box;
String[] colornames={"null","Red","Green","Sky-blue","Orange","Gray","White","Pink","Black","Yellow"};
Color[] color={null,Color.red,Color.green,Color.cyan,Color.orange,Color.gray,Color.white,Color.pink,Color.black,Color.yellow};
table(){


frm=new JFrame();
frm.setSize(500,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);

frm.setTitle("Color Box");



box=new JComboBox(colornames);
box.setBounds(140,100,80,30);
frm.add(box);
frm.setVisible(true);

box.addItemListener(
	
	
	new ItemListener(){
	
	
	public void itemStateChanged(ItemEvent e){
	
	if(e.getStateChange()==ItemEvent.SELECTED)
	{
	frm.getContentPane().setBackground(color[box.getSelectedIndex()]);
	}
	}
	
	}


);









}
public static void main(String args[]){


table tb=new table();

}
}