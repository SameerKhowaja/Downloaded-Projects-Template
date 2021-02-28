import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JFrame{

JFrame frm;
int x=0;
JButton b1,b2;

table(){
frm=new JFrame();
frm.setSize(500,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setTitle("Button Moving");
frm.setDefaultCloseOperation(3);





b1=new JButton("ON");
b1.setBounds(x,150,90,30);
frm.add(b1);

frm.setVisible(true);


try{
b1.setBounds(x,150,90,30);
x++;
Thread.sleep(20);
}catch(Exception e){}






}


public static void main(String args[]){

table tb=new table();
}
}
