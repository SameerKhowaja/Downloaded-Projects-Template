import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

class table extends JFrame implements ActionListener,KeyListener{
TextField t1,t2,t3,t4,t5;
Button b1;
Button b2;
Label L1,L2,L3,L4,L5;
Thread th;
table(){

int style=3;
    
    Font font1 = new Font("Gill Sans", style, 20);
	
    setBounds(150, 100, 500, 800);
	setDefaultCloseOperation(3);
	setLocationRelativeTo(null);
    setLayout(null);


	L1=new Label("Hello My Name is Shadab");
	L1.setBounds(50,30,1000,20);
	L1.setFont(font1);
	add(L1);
	
	
	t1=new TextField();
	t1.setBounds(50,60,310,30);
	t1.setFont(font1);
	add(t1);
	
	L2=new Label("My Father Name is Shoukat");
	L2.setBounds(50,130,1000,20);
	L2.setFont(font1);
	add(L2);
	
	t2=new TextField();
	t2.setBounds(50,160,310,30);
	t2.setFont(font1);
	add(t2);
	
	L3=new Label("I will Live In Hyderabad");
	L3.setBounds(50,230,1000,20);
	L3.setFont(font1);
	add(L3);
	
	t3=new TextField();
	t3.setBounds(50,260,310,30);
	t3.setFont(font1);
	add(t3);
	
	L4=new Label("I Like Computer Languages");
	L4.setBounds(50,330,1000,20);
	L4.setFont(font1);
	add(L4);
	
	t4=new TextField();
	t4.setBounds(50,360,310,30);
	t4.setFont(font1);
	add(t4);
	
	
	L5=new Label("My Roll No 2KHU7864JH@U2");
	L5.setBounds(50,430,1000,20);
	L5.setFont(font1);
	add(L5);
	
	t5=new TextField();
	t5.setBounds(50,460,310,30);
	t5.setFont(font1);
	add(t5);
	
	
	t2.setEditable(false);
	t3.setEditable(false);
	t4.setEditable(false);
	t5.setEditable(false);
	
	
	
	
	b1=new Button("Clear");
	
	b1.setBounds(50,600,90,70);
	
	b1.setFont(font1);
	b1.addActionListener(this);
	add(b1);
	
	
	b2=new Button("About");
	
	b2.setBounds(280,600,90,70);
	
	 b2.setFont(font1);
	
	add(b2);
	
	b1.addActionListener(this);
	
	b2.addActionListener(this);
	
	b1.setBackground(Color.green);
	
	b2.setBackground(Color.green);
	
	
	
	t1.setBackground(Color.yellow);
	t2.setBackground(Color.yellow);
	t3.setBackground(Color.yellow);
	t4.setBackground(Color.yellow);
	t5.setBackground(Color.yellow);
	

show();

	t1.addKeyListener(this);
	t2.addKeyListener(this);
	t3.addKeyListener(this);
	t4.addKeyListener(this);
	t5.addKeyListener(this);
	}
  public void keyPressed(KeyEvent e) {}
  
  public void keyReleased(KeyEvent e) {
  
  if(t1.getText().equals("Hello My Name is Shadab")){
	
		t2.setEditable(true);
		t1.setEditable(false);
		t1.setBackground(Color.green);
		t2.requestFocus();
	}

	if(t2.getText().equals("My Father Name is Shoukat")){
	
		t2.setEditable(false);
		t3.setEditable(true);
		t2.setBackground(Color.green);
		t3.requestFocus();
	}

	if(t3.getText().equals("I will Live In Hyderabad")){
	
		t3.setEditable(false);
		t4.setEditable(true);
		t3.setBackground(Color.green);
		t4.requestFocus();
	}


	if(t4.getText().equals("I Like Computer Languages")){
	
		t4.setEditable(false);
		t5.setEditable(true);
		t4.setBackground(Color.green);
		t5.requestFocus();
	}
	
	
	if(t5.getText().equals("My Roll No 2KHU7864JH@U2")){
	
		t5.setEditable(false);
		
		t5.setBackground(Color.green);
		
		JOptionPane.showMessageDialog(null,"God Job Press OK Repeat Again");
	  t1.requestFocus();
      t1.setText("");
      t2.setText("");
      t3.setText("");
      t4.setText("");
      t5.setText("");
      t1.setEditable(true);
      t2.setEditable(false);
      t3.setEditable(false);
      t4.setEditable(false);
      t5.setEditable(false);
      t1.setBackground(Color.yellow);
      t2.setBackground(Color.yellow);
      t3.setBackground(Color.yellow);
      t4.setBackground(Color.yellow);
      t5.setBackground(Color.yellow);
	
	}
  
  }
  
  public void keyTyped(KeyEvent e)
  {

	



}

public void actionPerformed(ActionEvent e){

Object ob=e.getSource();









if(ob==b1){
	t1.requestFocus();
	t1.setEditable(true);
	t2.setEditable(false);
	t3.setEditable(false);
	t4.setEditable(false);
	t5.setEditable(false);
	
	t1.setText("");
	t2.setText("");
	t3.setText("");
	t4.setText("");
	t5.setText("");
	t1.setBackground(Color.yellow);
    t2.setBackground(Color.yellow);
    t3.setBackground(Color.yellow);
    t4.setBackground(Color.yellow);
	
    t5.setBackground(Color.yellow);
	
}


if(ob==b2){
JOptionPane.showMessageDialog(null,"Made By Shadab Khowaja");
}







}
public static void main(String args[]){


table tb=new table();
}
}