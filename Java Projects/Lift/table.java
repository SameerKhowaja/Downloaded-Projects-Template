import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class table extends JFrame{
JFrame frm;
JLabel L0,L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,l1;

table(){

int style = 3;
    
    Font font1 = new Font("Gill Sans", style, 100);
	
    setBounds(0, 0, 818, 507);
	setDefaultCloseOperation(3);
	setLocationRelativeTo(null);
    setLayout(null);

	




L1=new JLabel("1");
L1.setBounds(200,120,1000,100);
L1.setFont(font1);
add(L1);

L2=new JLabel("2");
L2.setBounds(200,120,1000,100);
L2.setFont(font1);
add(L2);


L3=new JLabel("3");
L3.setBounds(200,120,1000,100);
L3.setFont(font1);
add(L3);

L4=new JLabel("4");
L4.setBounds(200,120,1000,100);
L4.setFont(font1);
add(L4);

L5=new JLabel("5");
L5.setBounds(200,120,1000,100);
L5.setFont(font1);
add(L5);

L6=new JLabel("6");
L6.setBounds(200,120,1000,100);
L6.setFont(font1);
add(L6);

L7=new JLabel("7");
L7.setBounds(200,120,1000,100);
L7.setFont(font1);
add(L7);

L8=new JLabel("8");
L8.setBounds(200,120,1000,100);
L8.setFont(font1);
add(L8);

L9=new JLabel("9");
L9.setBounds(200,120,1000,100);
L9.setFont(font1);
add(L9);

L10=new JLabel("10");
L10.setBounds(200,120,1000,100);
L10.setFont(font1);
add(L10);

L0=new JLabel("0");
L0.setBounds(200,120,1000,100);
L0.setFont(font1);
add(L0);
l1=new JLabel();
l1.setForeground(null);
    l1.setIcon(new ImageIcon("yellow.gif"));
    
    l1.setBounds(105, 60, 276, 247);
	l1.setFont(font1);
    add(l1);
L1.setVisible(false);
L2.setVisible(false);
L3.setVisible(false);
L4.setVisible(false);
L5.setVisible(false);
L6.setVisible(false);
L7.setVisible(false);
L8.setVisible(false);
L9.setVisible(false);
L10.setVisible(false);
L0.setVisible(false);

show();

for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}






for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}

for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}
for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.red);

}
}catch(Exception e){}


}





for(int a=1; a<=11; a++){


try{

Thread.sleep(1000);
if(a==1){
L0.setVisible(false);
L10.setVisible(true);

}
else if(a==2){
L10.setVisible(false);
L9.setVisible(true);
}
else if(a==3){
L9.setVisible(false);
L8.setVisible(true);

}
else if(a==4){
L8.setVisible(false);
L7.setVisible(true);

}
else if(a==5){
L7.setVisible(false);
L6.setVisible(true);

}
else if(a==6){
L6.setVisible(false);
L5.setVisible(true);

}
else if(a==7){
L5.setVisible(false);
L4.setVisible(true);

}
else if(a==8){
L4.setVisible(false);
L3.setVisible(true);

}
else if(a==9){
L3.setVisible(false);
L2.setVisible(true);

}
else if(a==10){
L2.setVisible(false);
L1.setVisible(true);

}
else if(a==11){
L1.setVisible(false);
L0.setVisible(true);

getContentPane().setBackground(Color.green);

}
}catch(Exception e){}


}




}
public static  void main(String args[]){


table tb=new table();
}
}