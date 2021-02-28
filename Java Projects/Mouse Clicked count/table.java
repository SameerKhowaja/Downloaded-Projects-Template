import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class table extends JFrame{
String str;

JFrame frm;
JLabel L1,L2,L3;
JButton b1,b2,b3;
table(){


frm=new JFrame();
frm.setSize(300,200);


frm.setDefaultCloseOperation(3);

L1=new JLabel("this is a default");
frm.add(L1,BorderLayout.SOUTH);
frm.addMouseListener(new Mouseclass());







frm.setVisible(true);
}
private class Mouseclass extends MouseAdapter{

public void mouseClicked(MouseEvent e){

str=String.format("You clicked %d",e.getClickCount());


if(e.isMetaDown()){

str+=" With Write Mouse Button";



}
else if(e.isAltDown()){

str+="either center mouse button";


}
else{

str+=" with left mouse button";


}
L1.setText(str);
}


}
public static void main(String args[]){


table tb=new table();

}
}