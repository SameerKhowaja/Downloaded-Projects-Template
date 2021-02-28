import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


class table extends JFrame implements ActionListener,MouseMotionListener{
JButton b1,b2,b3,b4,b5,b6,b7;
JLabel L1=new JLabel();
JFrame frm,frm2,frm3;
Font font1;
JTextField fi;
JPasswordField fp; 
JButton login,b11,b22,b33,b44,b55,b66,b77,b88,b99,b110,b111;
JLabel L11,L22,Lo;
JLabel label;
Thread t2,t3,t4;
table(){
int style=3;
    
    font1 = new Font("Gill Sans", style, 20);
	
    setSize(400,110);
	setDefaultCloseOperation(3);
	setLocationRelativeTo(null);
    setLayout(null);
	getContentPane().setBackground(new Color(124,223,96));
	//setVisible(true);
	
	label=new JLabel("Made By Shadab Ali khowaja");
	label.setBounds(50,30,300,30);
	label.setForeground(Color.red);
	label.setFont(font1);
	add(label);
frm=new JFrame();
frm.setSize(330,500);
frm.setLayout(null);
frm.setLocationRelativeTo(null);
frm.setDefaultCloseOperation(3);

JLabel LL11=new JLabel("Email            :       s");
LL11.setBounds(100,350,200,20);
frm.add(LL11);






JLabel LL12=new JLabel("Password    :       1");
LL12.setBounds(100,400,200,20);
frm.add(LL12);

fi=new JTextField();
fi.setBounds(60,70,230,20);
frm.add(fi);






L1.setIcon(new ImageIcon("green.png"));
L1.setBounds(98, 247, 18, 16);
frm.add(L1);


b1=new JButton();
b1.setBounds(100,250,10,10);
frm.add(b1);

b2=new JButton();
b2.setBounds(120,250,10,10);
frm.add(b2);

b3=new JButton();
b3.setBounds(140,250,10,10);
frm.add(b3);

b4=new JButton();
b4.setBounds(160,250,10,10);
frm.add(b4);


b5=new JButton();
b5.setBounds(180,250,10,10);
frm.add(b5);

b6=new JButton();
b6.setBounds(200,250,10,10);
frm.add(b6);





b1.setBackground(Color.green);
b2.setBackground(Color.green);
b3.setBackground(Color.green);
b4.setBackground(Color.green);
b5.setBackground(Color.green);
b6.setBackground(Color.green);
L1.setVisible(false);

b1.setVisible(false);
b2.setVisible(false);
b3.setVisible(false);
b4.setVisible(false);
b5.setVisible(false);
b6.setVisible(false);



Lo=new JLabel("Loading...");
Lo.setBounds(130,290,70,20);
frm.add(Lo);

Lo.setVisible(false);




L11=new JLabel("Email");
L11.setBounds(60,50,70,20);
frm.add(L11);

fp=new JPasswordField();
fp.setBounds(60,130,230,20);

 
               
frm.add(fp);


L22=new JLabel("Password");
L22.setBounds(60,110,70,20);
frm.add(L22);



login=new JButton("Login");
login.setBounds(120,190,70,20);

frm.add(login);

frm.setVisible(true);


frm2=new JFrame();
frm2.setSize(430,400);
frm2.setLayout(null);
frm2.setLocationRelativeTo(null);
frm2.setDefaultCloseOperation(3);

	b11=new JButton("Red");
   b11.setBounds(40,30,100,50);
   frm2.add(b11);
   b22=new JButton("Green");
   b22.setBounds(150,30,100,50);
   frm2.add(b22);
   
   b33=new JButton("Yellow");
    b33.setBounds(260,30,100,50);
   frm2.add(b33);
  
    b44=new JButton("Sky blue");
    b44.setBounds(40,100,100,50);
    frm2.add(b44);
   
    b55=new JButton("pink");
    b55.setBounds(150,100,100,50);
    frm2.add(b55);
   
   b66=new JButton("Orange");
    b66.setBounds(260,100,100,50);
    frm2.add(b66);
   
    b77=new JButton("White");
    b77.setBounds(40,170,100,50);
    frm2.add(b77);
   b88=new JButton("Black");
    b88.setBounds(150,170,100,50);
    frm2.add(b88);
   b99=new JButton("Gray");
    b99.setBounds(260,170,100,50);
    frm2.add(b99); 
   b110=new JButton("About");
    b110.setBounds(150,300,100,50);
    frm2.add(b110);







login.addActionListener(this);
b11.addMouseMotionListener(this);
b22.addMouseMotionListener(this);
b33.addMouseMotionListener(this);
b44.addMouseMotionListener(this);
b55.addMouseMotionListener(this);
b66.addMouseMotionListener(this);
b77.addMouseMotionListener(this);
b88.addMouseMotionListener(this);
b99.addMouseMotionListener(this);
b110.addMouseMotionListener(this);

label.setVisible(false);
frm2.setVisible(false);
frm.setResizable(false);
frm2.setResizable(false);
setResizable(false);
}



  
  public void actionPerformed(ActionEvent e){
  

Object ob=e.getSource();

if(ob==login){

if(fi.getText().equals("s") && fp.getText().equals("1")){
b1.setVisible(true);
b2.setVisible(true);
b3.setVisible(true);
b4.setVisible(true);
b5.setVisible(true);
b6.setVisible(true);
Lo.setVisible(true);
Thread thread1 = new Thread () {
  public void run () {
    
	
	for(int a=1; a<=16; a++){

try{

Thread.sleep(100);


if(a==6){

L1.setVisible(true);




}

else if(a==8){


L1.setBounds(118, 247, 18, 16);



}

else if(a==10){


L1.setBounds(138, 247, 18, 16);



}

else if(a==12){


L1.setBounds(158, 247, 18, 16);



}

else if(a==14){


L1.setBounds(178, 247, 18, 16);



}

else if(a==16){


L1.setBounds(198, 247, 18, 16);



}
}catch(Exception e){}

}



//222222222222222222222222222222222222222

for(int a=1; a<=12; a++){

try{

Thread.sleep(100);


if(a==2){

L1.setBounds(98, 247, 18, 16);




}

else if(a==4){


L1.setBounds(118, 247, 18, 16);



}

else if(a==6){


L1.setBounds(138, 247, 18, 16);



}

else if(a==8){


L1.setBounds(158, 247, 18, 16);



}

else if(a==10){


L1.setBounds(178, 247, 18, 16);



}

else if(a==12){


L1.setBounds(198, 247, 18, 16);



}
}catch(Exception e){}

}

//3333333333333333333333333333333333
for(int a=1; a<=12; a++){

try{

Thread.sleep(100);


if(a==2){

L1.setBounds(98, 247, 18, 16);




}

else if(a==4){


L1.setBounds(118, 247, 18, 16);



}

else if(a==6){


L1.setBounds(138, 247, 18, 16);



}

else if(a==8){


L1.setBounds(158, 247, 18, 16);



}

else if(a==10){


L1.setBounds(178, 247, 18, 16);



}

else if(a==12){


L1.setBounds(198, 247, 18, 16);

frm.setVisible(false);
frm2.setVisible(true);
}
}catch(Exception e){}

}

	
	
	
  }
};
thread1.start();

}


else{
JOptionPane.showMessageDialog(null,"Invalid");

}


}





}
  
