import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JFrame implements ActionListener{
Timer tm=new Timer(1,this);
JButton b1=new JButton();
JButton b2=new JButton();
int x=0,y=2;
int x2=0,y2=2;
table(){
JFrame jf=new JFrame();

jf.setSize(500,500);


jf.setLayout(null);
jf.setDefaultCloseOperation(3);
jf.setLayout(null);
jf.setLocationRelativeTo(null);
jf.add(b1);
jf.add(b2);
jf.setVisible(true);




tm.start();

}

public void actionPerformed(ActionEvent e){

if(x<0 || x>165){

y=-y;
}
b1.setBounds(x,150,80,40);
b2.setBounds(405-x,150,80,40);
x=x+y;










}




public static void main(String []args){

table t=new table();





}
}