import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.net.*;


class table extends JFrame implements MouseMotionListener{

JFrame frm;
JTextField field;
JButton b1,b2,b3,b4,b5;
JLabel L1,L2,L3,L4,L5,L6,L7,L8,L9,L10,L11,L12,L13,L14,L15,L16,L17,L18,L19,L20;


table(){


int style=3;
Font font1 = new Font("Gill Sans", style, 20);
setSize(600,700);
setLocationRelativeTo(null);
setLayout(null);
setDefaultCloseOperation(3);
setTitle("Table Print");
getContentPane().setBackground(Color.cyan);

b1=new JButton("SHOW");
b1.setBounds(230,140,100,60);
b1.setFont(font1);
b1.setToolTipText("Move the Show button And print table");
add(b1);


field=new JTextField();
field.setBounds(160,80,260,30);
field.setFont(font1);
add(field);





L1=new JLabel();
L1.setBounds(160,220,700,30);
L1.setFont(font1);
add(L1);

L2=new JLabel();
L2.setBounds(160,250,700,20);
L2.setFont(font1);
add(L2);

L3=new JLabel();
L3.setBounds(160,280,700,20);
L3.setFont(font1);
add(L3);

L4=new JLabel();
L4.setBounds(160,310,700,20);
L4.setFont(font1);
add(L4);

L5=new JLabel();
L5.setBounds(160,340,700,20);
L5.setFont(font1);
add(L5);


L6=new JLabel();
L6.setBounds(160,370,700,20);
L6.setFont(font1);
add(L6);

L7=new JLabel();
L7.setBounds(160,400,700,20);
L7.setFont(font1);
add(L7);

L8=new JLabel();
L8.setBounds(160,430,700,20);
L8.setFont(font1);
add(L8);

L9=new JLabel();
L9.setBounds(160,460,700,20);
L9.setFont(font1);
add(L9);

L10=new JLabel();
L10.setBounds(160,490,700,20);
L10.setFont(font1);
add(L10);





L11=new JLabel("Your Choice Any Number You Want table print");
L11.setBounds(110,40,700,20);
L11.setFont(font1);
add(L11);

L12=new JLabel("Your  Mouse  Move  Button   And  See  Answer");
L12.setBounds(110,10,700,20);
L12.setFont(font1);
add(L12);

b2=new JButton("About");
b2.setBounds(100,560,100,60);
b2.setFont(font1);

add(b2);

b3=new JButton("Clear");
b3.setBounds(230,560,100,60);
b3.setFont(font1);
b3.setToolTipText("Clear the table");
add(b3);

b4=new JButton("Exit");
b4.setBounds(360,560,100,60);
b4.setFont(font1);

add(b4);
setVisible(true);



L11.setForeground(Color.red);
L12.setForeground(Color.red);

b1.setBackground(Color.green);
b2.setBackground(Color.green);
b3.setBackground(Color.green);
b4.setBackground(Color.green);
field.setBackground(Color.yellow);

L1.setForeground(new Color(192,89,39));
L2.setForeground(new Color(192,89,39));
L3.setForeground(new Color(192,89,39));
L4.setForeground(new Color(192,89,39));
L5.setForeground(new Color(192,89,39));
L6.setForeground(new Color(192,89,39));
L7.setForeground(new Color(192,89,39));
L8.setForeground(new Color(192,89,39));
L9.setForeground(new Color(192,89,39));
L10.setForeground(new Color(192,89,39));

b1.addMouseMotionListener(this);


b2.addMouseMotionListener(this);


b3.addMouseMotionListener(this);


b4.addMouseMotionListener(this);

}






  
public void mouseMoved(MouseEvent e) {

try{

Object ob=e.getSource();




if(ob==b1){


long table=Integer.parseInt(field.getText());




L1.setText(""+table+"        x        "+"1"+"        =        "+1*table);
L2.setText(""+table+"        x        "+"2"+"        =        "+2*table);
L3.setText(""+table+"        x        "+"3"+"        =        "+3*table);
L4.setText(""+table+"        x        "+"4"+"        =        "+4*table);
L5.setText(""+table+"        x        "+"5"+"        =        "+5*table);
L6.setText(""+table+"        x        "+"6"+"        =        "+6*table);
L7.setText(""+table+"        x        "+"7"+"        =        "+7*table);
L8.setText(""+table+"        x        "+"8"+"        =        "+8*table);
L9.setText(""+table+"        x        "+"9"+"        =        "+9*table);
L10.setText(""+table+"        x        "+"10"+"      =        "+10*table);








}
if(ob==b2){

JOptionPane.showMessageDialog(null,"Made By Shadab Ali Khowaja");

}
if(ob==b3){

field.requestFocus();
field.setText("");

L1.setText("");
L2.setText("");
L3.setText("");
L4.setText("");
L5.setText("");
L6.setText("");
L7.setText("");
L8.setText("");
L9.setText("");
L10.setText("");

}
if(ob==b4){

System.exit(0);

}
}catch(Exception esad){}
}




public void mouseDragged(MouseEvent e){}

public static void main(String args[]){


table tb=new table();

}
}