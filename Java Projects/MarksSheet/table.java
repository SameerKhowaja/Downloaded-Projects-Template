import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class table extends JFrame implements ActionListener{
Button b1;
Button b2;
Button b3;

TextField t1;
TextField t2;
TextField t3;
TextField t4;
TextField t5;
TextField t6;
TextField t7;
TextField t8;
TextField t9;
Label L1;
Label L2;
Label L3;
Label L4;
Label L5;
Label L6;
Label L7;
Label L8;
Label L9;
Label L10;
Thread th;

Font font;

table(){

int style=3;

font=new Font("Segoe Print",style,20);
setBounds(150, 100, 500, 700);
setLayout(null);
setVisible(true);
setDefaultCloseOperation(3);



L1=new Label("Enter English Marks");
L1.setBounds(20,20,200,30);
L1.setFont(font);
L1.setBackground(Color.yellow);
add(L1);



t1=new TextField();
t1.setBounds(230,20,200,30);
t1.setFont(font);
add(t1);



L2=new Label("Enter Urdu Marks");
L2.setBounds(20,70,200,30);
L2.setFont(font);
L2.setBackground(Color.yellow);
add(L2);



t2=new TextField();
t2.setBounds(230,70,200,30);
t2.setFont(font);
add(t2);




L3=new Label("EnterGrammarMarks");
L3.setBounds(20,120,200,30);
L3.setFont(font);
L3.setBackground(Color.yellow);
add(L3);


t3=new TextField();
t3.setBounds(230,120,200,30);
t3.setFont(font);
add(t3);


L4=new Label("Enter Science Marks");
L4.setBounds(20,170,200,30);
L4.setFont(font);
L4.setBackground(Color.yellow);
add(L4);




t4=new TextField();
t4.setBounds(230,170,200,30);
t4.setFont(font);
add(t4);

L5=new Label("Enter Math Marks");
L5.setBounds(20,220,200,30);
L5.setFont(font);
L5.setBackground(Color.yellow);
add(L5);




t5=new TextField();
t5.setBounds(230,220,200,30);
t5.setFont(font);
add(t5);


L6=new Label("Total Marks");
L6.setBounds(20,270,200,30);
L6.setFont(font);
L6.setBackground(Color.green);
add(L6);



t6=new TextField();
t6.setBounds(230,270,200,30);
t6.setFont(font);
add(t6);



L7=new Label("Obtain Marks");
L7.setBounds(20,320,200,30);
L7.setFont(font);
L7.setBackground(Color.green);
add(L7);



t7=new TextField();
t7.setBounds(230,320,200,30);
t7.setFont(font);
add(t7);




L8=new Label("Percentage %");
L8.setBounds(20,370,200,30);
L8.setFont(font);
L8.setBackground(Color.green);
add(L8);


t8=new TextField();
t8.setBounds(230,370,200,30);
t8.setFont(font);
add(t8);


L9=new Label("Grade");
L9.setBounds(20,420,200,30);
L9.setFont(font);
L9.setBackground(Color.green);
add(L9);




t9=new TextField();
t9.setBounds(230,420,200,30);
t9.setFont(font);
add(t9);

t6.setEditable(false);
t7.setEditable(false);
t8.setEditable(false);
t9.setEditable(false);

b1=new Button("Clear");
b1.setBounds(60,490,100,40);
b1.setFont(font);
b1.setBackground(Color.red);
add(b1);


b2=new Button("Show");
b2.setBounds(170,490,100,40);
b2.setFont(font);
b2.setBackground(Color.green);
add(b2);





b3=new Button("About");
b3.setBounds(280,490,100,40);
b3.setFont(font);
b3.setBackground(Color.red);
add(b3);
for(int a=1; a<=300; a++){
try{
setBounds(a, 100, 500, 700);

Thread.sleep(10);
}catch(Exception e){}

}

b1.addActionListener(this);
b2.addActionListener(this);
b3.addActionListener(this);
}



public void actionPerformed(ActionEvent e){

Object ob=e.getSource();


if(ob==b1){

t1.requestFocus();
t1.getText();
t1.setText(null);

t2.getText();
t2.setText(null);

t3.getText();
t3.setText(null);

t4.getText();
t4.setText(null);

t5.getText();
t5.setText(null);


t6.getText();
t6.setText(null);


t7.getText();
t7.setText(null);

t8.getText();
t8.setText(null);


t9.getText();
t9.setText(null);


}
if(ob==b3){

JOptionPane.showMessageDialog(null,"Made Shadab Ali");
}



if(ob==b2){



int a=Integer.parseInt(t1.getText());
int b=Integer.parseInt(t2.getText());
int c=Integer.parseInt(t3.getText());
int d=Integer.parseInt(t4.getText());
int eg=Integer.parseInt(t5.getText());



int tm=500;

float obtainmarks=a+b+c+d+eg;
t6.setText(" "+tm);

t7.setText("  "+obtainmarks);

float per=(obtainmarks*100)/tm;



if(per>=90){

t8.setText(per+" %");
t9.setText("A");


}

else if(per>=80){

t8.setText(per+" %");
t9.setText("B");


}

else if(per>=70){

t8.setText(per+" %");
t9.setText("C");


}


else if(per>=60){

t8.setText(per+" %");
t9.setText("D");


}



else if(per>=50){

t8.setText(per+" %");
t9.setText("E");


}


else{

t8.setText(per+" %");
t9.setText("Sorry You are Fail");


}



}



}









public static void main(String args[]){


table tb=new table();

}
}
