import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.applet.*;
import java.io.File;
import java.net.*;

class table extends JFrame implements ActionListener{
JFrame frm;
AudioClip a;
int status=0;
int h=0;
JLabel L1;
JButton b1,b2,b3,b4,b5,b6,b7,b8,b9,b10;
int g=2;
table()throws MalformedURLException, InterruptedException{

frm=new JFrame();
frm.setSize(800,500);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);

File A = new File("w0Hp0XU7wOO6.128.wav");
this.a = Applet.newAudioClip(A.toURL());


b1=new JButton("Single");
b1.setBounds(20,110,70,40);
frm.add(b1);

b2=new JButton("Double");
b2.setBounds(100,110,80,40);
frm.add(b2);

b3=new JButton("Three");
b3.setBounds(200,110,80,40);
frm.add(b3);

b4=new JButton("Four");
b4.setBounds(300,110,80,40);
frm.add(b4);



b5=new JButton("Five");
b5.setBounds(400,110,80,40);
frm.add(b5);

b6=new JButton("Six");
b6.setBounds(500,110,80,40);
frm.add(b6);

L1=new JLabel("0");
L1.setBounds(230,300,20000,200);
frm.add(L1);
b1.addActionListener(this);
b2.addActionListener(this);
b3.addActionListener(this);
b4.addActionListener(this);
b5.addActionListener(this);
b6.addActionListener(this);
frm.setVisible(true);

}

public void actionPerformed(ActionEvent e){

Object ob=e.getSource();

if(ob==b1){
int t=0;
status++;
t=h+status;
L1.setText(""+t);
}
if(ob==b2){
int t=0;
h+=2;
t=status+h;
L1.setText(""+t);
}

if(ob==b3){
int t=0;
h+=3;
t=status+h;
L1.setText(""+t);
}
if(ob==b4){
int t=0;
h+=4;
t=status+h;
L1.setText(""+t);
}

if(ob==b5){
int t=0;
h+=5;
t=status+h;
L1.setText(""+t);
}

if(ob==b6){
int t=0;
h+=6;
t=status+h;
L1.setText(""+t);
}

}
public static void main(String args[])throws MalformedURLException, InterruptedException{


table tb=new table();
}
}