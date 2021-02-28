import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class loop extends JFrame implements ActionListener{
Thread t11,t12,t13;
int count,count2;
JLabel L1,L2,L3,L4,L5;

JButton b1,b2,b3,b4,b5;
JTextField t1,t2;
JFrame frm;
int style=3;

loop(){

    
    Font font1 = new Font("Gill Sans", style, 20);
	
    setSize(700,500);
	setDefaultCloseOperation(3);
	setLocation(340,100);
    setLayout(null);
	setTitle("Counting");
	
	
	
	
	L1=new JLabel("Star The Number   :");
	L1.setBounds(100,30,190,30);
	L1.setFont(font1);
	//L1.setToolTipText("Star The Number");
	add(L1);
	L5=new JLabel("");
	L5.setBounds(280,400,300,30);
	L5.setForeground(Color.red);
	L5.setVisible(false);
	L5.setFont(font1);
	
	add(L5);
	t1=new JTextField();
	t1.setBounds(275,70,200,25);
	t1.setFont(font1);
	t1.setToolTipText("Put First Number");
	add(t1);
	
	
	
	L2=new JLabel("End The Number   :");
	L2.setBounds(100,160,190,30);
	L2.setFont(font1);
	//L2.setToolTipText("End The Number");
	add(L2);
	
	t2=new JTextField();
	t2.setBounds(275,200,200,25);
	t2.setFont(font1);
	t2.setToolTipText("Put Second Number");
	add(t2);
	
	b1=new JButton("Count");
	b1.setBounds(320,300,100,70);
	b1.setFont(font1);
	b1.setToolTipText("Click Count");
	add(b1);
	
	
	
	b1.setBackground(Color.green);
	t1.setBackground(Color.yellow);
	t2.setBackground(Color.yellow);
	L1.setForeground(Color.red);
	L2.setForeground(Color.red);
	L1.setBackground(new Color(186,220,69));
	L2.setBackground(new Color(186,220,69));

	L1.setOpaque(true);
	L2.setOpaque(true);
	show();

	b1.addActionListener(this);


}
public void actionPerformed(ActionEvent e){

Object ob=e.getSource();
try{
int start=Integer.parseInt(t1.getText());
int end=Integer.parseInt(t2.getText());


String str="";
if(ob==b1){

L5.setVisible(false);
for(count=start; count<=end; count++){


str+=count;
str+="\n";


}

if(end>0 && end>=51){
JOptionPane.showMessageDialog(null,"Limit of 50");

}
else{



System.out.println(str);

}



if(count==start || count==end){

for(count=start; count>=end; count--){


str+=count;
str+="\n";


}

if(start>0 && start>=51){

JOptionPane.showMessageDialog(null,"Limit of 50");

}

else{



System.out.println(str);

}
}

}












}catch(Exception ee){

if(t1.getText().equals("") && t2.getText().equals("")){

t1.requestFocus();

L5.setVisible(true);
L5.setText("Puts the Number");

}
else if(t1.getText().equals("")){
t1.requestFocus();

L5.setVisible(true);
L5.setText("Put First Number");

}

else if(t2.getText().equals("")){

t2.requestFocus();

L5.setVisible(true);
L5.setText("Put Second Number");

}



else{

t1.requestFocus();

L5.setVisible(true);
L5.setText("Puts Only Numbers");

}



}




}
public static void main(String args[]){


loop lo=new loop();

}
}