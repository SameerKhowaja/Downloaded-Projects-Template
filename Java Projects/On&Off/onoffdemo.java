import java.awt.event.*;
import java.awt.*;
import javax.swing.*;

class onoffdemo extends JFrame{
JFrame frm;
JLabel b1,b2,b3,b4,b5,b6,g1,g2,g3,g4,g5,g6,blue,gray,demo,demo2,onoff;
int status=0;
onoffdemo(){

frm=new JFrame();
frm.setSize(300,100);
frm.setLocationRelativeTo(null);
frm.setLayout(null);
frm.setDefaultCloseOperation(3);
frm.setTitle("ON/OFF");
frm.setResizable(false);


onoff=new JLabel("Off");
onoff.setBounds(120,50,1000,20);
frm.add(onoff);

demo=new JLabel();
demo.setIcon(new ImageIcon("demo.png"));
demo.setBounds(100,20,13,25);
frm.add(demo);


g2=new JLabel();
g2.setIcon(new ImageIcon("1.png"));
g2.setBounds(105,24,13,17);
frm.add(g2);

g3=new JLabel();
g3.setIcon(new ImageIcon("2.png"));
g3.setBounds(118,24,13,17);
frm.add(g3);

g4=new JLabel();
g4.setIcon(new ImageIcon("3.png"));
g4.setBounds(131,24,13,17);
frm.add(g4);

g5=new JLabel();
g5.setIcon(new ImageIcon("4.png"));
g5.setBounds(144,24,13,17);
frm.add(g5);

g1=new JLabel();
g1.setIcon(new ImageIcon("5.png"));
g1.setBounds(148,24,13,17);
frm.add(g1);

gray=new JLabel();
gray.setIcon(new ImageIcon("gray2.png"));
gray.setBounds(100,20,66,25);
frm.add(gray);


// demo.setVisible(false);
g2.setVisible(false);
g3.setVisible(false);
g4.setVisible(false);
g5.setVisible(false);
g1.setVisible(false);
frm.setVisible(true);


gray.addMouseListener(new MouseAdapter(){





public void mouseClicked(MouseEvent e){


int count=e.getClickCount();

if(count==1){


if(status==0){
status=1;
onoff.setText("On");
gray.setFocusable(false);

Thread t1=new Thread(){

public void run(){
for(int a=1; a<=52; a++){
try{
demo.setBounds(100+a,20,13,25);
Thread.sleep(3);
if(a==52){
gray.setFocusable(true);

}
if(a==4){
g2.setVisible(true);
}

if(a==17){
g3.setVisible(true);
}
if(a==30){
g4.setVisible(true);
}
if(a==43){
g5.setVisible(true);
}
}catch(Exception e){}
}

}


};
t1.start();
}
///////////////////////////////elese if

else if(status==1){
status=0;
onoff.setText("Off");
gray.setFocusable(false);

Thread t2=new Thread(){

public void run(){
for(int a=1; a<=52; a++){
try{
demo.setBounds(152-a,20,13,25);
Thread.sleep(3);
if(a==52){
gray.setFocusable(true);

}
if(a==43){
g2.setVisible(false);
}

if(a==30){
g3.setVisible(false);
}
if(a==17){
g4.setVisible(false);
}
if(a==4){
g5.setVisible(false);
}
}catch(Exception e){}
}

}


};
t2.start();

}

////////////////////////////////////////wwwwwwwe
}


}


});
}

public static void main(String args[]){

onoffdemo on=new onoffdemo();

}
}