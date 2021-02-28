import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import javax.swing.event.*;
class table extends JFrame{

JFrame frm;
JList list;
String[] colornames={"Red","Green","Sky-blue","Orange","Gray","White","Pink","Black","Yellow"};
Color[] color={Color.red,Color.green,Color.cyan,Color.orange,Color.gray,Color.white,Color.pink,Color.black,Color.yellow};
table(){


frm=new JFrame();
frm.setSize(500,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);

frm.setTitle("Color List");



list=new JList(colornames);
list.setBounds(140,100,60,160);
frm.add(list);
frm.setVisible(true);



list.addListSelectionListener(

new ListSelectionListener(){

public void valueChanged(ListSelectionEvent e){

frm.getContentPane().setBackground(color[list.getSelectedIndex()]);

}
}






);







}
public static void main(String args[]){


table tb=new table();

}
}