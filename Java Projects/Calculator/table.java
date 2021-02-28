import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class table extends JFrame implements MouseMotionListener{


JTextField first,second,third;
JLabel L1,L2,L3,L4,L5,L6,L7;
JButton b1,b2,b3,b4;
JFrame frm;
JFrame frm2;
table(){

int style=3;
    
  
	frm=new JFrame();
    frm.setBounds(280, 20, 500, 800);
	frm.setDefaultCloseOperation(3);
    frm.setLayout(null);
	frm.setTitle("CALCULATOR");
	frm.getContentPane().setBackground(Color.cyan);
	
L1=new JLabel("First Number  :");
L1.setBounds(100,20,180,20);
L1.setFont(new Font("Gill Sans", style, 20));
frm.add(L1);

first=new JTextField();
first.setBounds(120,50,230,30);
first.setFont(new Font("Gill Sans", style, 20));

frm.add(first);




L2=new JLabel("Second Number  :");
L2.setBounds(100,120,1100,20);
L2.setFont(new Font("Gill Sans", style, 20));
frm.add(L2);



second=new JTextField();
second.setBounds(120,150,230,30);
second.setFont(new Font("Gill Sans", style, 20));
frm.add(second);






L3=new JLabel("Operator  :");
L3.setBounds(100,220,1100,20);
L3.setFont(new Font("Gill Sans", style, 20));
frm.add(L3);


third=new JTextField();
third.setBounds(120,250,230,30);
frm.add(third);


L4=new JLabel("The Answer is  : ");
L4.setBounds(160,320,1000,20);
L4.setFont(new Font("Gill Sans", style, 20));
frm.add(L4);


L5=new JLabel("Your Mouse Move Button And See Answer");
L5.setBounds(40,370,1000,20);
L5.setFont(new Font("Gill Sans", style, 20));
add(L5);
b1=new JButton("Result");
b1.setBounds(160,410,130,50);
b1.setFont(new Font("Gill Sans", style, 20));
frm.add(b1);

b2=new JButton("Clear");
b2.setBounds(160,500,130,50);
b2.setFont(new Font("Gill Sans", style, 20));
frm.add(b2);

b3=new JButton("About");
b3.setBounds(160,590,130,50);
b3.setFont(new Font("Gill Sans", style, 20));
frm.add(b3);

b4=new JButton("Exit");
b4.setBounds(160,680,130,50);
b4.setFont(new Font("Gill Sans", style, 20));
frm.add(b4);
frm.setVisible(true);
b1.addMouseMotionListener(this);
b2.addMouseMotionListener(this);
b3.addMouseMotionListener(this);
b4.addMouseMotionListener(this);

first.setBackground(Color.yellow);

second.setBackground(Color.yellow);

third.setBackground(Color.yellow);



L1.setForeground(Color.red);

L2.setForeground(Color.red);

L3.setForeground(Color.red);

L4.setForeground(Color.red);

L5.setForeground(Color.red);


b1.setBackground(Color.green);
b2.setBackground(Color.green);
b3.setBackground(Color.green);
b4.setBackground(Color.green);


}



public void mouseDragged(MouseEvent e)
  {}
    public void mouseMoved(MouseEvent e) {



Object ob=e.getSource();
if(ob==b1){
if(third.getText().equals("+")){
int a=Integer.parseInt(first.getText());

int b=Integer.parseInt(second.getText());

L4.setText("The Answer is  :  "+(a+b));

}

if(third.getText().equals("-")){

int c=Integer.parseInt(first.getText());

int d=Integer.parseInt(second.getText());
L4.setText("The Answer is  :  "+(c-d));

}
if(third.getText().equals("*")){

int ee=Integer.parseInt(first.getText());

int f=Integer.parseInt(second.getText());
L4.setText("The Answer is  :  "+(ee*f));

}

if(third.getText().equals("/")){

int g=Integer.parseInt(first.getText());

int h=Integer.parseInt(second.getText());
L4.setText("The Answer is  :  "+(g/h));

}

if(third.getText().equals("%")){
int k=Integer.parseInt(first.getText());

int i=Integer.parseInt(second.getText());

L4.setText("The Answer is  :  "+(k%i));

}



}

if(ob==b3)
{
JOptionPane.showMessageDialog(null,"Made By Sameer Khowaja");

}


if(ob==b2)
{
first.setText("");
second.setText("");
third.setText("");
L4.setText("The Answer is  : ");
first.requestFocus();
}
if(ob==b4)
{
System.exit(0);
}
	
	}
public static void main(String args[]){

table tb=new table();

}
}