  public void mouseDragged(MouseEvent e){}
  public void mouseMoved(MouseEvent e){

Object ob=e.getSource();




if(ob==b11){

frm2.getContentPane().setBackground(Color.red);
}

if(ob==b22){

frm2.getContentPane().setBackground(Color.green);
}

if(ob==b33){

frm2.getContentPane().setBackground(Color.yellow);
}
  if(ob==b44){

frm2.getContentPane().setBackground(Color.cyan);
}


if(ob==b55){

frm2.getContentPane().setBackground(Color.pink);
}


if(ob==b66){

frm2.getContentPane().setBackground(Color.orange);
}

if(ob==b77){

frm2.getContentPane().setBackground(Color.white);
}

if(ob==b88){

frm2.getContentPane().setBackground(Color.black);
}
if(ob==b99){

frm2.getContentPane().setBackground(Color.gray);
}


if(ob==b110){
frm2.setVisible(false);
setVisible(true);

t2=new Thread(){

public void run(){
for(int count=1; count<=340; count++){
try{

label.setBounds(400-count,30,300,30);
Thread.sleep(10);
}catch(Exception e){}



}
}

};

t4=new Thread(){

public void run(){
for(int count=1; count<=1; count++){
try{



Thread.sleep(1000);
if(count==1){
frm2.getContentPane().setBackground(null);
setVisible(false);
frm2.setVisible(true);

}
}catch(Exception e){}



}
}

};












t3=new Thread(){

public void run(){
for(int count=0; count<=340; count++){
try{

setBounds(count,30,400,110);

Thread.sleep(10);
if(count==340){
t4.start();
}
else if(count==0){
t2.start();
label.setVisible(true);
}
}catch(Exception e){}



}
}

};
t3.start();


}



}
  
  
  
  
  
  
  
public static void main(String args[]){


table t=new table();
}
}